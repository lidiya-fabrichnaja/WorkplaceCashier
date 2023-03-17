using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Abstactions;

namespace UI
{
    public partial class UProductView : UserControl
    {
        /// <summary>
        /// Кол-во
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Возникает при шелчке,выборе 
        /// </summary>
        public event EventHandler OnSelected = delegate { };

        /// <summary>
        /// Возникает при изменении кол-ва
        /// </summary>
        public event EventHandler<int> OnCountChanged = delegate { };

        /// <summary>
        /// Ссылка на продукт
        /// </summary>
        public IProduct Product { get; private set; }
        
        public UProductView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// UserControl продукта
        /// </summary>
        /// <param name="product">ссылка на продукт</param>
        /// <param name="count">кол-во</param>
        public UProductView(IProduct product, int count)
        {
            Product = product;
            Count = count;
            InitializeComponent();
            lName.Text = product.Name;
            lCount.Text = Count.ToString();
        }

        private void INC_count()
        {
            Count++;
            lCount.Text = Count.ToString();
        }

        private void BtnInc_Click(object sender, EventArgs e)
        {
            if (Count >= 100) return;
            Count++;
            lCount.Text = Count.ToString();
            OnCountChanged?.Invoke(this, Count);
        }

        private void BtnDec_Click(object sender, EventArgs e)
        {
            if (Count == 0) return;
            Count--;
            lCount.Text = Count.ToString();
            OnCountChanged?.Invoke(this, Count);
        }

        private void UProductView_Enter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            OnSelected?.Invoke(this, EventArgs.Empty);
        }

        private void UProductView_Leave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }
    }
}
