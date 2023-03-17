using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.Repositories;
using Models;

namespace UI
{
    public partial class FormSession : Form
    {

        public Session Session { get; private set; }

        public FormSession(User user)
        {
            Session = new Session { User = user };

            InitializeComponent();
            cbPlace.DataSource = new CommonRepository<Seller>().GetAll();
            lUser.Text = user.Name;
        }

        private void cbPlace_SelectedValueChanged(object sender, EventArgs e)
        {
            var selected = ((ComboBox)sender).SelectedItem;
            if (selected == null) return;
            cbCashBox.DataSource = ((Seller)selected).CashBoxes;
        }

        private void cbCashBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Session.CashBox = null;

            var selected = ((ComboBox)sender).SelectedItem;
            if (selected == null) return;

            Session.CashBox = (CashBox)selected;
         
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Session.BeginDate = DateTime.Now;
            try
            {
                DataContainer.GetContext().Sessions.Add(Session);
                DataContainer.GetContext().SaveChanges();
            }catch(Exception ex)
            {
                var m = ex.ToString();
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
