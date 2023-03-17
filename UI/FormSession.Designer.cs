namespace UI
{
    partial class FormSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSession));
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.cbCashBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPlace
            // 
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Location = new System.Drawing.Point(12, 85);
            this.cbPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(373, 24);
            this.cbPlace.TabIndex = 0;
            this.cbPlace.SelectedValueChanged += new System.EventHandler(this.cbPlace_SelectedValueChanged);
            // 
            // cbCashBox
            // 
            this.cbCashBox.FormattingEnabled = true;
            this.cbCashBox.Location = new System.Drawing.Point(12, 143);
            this.cbCashBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCashBox.Name = "cbCashBox";
            this.cbCashBox.Size = new System.Drawing.Size(373, 24);
            this.cbCashBox.TabIndex = 1;
            this.cbCashBox.SelectedValueChanged += new System.EventHandler(this.cbCashBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Точка продажи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кассовые аппараты";
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(12, 9);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(102, 16);
            this.lUser.TabIndex = 4;
            this.lUser.Text = "Пользователь";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(261, 217);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(123, 217);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(133, 41);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Ок";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // FormSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 270);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCashBox);
            this.Controls.Add(this.cbPlace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Открытие смены";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlace;
        private System.Windows.Forms.ComboBox cbCashBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
    }
}