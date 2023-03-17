﻿namespace UI
{
    partial class FormCategoryEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoryEdit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnColorCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnApplyCat = new System.Windows.Forms.Button();
            this.btnCancelCat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnColorCat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(487, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свойства категории";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цвет";
            // 
            // btnColorCat
            // 
            this.btnColorCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorCat.Location = new System.Drawing.Point(379, 44);
            this.btnColorCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColorCat.Name = "btnColorCat";
            this.btnColorCat.Size = new System.Drawing.Size(100, 25);
            this.btnColorCat.TabIndex = 3;
            this.btnColorCat.UseVisualStyleBackColor = true;
            this.btnColorCat.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(13, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(356, 22);
            this.txtName.TabIndex = 0;
            // 
            // btnApplyCat
            // 
            this.btnApplyCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyCat.Location = new System.Drawing.Point(292, 113);
            this.btnApplyCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApplyCat.Name = "btnApplyCat";
            this.btnApplyCat.Size = new System.Drawing.Size(100, 28);
            this.btnApplyCat.TabIndex = 4;
            this.btnApplyCat.Text = "Применить";
            this.btnApplyCat.UseVisualStyleBackColor = true;
            this.btnApplyCat.Click += new System.EventHandler(this.btnApplyCat_Click);
            // 
            // btnCancelCat
            // 
            this.btnCancelCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelCat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelCat.Location = new System.Drawing.Point(400, 113);
            this.btnCancelCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelCat.Name = "btnCancelCat";
            this.btnCancelCat.Size = new System.Drawing.Size(100, 28);
            this.btnCancelCat.TabIndex = 5;
            this.btnCancelCat.Text = "Отмена";
            this.btnCancelCat.UseVisualStyleBackColor = true;
            this.btnCancelCat.Click += new System.EventHandler(this.btnCancelCat_Click);
            // 
            // FormCategoryEdit
            // 
            this.AcceptButton = this.btnApplyCat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelCat;
            this.ClientSize = new System.Drawing.Size(507, 145);
            this.Controls.Add(this.btnCancelCat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnApplyCat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(522, 182);
            this.Name = "FormCategoryEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор категории";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColorCat;
        private System.Windows.Forms.Button btnCancelCat;
        private System.Windows.Forms.Button btnApplyCat;
        private System.Windows.Forms.Label label2;
    }
}