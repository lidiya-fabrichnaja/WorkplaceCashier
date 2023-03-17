using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using DAL.Repositories;
using Models;
using UI.Abstractions;

namespace UI
{
    public partial class FormProductEdit : Form, IEntityEditor<Product>
    {
        public Form Form => this;

        BindingSource _bs;

        public FormProductEdit()
        {
            InitializeComponent();

            cbCategory.DataSource = new CommonRepository<Category>().GetAll();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "ID";

            cbUnit.DataSource = new CommonRepository<Unit>().GetAll();
            cbUnit.DisplayMember = "Name";
            cbUnit.ValueMember = "ID";

            _bs = new BindingSource();

            txtName.DataBindings.Add("Text", _bs, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            cbCategory.DataBindings.Add("SelectedValue", _bs, "CategoryID", true, DataSourceUpdateMode.OnPropertyChanged);
            cbUnit.DataBindings.Add("SelectedValue", _bs, "UnitID", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPrice.DataBindings.Add("Text", _bs, "Price", true, DataSourceUpdateMode.OnPropertyChanged);   

        }

        private void btnApply_Click(object sender, System.EventArgs e)
        {
            _bs.EndEdit();
            DialogResult = DialogResult.OK;
        }

        public void Bind(Product entity)
        {
            _bs.DataSource = entity;
            btnColorProd.BackColor = Color.FromArgb(entity.Color);
        }

        private void btnColorProd_Click(object sender, System.EventArgs e)
        {
            var dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                ((Product)_bs.Current).Color = dlg.Color.ToArgb();

                btnColorProd.BackColor = dlg.Color;
            }
        }

        private void checkComposite_CheckedChanged(object sender, System.EventArgs e)
        {
           
        }
    }
}
