using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormCheck : Form
    {
        Check _check;
        public FormCheck(Check check)
        {
            InitializeComponent();
            //txtCheck.Text = check.ResultPrintView;
            txtCheck.Text = check.AsPrintView();
            _check = check;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
            PrintDocument printdoc = new PrintDocument();
           
            printdoc.PrintPage += Printdoc_PrintPage;
            PrintDialog printdialog = new PrintDialog();

            printdialog.Document = printdoc;
            if (printdialog.ShowDialog() == DialogResult.OK)
                printdialog.Document.Print();
        }

        private void Printdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtCheck.Text,new Font("Consolas",11), Brushes.Black, 0 ,0);
        }
    }
}
