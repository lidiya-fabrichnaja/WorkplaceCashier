using System;
using System.Linq;
using System.Windows.Forms;
using UI.Abstractions;
using DAL.Repositories;
using Models.Abstactions;

namespace UI
{
    public partial class FormGrid : Form
    {
        public FormGrid()
        {
            InitializeComponent();
        }

        internal virtual void btnAdd_Click(object sender, EventArgs e) { }

        internal virtual void btnDel_Click(object sender, EventArgs e) { }

        internal virtual void btnEdit_Click(object sender, EventArgs e) { }

        internal virtual void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) { }
    }
   
}
