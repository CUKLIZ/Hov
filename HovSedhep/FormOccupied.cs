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
    public partial class FormOccupied : Form
    {
        private int tableId;
        private int transactionId;
        public FormOccupied(int tableId, string tableName)
        {
            InitializeComponent();
            this.tableId = tableId;
            this.Text = $"Table Occupied - {tableName}";
            LoadTransaksi();
        }

        private void LoadTransaksi()
        {
            Koneksi.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 t.TransactionID, t.CustomerName, rt.Capacity AS Pax, e.Name AS WaitressName " +
                "FROM Transactions t " +
                "JOIN RestaurantTables rt ON t.TableID = rt.TableID " +
                "JOIN Orders o ON o.TransactionID = t.TransactionID " +
                "JOIN Employees e ON o.EmployeeID = e.EmployeeID " +
                "WHERE t.TableID = @tableid AND t.Status = 'Ongoing' " +
                "ORDER BY o.OrderTime ASC", Koneksi.conn);
            cmd.Parameters.AddWithValue("@tableid", tableId);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                transactionId = (int)reader["TransactionID"];
                lblCus.Text = reader["CustomerName"].ToString();
                lblWait.Text = reader["WaitressName"].ToString();
                lblPax.Text = reader["Pax"].ToString() + " pax";
            }
            reader.Close();
            Koneksi.conn.Close();
        }

        private void UpdateStatus(string newStatus)
        {
            Koneksi.conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Transactions SET Status = @status WHERE TransactionID = @id", Koneksi.conn);
            cmd.Parameters.AddWithValue("@status", newStatus);
            cmd.Parameters.AddWithValue("@id", transactionId);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();

            MessageBox.Show($"Table marked as {newStatus}.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateStatus("Cancelled");
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            UpdateStatus("Completed");
        }
    }
}
