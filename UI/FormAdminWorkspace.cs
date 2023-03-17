using DAL;
using DAL.Commons;
using DAL.Repositories;
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
using Models;

namespace UI
{
    public partial class FormAdminWorkspace : Form
    {

        public FormAdminWorkspace()
        {
            InitializeComponent();
        }
        private void FormAdminWorkspace_Shown(object sender, EventArgs e)
        {
            var frm = new FormAdminPanel();
            frm.Text = ShowAdminPanelToolStripMenuItem.Text;
            frm.MdiParent = this;
            ShowChild(frm);
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            string text = ((ToolStripMenuItem)sender).Text;

            FormGrid<Product> frm = null;
            
           
            if (IsActivatedForm(text, out frm))
            {
                frm.Activate();
            }
            else
            {    
                frm = new FormGrid<Product>(new FormProductEdit())
                {
                    Text = text,
                    MdiParent = this
                };
                frm.AddColumn("категория", "CategoryName");

                frm.UpdateGrid();
                ShowChild(frm);

            }
        }

        private void catToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = ((ToolStripMenuItem)sender).Text;

            FormGrid<Category> frm = null;
            if(IsActivatedForm(text,out frm))
            {
                frm.Activate();
            }
            else
            {
                frm = new FormGrid<Category>(new FormCategoryEdit()) {
                    Text = text,
                    MdiParent = this
                };

                frm.UpdateGrid();
                ShowChild(frm);
            }
        }
       

        private void orgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = ((ToolStripMenuItem)sender).Text;
            FormGrid<Organization> frm = null;
            if (IsActivatedForm(text, out frm))
            {
                frm.Activate();
            }
            else
            {
                frm = new FormGrid<Organization>(new FormOrganizationEdit())
                {
                    Text = text,
                    MdiParent = this
                };
                frm.AddColumn("ИНН", "INN");
                frm.UpdateGrid();
                ShowChild(frm);
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = ((ToolStripMenuItem)sender).Text;
            FormGrid<User> frm = null;
            if (IsActivatedForm(text, out frm))
            {
                frm.Activate();
            }
            else
            {
                frm = new FormGrid<User>(new FormUsersEdit())
                {
                    Text = text,
                    MdiParent = this

                };
                frm.AddColumn("Login", "Login");
                frm.AddColumn("Тип пользователя", "TypeName");
                frm.AddColumn("Password", "Password");
                frm.UpdateGrid();
                ShowChild(frm);
            }
        }

        public bool IsActivatedForm<T>(string text,out T frm) where T : Form
        {
            frm = Application
                .OpenForms
                .Cast<Form>()
                .FirstOrDefault(x => x.GetType() == typeof(T) && x.Text == text) as T;

            return frm != null ? true : false;
        }

        private void ShowChild(Form frm)
        {
            frm.Show();

            ActivateMdiChild(null);
            ActivateMdiChild(frm);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horisontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void sallersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = ((ToolStripMenuItem)sender).Text;
            FormGrid<Seller> frm = null;
            if (IsActivatedForm(text, out frm))
            {
                frm.Activate();
            }
            else
            {
                frm = new FormGrid<Seller>(new FormSellerEdit())
                {
                    Text = text,
                    MdiParent = this
                };

                frm.UpdateGrid();
                ShowChild(frm);
            }
        }

        private void unitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = ((ToolStripMenuItem)sender).Text;
            FormGrid<Unit> frm = null;
            if (IsActivatedForm(text, out frm))
            {
                frm.Activate();
            }
            else
            {
                frm = new FormGrid<Unit>(new FormUnitsEdit())
                {
                    Text = text,
                    MdiParent = this
                };
                frm.UpdateGrid();
                ShowChild(frm);
            }
        }

        private void cashboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = ((ToolStripMenuItem)sender).Text;
            FormGrid<CashBox> frm = null;
            if (IsActivatedForm(text, out frm))
            {
                frm.Activate();
            }
            else
            {
                frm = new FormGrid<CashBox>(new FormCashBoxEdit())
                {
                    Text = text,
                    MdiParent = this
                };
                //frm.AddColumn("Number", "Number");
                frm.UpdateGrid();
                ShowChild(frm);
            }
        }

        private void showSellerWorkSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSession = new FormSession(Program.User);
            if(frmSession.ShowDialog() == DialogResult.OK)
            {
                new FormSellerWorkspace(frmSession.Session).ShowDialog();
            }
        }

        private void ShowAdminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = ((ToolStripMenuItem)sender).Text;
            FormAdminPanel frm = null;
            if (IsActivatedForm(text, out frm))
            {
                frm.Activate();
            }
            else
            {
                frm = new FormAdminPanel()
                {
                    Text = text,
                    MdiParent = this
                };

                ShowChild(frm);
            }
        }


    }
}
