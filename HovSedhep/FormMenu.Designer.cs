namespace HovSedhep
{
    partial class FormMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnHistory = new Button();
            btnMenu = new Button();
            btnTs = new Button();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            tbName = new TextBox();
            cbCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            MenuItemID = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            MenuName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.Gray;
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 15.75F);
            btnHistory.Location = new Point(27, 311);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(165, 99);
            btnHistory.TabIndex = 15;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.CornflowerBlue;
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 15.75F);
            btnMenu.Location = new Point(27, 159);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(165, 99);
            btnMenu.TabIndex = 14;
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
            btnTs.Location = new Point(27, 18);
            btnTs.Name = "btnTs";
            btnTs.Size = new Size(165, 99);
            btnTs.TabIndex = 13;
            btnTs.Text = "Table Seating";
            btnTs.UseVisualStyleBackColor = false;
            btnTs.Click += btnTs_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(235, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 124);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(298, 69);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(122, 69);
            tbName.Name = "tbName";
            tbName.Size = new Size(158, 23);
            tbName.TabIndex = 17;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(122, 31);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(158, 23);
            cbCategory.TabIndex = 17;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(19, 67);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 18;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 17;
            label1.Text = "Category";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(235, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 252);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MenuItemID, Category, MenuName, Price, Description });
            dataGridView1.Location = new Point(19, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(462, 198);
            dataGridView1.TabIndex = 18;
            // 
            // MenuItemID
            // 
            MenuItemID.HeaderText = "Menu Id";
            MenuItemID.Name = "MenuItemID";
            MenuItemID.Width = 76;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.Width = 80;
            // 
            // MenuName
            // 
            MenuName.HeaderText = "Name";
            MenuName.Name = "MenuName";
            MenuName.Width = 64;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.Width = 58;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.Width = 92;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 430);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnHistory);
            Controls.Add(btnMenu);
            Controls.Add(btnTs);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHistory;
        private Button btnMenu;
        private Button btnTs;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnSearch;
        private TextBox tbName;
        private ComboBox cbCategory;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MenuItemID;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn MenuName; 
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Description;
    }
}
