using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormSellerWorkspace : Form
    {
        //Событие выбрной категории
        public event CategoryEventHandler OnCategorySelect = delegate { };

        Session _session;
        Timer _timer;
        UProductView _current;

        public FormSellerWorkspace(Session session)
        {
            _session = session;

            InitializeComponent();
          
            _timer = new Timer();
            _timer.Enabled = true;
            _timer.Tick += Timer_Tick;
            _timer.Interval = 1000;
            lbNameCashier.Text = UI.Program.User.Name;
            lNumberSession.Text = _session.StrId();
           
            lbDate.Text = DateTime.Now.ToShortDateString();
        
            lbTime.Text = DateTime.Now.ToLongTimeString();
           
            LoadCategory(DataContainer.GetContext().Categories.ToList());
           
            OnCategorySelect += UCategoryView_OnCategorySelect;
        }

       
        private void Timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

       
        public void LoadCategory(ICollection<Category> categories)
        {
          
            flpCategories.Controls.Clear();

            foreach (var cat in categories)
            { 
                Button btn = new Button
                {
                    Name = "btn_" + ((Models.Abstactions.IEntity)cat).ID.ToString(),
                    Size = new Size(130, 80),
                    Font = new Font("Arial", 14),
                      
                    BackColor = Color.FromArgb(cat.Color),
                    Text = cat.Name
                };

                btn.MouseClick += (sender, arg) => {
                    
                    OnCategorySelect?.Invoke(cat);
                };

                flpCategories.Controls.Add(btn);
            }
        }

        private void UCategoryView_OnCategorySelect(Category category)
        {
            flpProducts.Controls.Clear();

            foreach (var p in category.Products)
            {
                Button btn = new Button
                {
                    Name = "btn_" + p.ID.ToString(),
                    Size = new Size(200, 80),
                    Font = new Font("Arial",14),
                    BackColor = Color.FromArgb(p.Color),
                    Text = p.Name
                };

                btn.MouseClick += (sender, arg) => {
        
                    var u = new UProductView(p,1 );
                    
                    u.Name = nameof(UProductView) + "_" + p.ID;
                    
                    u.OnSelected += (s, e) => {
                        _current = (UProductView)s;
                    };

                    u.OnCountChanged += (s, e) => {
                        RecalcSumm();
                    };

                    if (!flpOrder.Controls.ContainsKey(u.Name)) {
                        flpOrder.Controls.Add(u);
                        RecalcSumm();
                    }
                };

                flpProducts.Controls.Add(btn);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (_current == null)
                return;
            flpOrder.Controls.RemoveByKey(_current.Name);
            _current.Dispose();
            _current = null;

            RecalcSumm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            flpOrder.Controls.Clear();

            lTotalPrice.Text = "";
        }


        private void FormSellerWorkspace_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_session.EndDate == null)
            {
                MessageBox.Show("Перед закрытием окна, завершите смену", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void btnCloseSession_Click(object sender, EventArgs e)
        {
     
            _session.EndDate = DateTime.Now;
 
            _session.Sum =  _session.CashBox.Checks.Select(x => x.Sum).Sum();

            DataContainer.GetContext().SaveChanges();
            this.Close();
        }
        /// <summary>
        /// безналичный расчет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayBank_Click(object sender, EventArgs e)
        {
            Pay(OrderType.PayCard);
            
        }

        /// <summary>
        /// наличный расчет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayCash_Click(object sender, EventArgs e)
        {
            Pay(OrderType.PayCash);
        }


        /// <summary>
        /// вывод суммы продуктов на форму 
        /// </summary>
        private void RecalcSumm()
        {
            _sum = 0;
            for (int i = 0; i <= flpOrder.Controls.Count - 1; i++)
            {
                var pv = (UProductView)flpOrder.Controls[i];

                if (pv.Count > 0)
                {
                    _sum += pv.Count * pv.Product.Price;
                }
            }

            lTotalPrice.Text = _sum.ToString();
        }

        decimal _sum;

        /// <summary>
        /// метод реализует процесс оплаты
        /// </summary>
        /// <param name="type"></param>
        void Pay(OrderType type)
        {
            if (flpOrder.Controls.Count == 0) return;
        
            var check = new Check(_session)
            {
                CashBox = _session.CashBox,
                Date = DateTime.Now,
                Type = type
            };
           
            for (int i = 0; i <= flpOrder.Controls.Count - 1; i++)
            {
                var pv = (UProductView)flpOrder.Controls[i];

                if (pv.Count > 0)
                {
                    check.Rows.Add(new CheckRow
                    {
                        Product = (Product)pv.Product,
                        Count = pv.Count,
                        Price = pv.Product.Price,
                    });
                }
            }

            check.Calc();
            
            if(check.Type == OrderType.PayCash)
            {
                var frm = new FormPaid();
                frm.Bind(check);
                frm.ShowDialog();
            }


            DataContainer.GetContext().Checks.Add(check);
            DataContainer.GetContext().SaveChanges();


            _session.CashBox.Fix(check);

            var frmchecks = new FormCheck(check);
            frmchecks.ShowDialog();

            btnClear_Click(null, null);
        }
    }
}
