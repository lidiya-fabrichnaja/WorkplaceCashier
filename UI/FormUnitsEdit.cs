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
    public partial class FormUnitsEdit : Form, IEntityEditor<Unit>
    {
        public Form Form => this;

        BindingSource _bs;
        public FormUnitsEdit()
        {
            InitializeComponent();
            _bs = new BindingSource();

            txtName.DataBindings.Add("Text", _bs, "Name");
        }


        public void Bind(Unit entity)
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
