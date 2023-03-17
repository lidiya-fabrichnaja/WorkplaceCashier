namespace UI
{
    partial class FormCheck
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
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCheck
            // 
            this.txtCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheck.Location = new System.Drawing.Point(2, 4);
            this.txtCheck.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheck.Multiline = true;
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.ReadOnly = true;
            this.txtCheck.Size = new System.Drawing.Size(414, 464);
            this.txtCheck.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(2, 469);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(414, 57);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 528);
            this.Controls.Add(this.txtCheck);
            this.Controls.Add(this.btnPrint);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(435, 575);
            this.Name = "FormCheck";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCheck;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private System.Windows.Forms.Button btnPrint;
    }
}