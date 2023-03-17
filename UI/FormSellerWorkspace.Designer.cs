namespace UI
{
    partial class FormSellerWorkspace
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSellerWorkspace));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCloseSession = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lNumberSession = new System.Windows.Forms.Label();
            this.lbNameCashier = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPayBank = new System.Windows.Forms.Button();
            this.btnPayCash = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.flpOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pageSetupDialog2 = new System.Windows.Forms.PageSetupDialog();
            this.panelHeader.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.groupBox3);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1703, 94);
            this.panelHeader.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnCloseSession);
            this.groupBox3.Controls.Add(this.lbTime);
            this.groupBox3.Controls.Add(this.lbDate);
            this.groupBox3.Controls.Add(this.lNumberSession);
            this.groupBox3.Controls.Add(this.lbNameCashier);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(5, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1693, 87);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(649, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Время:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(432, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата:";
            // 
            // btnCloseSession
            // 
            this.btnCloseSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSession.Location = new System.Drawing.Point(1544, 20);
            this.btnCloseSession.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseSession.Name = "btnCloseSession";
            this.btnCloseSession.Size = new System.Drawing.Size(141, 59);
            this.btnCloseSession.TabIndex = 8;
            this.btnCloseSession.Text = "Закрыть смену";
            this.btnCloseSession.UseVisualStyleBackColor = true;
            this.btnCloseSession.Click += new System.EventHandler(this.btnCloseSession_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.ForeColor = System.Drawing.Color.Purple;
            this.lbTime.Location = new System.Drawing.Point(752, 18);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(71, 29);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "12:00";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.ForeColor = System.Drawing.Color.Purple;
            this.lbDate.Location = new System.Drawing.Point(513, 18);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(103, 29);
            this.lbDate.TabIndex = 6;
            this.lbDate.Text = "28.11.23";
            // 
            // lNumberSession
            // 
            this.lNumberSession.AutoSize = true;
            this.lNumberSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNumberSession.Location = new System.Drawing.Point(120, 49);
            this.lNumberSession.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNumberSession.Name = "lNumberSession";
            this.lNumberSession.Size = new System.Drawing.Size(91, 29);
            this.lNumberSession.TabIndex = 5;
            this.lNumberSession.Text = "000001";
            // 
            // lbNameCashier
            // 
            this.lbNameCashier.AutoSize = true;
            this.lbNameCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameCashier.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbNameCashier.Location = new System.Drawing.Point(120, 20);
            this.lbNameCashier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameCashier.Name = "lbNameCashier";
            this.lbNameCashier.Size = new System.Drawing.Size(285, 29);
            this.lbNameCashier.TabIndex = 4;
            this.lbNameCashier.Text = "Иванов Иван Иванович";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Смена:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кассир:";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBox2);
            this.panelLeft.Controls.Add(this.groupBox1);
            this.panelLeft.Controls.Add(this.flpOrder);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 94);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(737, 736);
            this.panelLeft.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lTotalPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(725, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lTotalPrice
            // 
            this.lTotalPrice.AutoSize = true;
            this.lTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTotalPrice.Location = new System.Drawing.Point(512, 18);
            this.lTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTotalPrice.Name = "lTotalPrice";
            this.lTotalPrice.Size = new System.Drawing.Size(71, 29);
            this.lTotalPrice.TabIndex = 3;
            this.lTotalPrice.Text = "0 руб";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "К оплате:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnPayBank);
            this.groupBox1.Controls.Add(this.btnPayCash);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Location = new System.Drawing.Point(5, 581);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(725, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(189, 15);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 123);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPayBank
            // 
            this.btnPayBank.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPayBank.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPayBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayBank.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPayBank.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPayBank.Location = new System.Drawing.Point(539, 15);
            this.btnPayBank.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayBank.Name = "btnPayBank";
            this.btnPayBank.Size = new System.Drawing.Size(171, 123);
            this.btnPayBank.TabIndex = 4;
            this.btnPayBank.Text = "Оплата картой";
            this.btnPayBank.UseVisualStyleBackColor = false;
            this.btnPayBank.Click += new System.EventHandler(this.btnPayBank_Click);
            // 
            // btnPayCash
            // 
            this.btnPayCash.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPayCash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPayCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayCash.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPayCash.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPayCash.Location = new System.Drawing.Point(364, 15);
            this.btnPayCash.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(171, 123);
            this.btnPayCash.TabIndex = 3;
            this.btnPayCash.Text = "Оплата \r\nналичными\r\n";
            this.btnPayCash.UseVisualStyleBackColor = false;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayCash_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemove.Location = new System.Drawing.Point(13, 15);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(171, 123);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // flpOrder
            // 
            this.flpOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpOrder.AutoScroll = true;
            this.flpOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpOrder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flpOrder.Location = new System.Drawing.Point(5, 78);
            this.flpOrder.Margin = new System.Windows.Forms.Padding(4);
            this.flpOrder.Name = "flpOrder";
            this.flpOrder.Size = new System.Drawing.Size(725, 500);
            this.flpOrder.TabIndex = 0;
            this.flpOrder.WrapContents = false;
            // 
            // flpCategories
            // 
            this.flpCategories.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpCategories.Location = new System.Drawing.Point(1311, 94);
            this.flpCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpCategories.Name = "flpCategories";
            this.flpCategories.Size = new System.Drawing.Size(392, 736);
            this.flpCategories.TabIndex = 1;
            // 
            // flpProducts
            // 
            this.flpProducts.BackColor = System.Drawing.SystemColors.Control;
            this.flpProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProducts.Location = new System.Drawing.Point(737, 94);
            this.flpProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(574, 736);
            this.flpProducts.TabIndex = 4;
            // 
            // FormSellerWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 830);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.flpCategories);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSellerWorkspace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рабочее место кассира";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSellerWorkspace_FormClosing);
            this.panelHeader.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.FlowLayoutPanel flpOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPayBank;
        private System.Windows.Forms.Button btnPayCash;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpCategories;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCloseSession;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lNumberSession;
        private System.Windows.Forms.Label lbNameCashier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

