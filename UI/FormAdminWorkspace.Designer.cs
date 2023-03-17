namespace UI
{
    partial class FormAdminWorkspace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminWorkspace));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеКассамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sallersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAdminPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSellerWorkSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horisontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.управлениеКассамиToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(973, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.catToolStripMenuItem,
            this.orgToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.productsToolStripMenuItem.Text = "Справочник продуктов";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // catToolStripMenuItem
            // 
            this.catToolStripMenuItem.Name = "catToolStripMenuItem";
            this.catToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.catToolStripMenuItem.Text = "Справочник категорий";
            this.catToolStripMenuItem.Click += new System.EventHandler(this.catToolStripMenuItem_Click);
            // 
            // orgToolStripMenuItem
            // 
            this.orgToolStripMenuItem.Name = "orgToolStripMenuItem";
            this.orgToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.orgToolStripMenuItem.Text = "Справочник организаций";
            this.orgToolStripMenuItem.Click += new System.EventHandler(this.orgToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.usersToolStripMenuItem.Text = "Справочник пользователей";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // управлениеКассамиToolStripMenuItem
            // 
            this.управлениеКассамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sallersToolStripMenuItem,
            this.cashboxToolStripMenuItem,
            this.unitsToolStripMenuItem,
            this.ShowAdminPanelToolStripMenuItem,
            this.showSellerWorkSpaceToolStripMenuItem});
            this.управлениеКассамиToolStripMenuItem.Name = "управлениеКассамиToolStripMenuItem";
            this.управлениеКассамиToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.управлениеКассамиToolStripMenuItem.Text = "АРМ";
            // 
            // sallersToolStripMenuItem
            // 
            this.sallersToolStripMenuItem.Name = "sallersToolStripMenuItem";
            this.sallersToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.sallersToolStripMenuItem.Text = "Точки продажи";
            this.sallersToolStripMenuItem.Click += new System.EventHandler(this.sallersToolStripMenuItem_Click);
            // 
            // cashboxToolStripMenuItem
            // 
            this.cashboxToolStripMenuItem.Name = "cashboxToolStripMenuItem";
            this.cashboxToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.cashboxToolStripMenuItem.Text = "Кассы";
            this.cashboxToolStripMenuItem.Click += new System.EventHandler(this.cashboxToolStripMenuItem_Click);
            // 
            // unitsToolStripMenuItem
            // 
            this.unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            this.unitsToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.unitsToolStripMenuItem.Text = "Единицы измерения";
            this.unitsToolStripMenuItem.Click += new System.EventHandler(this.unitsToolStripMenuItem_Click);
            // 
            // ShowAdminPanelToolStripMenuItem
            // 
            this.ShowAdminPanelToolStripMenuItem.Name = "ShowAdminPanelToolStripMenuItem";
            this.ShowAdminPanelToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.ShowAdminPanelToolStripMenuItem.Text = "Панель инструментов";
            this.ShowAdminPanelToolStripMenuItem.Click += new System.EventHandler(this.ShowAdminPanelToolStripMenuItem_Click);
            // 
            // showSellerWorkSpaceToolStripMenuItem
            // 
            this.showSellerWorkSpaceToolStripMenuItem.Name = "showSellerWorkSpaceToolStripMenuItem";
            this.showSellerWorkSpaceToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.showSellerWorkSpaceToolStripMenuItem.Text = "Рабочее место кассира";
            this.showSellerWorkSpaceToolStripMenuItem.Click += new System.EventHandler(this.showSellerWorkSpaceToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horisontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.windowsToolStripMenuItem.Text = "Окна";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.cascadeToolStripMenuItem.Text = "Каскадно";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horisontalToolStripMenuItem
            // 
            this.horisontalToolStripMenuItem.Name = "horisontalToolStripMenuItem";
            this.horisontalToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.horisontalToolStripMenuItem.Text = "Горизонтально";
            this.horisontalToolStripMenuItem.Click += new System.EventHandler(this.horisontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.tileVerticalToolStripMenuItem.Text = "Вертикально";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // FormAdminWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 574);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdminWorkspace";
            this.ShowIcon = false;
            this.Text = "Рабочее место адмистратора";
            this.Shown += new System.EventHandler(this.FormAdminWorkspace_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horisontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеКассамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sallersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowAdminPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSellerWorkSpaceToolStripMenuItem;
    }
}