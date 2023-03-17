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
    public partial class FormCashBoxEdit : Form, IEntityEditor<CashBox>
    {
        public Form Form => this;
        BindingSource _bs;

        public FormCashBoxEdit()
        {
            InitializeComponent();

            _bs = new BindingSource();

            msktxtNumerCashBox.DataBindings.Add("Text", _bs, "Number");
            txtName.DataBindings.Add("Text", _bs, "Name");
        }

        public void Bind(CashBox entity)
        {
            _bs.DataSource = entity;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            _bs.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _bs.CancelEdit();
            Close();
        }
    }
}
