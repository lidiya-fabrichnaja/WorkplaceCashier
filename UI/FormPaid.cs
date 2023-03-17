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
    public partial class FormPaid : Form
    {
        Check _check;
        public FormPaid()
        {
            InitializeComponent();
        }

        public void Bind(Check check) {
            _check = check;
        }

        bool _isComplite = false;
   
        private void txtSumPaid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (_isComplite)
                    Close();
                try
                {
                    decimal sumFact;
                    if (String.IsNullOrEmpty(txtSumPaid.Text))
                        throw new ArgumentException("Введите сумму");

                    if (!decimal.TryParse(txtSumPaid.Text, out sumFact)) 
                        throw new ArgumentException("!@@$%!!$");

                    if (sumFact < _check.Sum)
                        throw new ArgumentException("Маленькая сумма");

                    _check.SumFact = sumFact;
                    txtSumSaldo.Text = _check.SumSaldo.ToString();
                    _isComplite = true;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void FormPaid_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSumSaldo.Text))
                e.Cancel = true;
        }

        private void FormPaid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
