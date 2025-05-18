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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView1.ReadOnly = true;

            LoadMenu();
            getCategory();
        }

        private void btnTs_Click(object sender, EventArgs e)
        {
            //new TableSeating().ShowDialog;
            TableSeating tb = new TableSeating();
            tb.Show();
            this.Hide();
        }

        private void LoadMenu()
        {
            dataGridView1.Rows.Clear();

            //Koneksi.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT MenuItems.MenuItemID, Categories.Name AS Category, MenuItems.Name, MenuItems.Price, MenuItems.Description " +
                "FROM MenuItems " +
                "JOIN Categories ON MenuItems.CategoryID = Categories.CategoryID", Koneksi.conn);
            //Koneksi.conn.Close();

            try
            {
                Koneksi.conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string category = reader.GetString(1);
                    string name = reader.GetString(2);
                    decimal price = reader.GetDecimal(3);
                    string description = reader.IsDBNull(4) ? "" : reader.GetString(4);

                    dataGridView1.Rows.Add(id, category, name, price.ToString("N2"), description);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Koneksi.conn.Close();
            }
        }

        //private void LoadMenuByCategory(string category)
        //{
        //    dataGridView1.Rows.Clear();
        //    string query = "SELECT m.MenuItemID, c.Name AS Category, m.Name, m.Price, m.Description " +
        //          "FROM MenuItems m " +
        //          "JOIN Categories c ON m.CategoryID = c.CategoryID";
        //    if (category != "ALL")
        //    {
        //        query += " WHERE c.Name = @Category";
        //    }

        //    try
        //    {
        //        Koneksi.conn.Open();
        //        SqlCommand cmd = new SqlCommand(query, Koneksi.conn);
        //        if (category != "ALL")
        //        {
        //            cmd.Parameters.AddWithValue("@Category", category);
        //        }

        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            int id = reader.GetInt32(0);
        //            string cat = reader.GetString(1);
        //            string name = reader.GetString(2);
        //            decimal price = reader.GetDecimal(3);
        //            string description = reader.IsDBNull(4) ? "" : reader.GetString(4);

        //            dataGridView1.Rows.Add(id, cat, name, price, description);
        //        }
        //        reader.Close();
        //        Koneksi.conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    } finally
        //    {
        //        Koneksi.conn.Close();
        //    }
        //}

        private void LoadMenuByCategory(string category)
        {
            dataGridView1.Rows.Clear();

            if (Koneksi.conn.State != ConnectionState.Closed)
                Koneksi.conn.Close();

            string query = "SELECT m.MenuItemID, c.Name AS Category, m.Name, m.Price, m.Description " +
                           "FROM MenuItems m " +
                           "JOIN Categories c ON m.CategoryID = c.CategoryID";

            if (category != "ALL")
            {
                query += " WHERE c.Name = @Category";
            }

            SqlCommand cmd = new SqlCommand(query, Koneksi.conn);
            if (category != "ALL")
            {
                cmd.Parameters.AddWithValue("@Category", category);
            }

            SqlDataReader reader = null;

            Koneksi.conn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string cat = reader.GetString(1);
                string name = reader.GetString(2);
                decimal price = reader.GetDecimal(3);
                string description = reader.IsDBNull(4) ? "" : reader.GetString(4);

                dataGridView1.Rows.Add(id, cat, name, price, description);
            }

            reader.Close();
            Koneksi.conn.Close();
        }

        private void getCategory()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add("ALL");
            Koneksi.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM Categories", Koneksi.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbCategory.Items.Add(reader["Name"].ToString());
            }
            cbCategory.SelectedIndex = 0;
            Koneksi.conn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedCategory = cbCategory.SelectedIndex.ToString();
            //LoadMenuByCategory(selectedCategory);
            string selectedCategory = cbCategory.SelectedItem.ToString();
            LoadMenuByCategory(selectedCategory);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormMenu m = new FormMenu();
            m.Show();
            this.Hide();
        }

        private void LoadMenuSearch(string category, string name)
        {
            dataGridView1.Rows.Clear();

            string query = "SELECT MenuItems.MenuItemID, Categories.Name AS Category, MenuItems.Name, MenuItems.Price, MenuItems.Description " +
                "FROM MenuItems " +
                "JOIN Categories ON MenuItems.CategoryID = Categories.CategoryID " +
                "WHERE 1 = 1";

            if (category != "ALL")
            {
                query += " AND Categories.Name = @Category";
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                query += " AND MenuItems.Name LIKE @Name";
            }

            try
            {
                Koneksi.conn.Open();
                SqlCommand cmd = new SqlCommand(query, Koneksi.conn);

                if (category != "ALL")
                {
                    cmd.Parameters.AddWithValue("@Category", category);
                }

                if (!string.IsNullOrWhiteSpace(name))
                {
                    cmd.Parameters.AddWithValue("@Name", "%" + name + "%");
                }

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string cat = reader.GetString(1);
                    string nama = reader.GetString(2);
                    decimal price = reader.GetDecimal(3);
                    string description = reader.IsDBNull(4) ? "" : reader.GetString(4);

                    dataGridView1.Rows.Add(id, cat, nama, price, description);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Koneksi.conn.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string category = cbCategory.SelectedItem.ToString();
            string name = tbName.Text.Trim();

            LoadMenuSearch(category, name);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FormHistory s = new FormHistory();
            s.Show();
            this.Hide();
        }
    }
}
