namespace HovSedhep
{
    partial class FormOccupied
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
            btnFinish = new Button();
            btnCancel = new Button();
            label3 = new Label();
            lblCus = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblWait = new TextBox();
            lblPax = new TextBox();
            SuspendLayout();
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.GreenYellow;
            btnFinish.FlatStyle = FlatStyle.Flat;
            btnFinish.Location = new Point(267, 172);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(75, 35);
            btnFinish.TabIndex = 15;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += btnFinish_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkKhaki;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(22, 172);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 35);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 123);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 13;
            label3.Text = "Pax Size";
            // 
            // lblCus
            // 
            lblCus.Location = new Point(148, 81);
            lblCus.Name = "lblCus";
            lblCus.ReadOnly = true;
            lblCus.Size = new Size(194, 23);
            lblCus.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 84);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 10;
            label2.Text = "Customer Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 43);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 8;
            label1.Text = "Waitress";
            // 
            // lblWait
            // 
            lblWait.Location = new Point(148, 43);
            lblWait.Name = "lblWait";
            lblWait.ReadOnly = true;
            lblWait.Size = new Size(194, 23);
            lblWait.TabIndex = 16;
            // 
            // lblPax
            // 
            lblPax.Location = new Point(148, 123);
            lblPax.Name = "lblPax";
            lblPax.ReadOnly = true;
            lblPax.Size = new Size(194, 23);
            lblPax.TabIndex = 17;
            // 
            // FormOccupied
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 247);
            Controls.Add(lblPax);
            Controls.Add(lblWait);
            Controls.Add(btnFinish);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(lblCus);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormOccupied";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOccupied";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFinish;
        private Button btnCancel;
        private Label label3;
        private TextBox lblCus;
        private Label label2;
        private Label label1;
        private TextBox lblWait;
        private TextBox lblPax;
    }
}