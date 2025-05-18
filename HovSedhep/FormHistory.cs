using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace HovSedhep
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
            cbTableName.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadTables();
            LoadTransactionHistory();


            cbTableName.SelectedIndexChanged += (s, e) => LoadTransactionHistory();
            dateTimePicker1.ValueChanged += (s, e) => LoadTransactionHistory();

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

            dateTimePicker1.MaxDate = DateTime.Today;
            //dateTimePicker1.Value = DateTime.Today;

            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            dataGridView3.ReadOnly = true;
        }

        private void LoadTables()
        {
            try
            {
                Koneksi.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM RestaurantTables", Koneksi.conn);
                SqlDataReader reader = cmd.ExecuteReader();

                cbTableName.Items.Clear();
                cbTableName.Items.Add("ALL");
                while (reader.Read())
                {
                    cbTableName.Items.Add(reader["Name"].ToString());
                }
                reader.Close();

                cbTableName.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tables: " + ex.Message);
            }
            finally
            {
                Koneksi.conn.Close();
            }
        }

        private void LoadTransactionHistory()
        {
            dataGridView1.Rows.Clear();

            string selectedTable = cbTableName.SelectedItem?.ToString() ?? "ALL";
            string filterTable = selectedTable == "ALL" ? "" : "AND rt.Name = @TableName";

            string query = $@"
                SELECT 
                    t.TransactionID,
                    rt.Name,
                    t.CustomerName,
                    t.TransactionDate,
                    SUM(od.Price * od.Quantity) AS TotalPrice
                FROM Transactions t
                INNER JOIN RestaurantTables rt ON t.TableID = rt.TableID
                INNER JOIN Orders o ON t.TransactionID = o.TransactionID
                INNER JOIN OrderDetails od ON o.OrderID = od.OrderID
                WHERE t.Status = 'Completed'
                  AND t.TransactionDate BETWEEN @StartOfDay AND @EndOfDay
                  {filterTable}
                GROUP BY t.TransactionID, rt.Name, t.CustomerName, t.TransactionDate
                ORDER BY t.TransactionDate DESC";

            try
            {
                Koneksi.conn.Open();
                SqlCommand cmd = new SqlCommand(query, Koneksi.conn);

                DateTime selectedDate = dateTimePicker1.Value.Date;
                DateTime startOfDay = selectedDate;
                DateTime endOfDay = selectedDate.AddDays(1).AddTicks(-1);

                cmd.Parameters.AddWithValue("@StartOfDay", startOfDay);
                cmd.Parameters.AddWithValue("@EndOfDay", endOfDay);

                if (selectedTable != "ALL")
                    cmd.Parameters.AddWithValue("@TableName", selectedTable);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int transactionId = reader.GetInt32(0);
                    string tableName = reader.GetString(1);
                    string customerName = reader.GetString(2);
                    DateTime transactionDate = reader.GetDateTime(3);
                    decimal totalPrice = reader.GetDecimal(4);

                    dataGridView1.Rows.Add(
                        transactionId,
                        tableName,
                        customerName,
                        transactionDate.ToString("dd MMM yyyy HH:mm"),
                        totalPrice.ToString("N2")
                    );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transaction history: " + ex.Message);
            }
            finally
            {
                Koneksi.conn.Close();
            }

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                LoadOrderHistory();
            }
            //else
            //{
            //    dataGridView2.Rows.Clear();
            //    dataGridView3.Rows.Clear();
            //}
        }

        private void LoadOrderHistory()
        {
            dataGridView2.Rows.Clear();

            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int transactionId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            string query = @"
                SELECT 
                    o.TransactionID,
                    o.OrderID,
                    o.OrderTime,
                    e.Name,
                    SUM(od.Quantity)
                FROM Orders o
                INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
                INNER JOIN OrderDetails od ON o.OrderID = od.OrderID
                WHERE o.TransactionID = @TransactionID AND e.Role = 'Waitress'
                GROUP BY o.TransactionID, o.OrderID, o.OrderTime, e.Name
                ORDER BY o.OrderTime ASC";

            try
            {
                Koneksi.conn.Open();
                SqlCommand cmd = new SqlCommand(query, Koneksi.conn);
                cmd.Parameters.AddWithValue("@TransactionID", transactionId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int orderId = reader.GetInt32(1);
                    DateTime orderTime = reader.GetDateTime(2);
                    string waitress = reader.GetString(3);
                    int totalQty = reader.GetInt32(4);

                    dataGridView2.Rows.Add(
                        transactionId,
                        orderId,
                        orderTime.ToString("HH:mm:ss"),
                        waitress,
                        totalQty
                    );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order history: " + ex.Message);
            }
            finally
            {
                Koneksi.conn.Close();
            }

            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows[0].Selected = true;
                LoadOrderDetailHistory();
            }
            //else
            //{
            //    dataGridView3.Rows.Clear();
            //}
        }

        private void LoadOrderDetailHistory()
        {
            dataGridView3.Rows.Clear();

            if (dataGridView2.SelectedRows.Count == 0)
                return;

            int orderId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[1].Value);

            string query = @"
                SELECT 
                    od.OrderID,
                    od.OrderDetailID,
                    m.Name,
                    od.Quantity,
                    od.Price
                FROM OrderDetails od
                INNER JOIN MenuItems m ON od.MenuItemID = m.MenuItemID
                WHERE od.OrderID = @OrderID";

            try
            {
                Koneksi.conn.Open();
                SqlCommand cmd = new SqlCommand(query, Koneksi.conn);
                cmd.Parameters.AddWithValue("@OrderID", orderId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int odId = reader.GetInt32(1);
                    string menuName = reader.GetString(2);
                    int qty = reader.GetInt32(3);
                    decimal price = reader.GetDecimal(4);

                    dataGridView3.Rows.Add(
                        orderId,
                        odId,
                        menuName,
                        qty,
                        price.ToString("N2")
                    );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order detail history: " + ex.Message);
            }
            finally
            {
                Koneksi.conn.Close();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                LoadOrderHistory();
            }
            //else
            //{
            //    dataGridView2.Rows.Clear();
            //    dataGridView3.Rows.Clear();
            //}
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                LoadOrderDetailHistory();
            }
            //else
            //{
            //    dataGridView3.Rows.Clear();
            //}
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new FormMenu().Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            new FormHistory().Show();
            this.Hide();
        }

        private void btnTs_Click(object sender, EventArgs e)
        {
            new TableSeating().Show();
            this.Hide();
        }
    }
}
