using Models.Abstactions;
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
    public partial class FormChoise<T> : Form where T : IGridRow
    {
        public T Current { get; private set; }

        public FormChoise(IEnumerable<T> items)
        {
            InitializeComponent(); foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Current = (T)listBox1.SelectedItem;
            DialogResult = DialogResult.OK;

        }
    } 
}
