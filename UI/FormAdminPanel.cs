using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormAdminPanel : Form
    {
        public FormAdminPanel()
        {
            InitializeComponent();
        }


        Check _check = null;

    
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearchValue.Text))
            {
                int checkID;

                if (int.TryParse(txtSearchValue.Text, out checkID))
                {
                    var ctx = DataContainer.GetContext();
                

                    _check = ctx.Checks.FirstOrDefault(x => x.ID == checkID);

                    if (_check != null)
                    {
                        txtCheckPrintView.Text = _check.ResultPrintView;
                    }
                }
            }
        }

 
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = DataContainer.GetContext().Database.SqlQuery<ViewSession>("select * from View_Sessions").ToList();
            }catch(SqlException ex)
            {
          
                if (ex.Number == 208 && ex.Message.Contains("View_Sessions"))
                {
                    
                    string view_source_file = Application.StartupPath + "\\View_Sessions.sql";
                    if (File.Exists(view_source_file))
                    {
              
                        var create_view_sript = File.ReadAllText(view_source_file);

                        DataContainer.GetContext()
                            .Database
                            .ExecuteSqlCommand(TransactionalBehavior.EnsureTransaction,create_view_sript);

                        dataGridView1.DataSource = DataContainer.GetContext()
                            .Database.SqlQuery<ViewSession>("select * from View_Sessions").ToList();

                    }
                    else
                    {
                        MessageBox.Show("Не найден файл: " + view_source_file);
                    }
                }
            }
        }

        public class ViewSession
        {
            [DisplayName("Пользователь")]
            public string UserName { get; set; }

            [DisplayName("Рабочее место")]
            public string CashBoxPlace { get; set; }
            [DisplayName("Номер кассового")]
            public string CashBoxNumebr { get; set; }

            [DisplayName("Сейсия (Смена)")]
            public int SessionNumebr { get; set; }

            [DisplayName("Открыта")]
            public DateTime BeginDate { get; set; }

            [DisplayName("Закрыта")]
            public DateTime EndDate { get; set; }

            [DisplayName("Сумма")   ]
            public Decimal Sum { get; set; }

            [DisplayName("Кол-во")]
            public int CheckCount { get; set; }

        }

        private void btnCashBack_Click(object sender, EventArgs e)
        {
            if(_check == null)
            {
                MessageBox.Show("Для возврата чека, укажите в поиске номер чека и нажмите поиск");
            }
            else
            {
                if (_check.IsCashBack) return;

                if (MessageBox.Show($@"Вы действительно хотите оформить 
                                    возврат чека {_check.ID} на сумму {_check.Sum}"
                                    , "Внимание"
                                    , MessageBoxButtons.YesNo
                                    , MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    _check.IsCashBack = true;
                    _check.ResultPrintView += "\r\nОсуществлен возврат " + DateTime.Now.ToString();

                    var session = DataContainer.GetContext().Sessions.FirstOrDefault(x => x.ID == _check.SessionID);
                    session.Sum -= _check.Sum;

                    txtCheckPrintView.Text = _check.ResultPrintView;

                    DataContainer.GetContext().SaveChanges();
                }
            }
        }
    }
}
