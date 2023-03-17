using Models.Abstactions;
using System.Windows.Forms;

namespace UI
{
    partial class FormGrid
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
        internal void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrid));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAdd,
            this.toolStripBtnEdit,
            this.toolStripBtnDel,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(585, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnAdd
            // 
            this.toolStripBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAdd.Image = global::UI.Properties.Resources.page_white_add;
            this.toolStripBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAdd.Name = "toolStripBtnAdd";
            this.toolStripBtnAdd.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnAdd.ToolTipText = "Добавить";
            this.toolStripBtnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripBtnEdit
            // 
            this.toolStripBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnEdit.Image = global::UI.Properties.Resources.pencil;
            this.toolStripBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEdit.Name = "toolStripBtnEdit";
            this.toolStripBtnEdit.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnEdit.ToolTipText = "Изменить";
            this.toolStripBtnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripBtnDel
            // 
            this.toolStripBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnDel.Image = global::UI.Properties.Resources.page_white_delete;
            this.toolStripBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDel.Name = "toolStripBtnDel";
            this.toolStripBtnDel.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnDel.Text = "toolStripButton2";
            this.toolStripBtnDel.ToolTipText = "Удалить";
            this.toolStripBtnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 27);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(585, 423);
            this.dgv.TabIndex = 1;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 50;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Наименование";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // FormGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGrid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.ToolStripButton toolStripBtnAdd;
        internal System.Windows.Forms.ToolStripButton toolStripBtnDel;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colName;
        internal System.Windows.Forms.ToolStripButton toolStripBtnEdit;
    }
}