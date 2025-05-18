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
    public partial class FormAssignTable : Form
    {
        private int tableId;
        public FormAssignTable(int tableId, string tableName)
        {
            InitializeComponent();
            this.tableId = tableId;
            this.Text = $"Assign Table - {tableName}";
            LoadWaitresses();
            KapasitasMeja();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadWaitresses()
        {
            Koneksi.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM Employees WHERE Role = 'Waitress'", Koneksi.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(0));
            }
            Koneksi.conn.Close();
        }

        private void FormAssignTable_Load(object sender, EventArgs e)
        {

        }

        private void KapasitasMeja()
        {
            Koneksi.conn.Open();
            SqlCommand checkCap = new SqlCommand("SELECT Capacity FROM RestaurantTables WHERE TableID = @id", Koneksi.conn);
            checkCap.Parameters.AddWithValue("@id", tableId);
            int capacity = (int)checkCap.ExecuteScalar();
            Koneksi.conn.Close();

            numericUpDown1.ReadOnly = true;
            numericUpDown1.Enabled = false;
            numericUpDown1.Value = capacity;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string customerName = textBox1.Text.Trim();
            int pax = (int)numericUpDown1.Value;
            string waitressName = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(waitressName))
            {
                MessageBox.Show("Lengkapi Datanya");
                return;
            }

            //Koneksi.conn.Open();
            //SqlCommand checkCap = new SqlCommand("SELECT Capacity FROM RestaurantTables WHERE TableID = @id", Koneksi.conn);
            //checkCap.Parameters.AddWithValue("@id", tableId);
            //int capacity = (int)checkCap.ExecuteScalar();
            //Koneksi.conn.Close();

            //if (pax > capacity)
            //{
            //    MessageBox.Show("Jumlah pax melebihi kapasitas meja!");
            //    return;
            //}

            // Ambil Employe Id
            Koneksi.conn.Open();
            SqlCommand getEmpId = new SqlCommand("SELECT EmployeeID FROM Employees WHERE Name = @name", Koneksi.conn);
            getEmpId.Parameters.AddWithValue("@name", waitressName);
            int empId = (int)getEmpId.ExecuteScalar();
            Koneksi.conn.Close();

            // Simpan Transaksi
            Koneksi.conn.Open();
            SqlCommand insertTRX = new SqlCommand("INSERT INTO Transactions (TableId, CustomerName) OUTPUT INSERTED.TransactionID VALUES (@table, @cust)", Koneksi.conn);
            insertTRX.Parameters.AddWithValue("@table", tableId);
            insertTRX.Parameters.AddWithValue("@cust", customerName);
            int trxId = (int)insertTRX.ExecuteScalar(); // Ambil TransactionID 
            Koneksi.conn.Close();

            Koneksi.conn.Open();
            SqlCommand insertOrder = new SqlCommand("INSERT INTO Orders (TransactionID, EmployeeID) VALUES (@trx, @emp)", Koneksi.conn);
            insertOrder.Parameters.AddWithValue("@trx", trxId);
            insertOrder.Parameters.AddWithValue("@emp", empId);
            insertOrder.ExecuteNonQuery();
            Koneksi.conn.Close();

            MessageBox.Show("Berhasil Mendaftarkan Customer");
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
