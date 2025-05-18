using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovSedhep
{
    public partial class TableSeating : Form
    {
        public TableSeating()
        {
            InitializeComponent();
            LoadTableButtons();
            timer1.Interval = 3000; // setiap 3 detik
            timer1.Start();
        }

        //private void GeneratedTableButton()
        //{
        //    flowLayoutPanel1.Controls.Clear();

        //    Koneksi.conn.Open();

        //    SqlCommand cmd = new SqlCommand("SELECT TableID, Name FROM RestaurantTables", Koneksi.conn);
        //    SqlDataReader read = cmd.ExecuteReader();

        //    while (read.Read())
        //    {
        //        Button btn = new Button();
        //        btn.Text = read["Name"].ToString();
        //        btn.Width = 100;
        //        btn.Height = 60;
        //        btn.Tag = read["TableID"];
        //        btn.Click += new EventHandler(btnA1_Click);
        //        btn.Margin = new Padding(10); // jarak antar tombol

        //        flowLayoutPanel1.Controls.Add(btn);
        //    }

        //    read.Close();
        //    Koneksi.conn.Close();
        //}

        private void LoadTableButtons()
        {
            flowLayoutPanel1.Controls.Clear();

            Koneksi.conn.Open();

            SqlCommand cmd = new SqlCommand(@"
                    SELECT rt.TableID, rt.Name,
                           CASE 
                               WHEN EXISTS (
                                   SELECT 1 FROM Transactions t
                                   WHERE t.TableID = rt.TableID AND t.Status = 'Ongoing'
                               ) THEN 1
                               ELSE 0
                           END AS IsOccupied
                    FROM RestaurantTables rt", Koneksi.conn);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 60;
                btn.Text = reader["Name"].ToString();
                btn.Tag = reader["TableID"];
                btn.Margin = new Padding(10);
                btn.Click += btnA1_Click;

                bool isOccupied = Convert.ToBoolean(reader["IsOccupied"]);
                btn.BackColor = isOccupied ? Color.Red : Color.LightGreen;

                flowLayoutPanel1.Controls.Add(btn);
            }
            reader.Close();
            Koneksi.conn.Close();
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTableStatus();
        }

        private bool IsTableOccupied(int tableId)
        {
            bool isOccupied = false;

            Koneksi.conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) FROM Transactions WHERE TableID = @id AND Status = 'Ongoing'", Koneksi.conn);
            cmd.Parameters.AddWithValue("@id", tableId);
            int count = (int)cmd.ExecuteScalar();
            isOccupied = count > 0;
            Koneksi.conn.Close();

            return isOccupied;
        }


        private void UpdateTableStatus()
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Button btn)
                {
                    int tableId = (int)btn.Tag;

                    bool occupied = IsTableOccupied(tableId);

                    if (occupied)
                    {
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;
                    }
                    else
                    {
                        btn.BackColor = Color.LightGreen;
                        btn.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            int tableId = (int)clickedBtn.Tag;

            if (IsTableOccupied(tableId))
            {
                //new FormOccupied(tableId).ShowDialog();
                new FormOccupied(tableId, clickedBtn.Text).ShowDialog();
            }
            else
            {
                new FormAssignTable(tableId, clickedBtn.Text).ShowDialog();
            }

            UpdateTableStatus();
        }

        private void TableSeating_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormMenu m = new FormMenu();
            m.Show();
            this.Hide();
        }

        private void btnTs_Click(object sender, EventArgs e)
        {
            TableSeating tb = new TableSeating();
            tb.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FormHistory s = new FormHistory();
            s.Show();
            this.Hide();
        }
    }
}
