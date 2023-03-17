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
    public partial class FormAuthorization : Form
    {

        public User User { get; private set; }
        public FormAuthorization()
        {
            InitializeComponent();
            txtLogin.Focus();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            var result = UserManager.Validate(txtLogin.Text, txtPassword.Text);

            if (result.Status == DAL.Commons.ActionStatus.Ok)
            {

                User = UserManager.Login(txtLogin.Text, txtPassword.Text);
                if (User == null)
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                else
                    DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(result.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                btnInput.Focus();
                btnInput_Click(this, e);
            }
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }
    }
}
