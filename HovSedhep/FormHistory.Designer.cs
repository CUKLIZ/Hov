namespace HovSedhep
{
    partial class FormHistory
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
            btnHistory = new Button();
            btnMenu = new Button();
            btnTs = new Button();
            groupBox1 = new GroupBox();
            cbTableName = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            TsTransactionId = new DataGridViewTextBoxColumn();
            tbName = new DataGridViewTextBoxColumn();
            csName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();
            OdTransactionId = new DataGridViewTextBoxColumn();
            odOrderId = new DataGridViewTextBoxColumn();
            odOrderTime = new DataGridViewTextBoxColumn();
            waitherss = new DataGridViewTextBoxColumn();
            odOrdered = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            dataGridView3 = new DataGridView();
            oddOrderId = new DataGridViewTextBoxColumn();
            OddOrderDetailId = new DataGridViewTextBoxColumn();
            oddMenuName = new DataGridViewTextBoxColumn();
            oddQuantity = new DataGridViewTextBoxColumn();
            oddPrice = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.CornflowerBlue;
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 15.75F);
            btnHistory.Location = new Point(12, 314);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(165, 99);
            btnHistory.TabIndex = 18;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Gray;
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 15.75F);
            btnMenu.Location = new Point(12, 162);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(165, 99);
            btnMenu.TabIndex = 17;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnTs
            // 
            btnTs.BackColor = Color.Gray;
            btnTs.Cursor = Cursors.Hand;
            btnTs.FlatStyle = FlatStyle.Flat;
            btnTs.Font = new Font("Segoe UI", 15.75F);
            btnTs.Location = new Point(12, 21);
            btnTs.Name = "btnTs";
            btnTs.Size = new Size(165, 99);
            btnTs.TabIndex = 16;
            btnTs.Text = "Table Seating";
            btnTs.UseVisualStyleBackColor = false;
            btnTs.Click += btnTs_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbTableName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(207, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(535, 99);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // cbTableName
            // 
            cbTableName.FormattingEnabled = true;
            cbTableName.Location = new Point(124, 59);
            cbTableName.Name = "cbTableName";
            cbTableName.Size = new Size(139, 23);
            cbTableName.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 62);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 21;
            label2.Text = "Table Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(124, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 20;
            label1.Text = "Date";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(207, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(535, 145);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transaction";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TsTransactionId, tbName, csName, Date, TotalPrice });
            dataGridView1.Location = new Point(6, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(523, 117);
            dataGridView1.TabIndex = 23;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // TsTransactionId
            // 
            TsTransactionId.HeaderText = "Transaction Id";
            TsTransactionId.Name = "TsTransactionId";
            TsTransactionId.Width = 97;
            // 
            // tbName
            // 
            tbName.HeaderText = "Table Name";
            tbName.Name = "tbName";
            tbName.Width = 87;
            // 
            // csName
            // 
            csName.HeaderText = "Customer Name";
            csName.Name = "csName";
            csName.Width = 109;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.Width = 56;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Total Price";
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 79;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Location = new Point(207, 277);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(535, 131);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { OdTransactionId, odOrderId, odOrderTime, waitherss, odOrdered });
            dataGridView2.Location = new Point(6, 15);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(523, 110);
            dataGridView2.TabIndex = 24;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // OdTransactionId
            // 
            OdTransactionId.HeaderText = "Transaction Id";
            OdTransactionId.Name = "OdTransactionId";
            OdTransactionId.Width = 97;
            // 
            // odOrderId
            // 
            odOrderId.HeaderText = "Order Id";
            odOrderId.Name = "odOrderId";
            odOrderId.Width = 70;
            // 
            // odOrderTime
            // 
            odOrderTime.HeaderText = "Order Time";
            odOrderTime.Name = "odOrderTime";
            odOrderTime.Width = 84;
            // 
            // waitherss
            // 
            waitherss.HeaderText = "Input By Waitress";
            waitherss.Name = "waitherss";
            waitherss.Width = 113;
            // 
            // odOrdered
            // 
            odOrdered.HeaderText = "Number Of Item Ordered";
            odOrdered.Name = "odOrdered";
            odOrdered.Width = 112;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView3);
            groupBox4.Location = new Point(207, 414);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(535, 146);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Order Detail";
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { oddOrderId, OddOrderDetailId, oddMenuName, oddQuantity, oddPrice });
            dataGridView3.Location = new Point(6, 22);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(523, 117);
            dataGridView3.TabIndex = 24;
            // 
            // oddOrderId
            // 
            oddOrderId.HeaderText = "Order Id";
            oddOrderId.Name = "oddOrderId";
            oddOrderId.Width = 75;
            // 
            // OddOrderDetailId
            // 
            OddOrderDetailId.HeaderText = "Order Detail Id";
            OddOrderDetailId.Name = "OddOrderDetailId";
            OddOrderDetailId.Width = 108;
            // 
            // oddMenuName
            // 
            oddMenuName.HeaderText = "Menu Name";
            oddMenuName.Name = "oddMenuName";
            oddMenuName.Width = 98;
            // 
            // oddQuantity
            // 
            oddQuantity.HeaderText = "Quantity";
            oddQuantity.Name = "oddQuantity";
            oddQuantity.Width = 78;
            // 
            // oddPrice
            // 
            oddPrice.HeaderText = "Price";
            oddPrice.Name = "oddPrice";
            oddPrice.Width = 58;
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 572);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnHistory);
            Controls.Add(btnMenu);
            Controls.Add(btnTs);
            Name = "FormHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHistory";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHistory;
        private Button btnMenu;
        private Button btnTs;
        private GroupBox groupBox1;
        private ComboBox cbTableName;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TsTransactionId;
        private DataGridViewTextBoxColumn tbName;
        private DataGridViewTextBoxColumn csName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn OdTransactionId;
        private DataGridViewTextBoxColumn odOrderId;
        private DataGridViewTextBoxColumn odOrderTime;
        private DataGridViewTextBoxColumn waitherss;
        private DataGridViewTextBoxColumn odOrdered;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn oddOrderId;
        private DataGridViewTextBoxColumn OddOrderDetailId;
        private DataGridViewTextBoxColumn oddMenuName;
        private DataGridViewTextBoxColumn oddQuantity;
        private DataGridViewTextBoxColumn oddPrice;
    }
}