using Models;
using Models.Helpers;
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
    public partial class FormUsersEdit : Form, IEntityEditor<User>
    {
        public Form Form => this;

        BindingSource _bs;

        public FormUsersEdit()
        {
            InitializeComponent();

            _bs = new BindingSource();


            //cbTypeUser.DataSource = (from UserType x in Enum.GetValues(typeof(UserType))
            //select new { Value = x, Name = EnumHelper.GetDescription(x) }).ToList();

            cbTypeUser.DataSource = EnumHelper.AsDataSource<UserType>();

            cbTypeUser.DisplayMember = "Name";
            cbTypeUser.ValueMember = "Value";

            cbTypeUser.DataBindings.Add("SelectedValue", _bs, "Type", true, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", _bs, "Name");
            txtLogin.DataBindings.Add("Text", _bs, "Login");
            txtPassword.DataBindings.Add("Text", _bs, "Password");

        }


        public void Bind(User entity)
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
