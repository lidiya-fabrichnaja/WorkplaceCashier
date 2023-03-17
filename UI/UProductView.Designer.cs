namespace UI
{
    partial class UProductView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lCount = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnInc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCount.Location = new System.Drawing.Point(590, 16);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(26, 29);
            this.lCount.TabIndex = 2;
            this.lCount.Text = "0";
            // 
            // lName
            // 
            this.lName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(19, 16);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(80, 29);
            this.lName.TabIndex = 3;
            this.lName.Text = "Empty";
            // 
            // btnDec
            // 
            this.btnDec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDec.Image = global::UI.Properties.Resources.iconfinder_remove_1011541;
            this.btnDec.Location = new System.Drawing.Point(622, 4);
            this.btnDec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(50, 50);
            this.btnDec.TabIndex = 1;
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.BtnDec_Click);
            // 
            // btnInc
            // 
            this.btnInc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInc.Image = global::UI.Properties.Resources.iconfinder_add_1012331;
            this.btnInc.Location = new System.Drawing.Point(528, 4);
            this.btnInc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(50, 50);
            this.btnInc.TabIndex = 0;
            this.btnInc.UseVisualStyleBackColor = true;
            this.btnInc.Click += new System.EventHandler(this.BtnInc_Click);
            // 
            // UProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnInc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 60);
            this.MinimumSize = new System.Drawing.Size(480, 60);
            this.Name = "UProductView";
            this.Size = new System.Drawing.Size(681, 60);
            this.Enter += new System.EventHandler(this.UProductView_Enter);
            this.Leave += new System.EventHandler(this.UProductView_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInc;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Button btnDec;
    }
}
