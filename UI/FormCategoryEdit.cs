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
using UI.Abstractions;

namespace UI
{
    public partial class FormCategoryEdit : Form,IEntityEditor<Category>
    {
        public Form Form => this;

        BindingSource _bs;

        public FormCategoryEdit()
        {
            InitializeComponent();
            _bs = new BindingSource();
            txtName.DataBindings.Add("Text", _bs, "Name");
        }


        public void Bind(Category entity)
        {
            _bs.DataSource = entity;
            btnColorCat.BackColor = Color.FromArgb(entity.Color);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnColorCat.BackColor  = colorDialog1.Color;
                ((Category)_bs.Current).Color = colorDialog1.Color.ToArgb();
            }
        }

        private void btnApplyCat_Click(object sender, EventArgs e)
        {
            _bs.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void btnCancelCat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
