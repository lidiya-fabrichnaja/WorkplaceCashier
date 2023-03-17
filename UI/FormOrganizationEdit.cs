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
    public partial class FormOrganizationEdit : Form,IEntityEditor<Organization>
    {
        public Form Form => this;

        BindingSource _bs;

        public FormOrganizationEdit()
        {
            _bs = new BindingSource();

            InitializeComponent();

            txtName.DataBindings.Add("Text", _bs, "Name");
            txtInn.DataBindings.Add("Text", _bs, "INN");

        }


        public void Bind(Organization entity)
        {
            _bs.DataSource = entity;
             listBox1.DataSource = new BindingSource { DataSource = entity.Seller };

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            _bs.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            var frm = new FormSellerEdit();
            frm.Bind((Seller)listBox1.SelectedItem);

            if (frm.ShowDialog() == DialogResult.OK)
                ((BindingSource)listBox1.DataSource).ResetBindings(false);

        }
    }
}
