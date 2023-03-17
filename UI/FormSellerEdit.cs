using DAL;
using DAL.Repositories;
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
    public partial class FormSellerEdit : Form, IEntityEditor<Seller>
    {
        public Form Form => this;

        BindingSource _bs;

        public FormSellerEdit()
        {
            InitializeComponent();
            _bs = new BindingSource();
            cbOrganization.DataSource = new CommonRepository<Organization>().GetAll();
            cbOrganization.DisplayMember = "Name";
            cbOrganization.ValueMember = "ID";

            txtName.DataBindings.Add("Text", _bs, "Name");
            txtAdress.DataBindings.Add("Text", _bs, nameof(Seller.Adress));
            cbOrganization.DataBindings.Add("SelectedValue", _bs, nameof(Seller.OrgnizationID), true, DataSourceUpdateMode.OnPropertyChanged);

            dgvCashBox.AutoGenerateColumns = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Bind(Seller entity)
        {
            _bs.DataSource = entity;
            dgvCashBox.DataSource = new BindingSource() { DataSource = entity.CashBoxes };
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var frm = new FormChoise<CashBox>(new CommonRepository<CashBox>().GetAll());

            if(frm.ShowDialog() == DialogResult.OK)
            {
                if(((Seller)_bs.DataSource).CashBoxes.Any(x=>x.Number == frm.Current.Number))
                {
                    MessageBox.Show("ККМ уже добавлен");
                    return;
                }
                frm.Current.OrganizationID = ((Seller)_bs.DataSource).OrgnizationID;


                ((Seller)_bs.DataSource).CashBoxes.Add(frm.Current);

              
                ((BindingSource)dgvCashBox.DataSource).ResetBindings(false);
                
            }

        }

        private void cbOrganization_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var current = ((BindingSource)dgvCashBox.DataSource).Current;
            if (current == null) return;

            ((BindingSource)dgvCashBox.DataSource).Remove(current);

        }
    }
}
