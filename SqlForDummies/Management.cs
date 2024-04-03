using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SqlForDummies
{
    public partial class Management : Form
    {
        //kendi veritabnına göre değiştir
        string connectionString = "Data Source=192.168.1.102,1433;Initial Catalog=DBORMAN;User ID=sa;Password=Tureet45;";

        public Management()
        {
            InitializeComponent();
        }

      

        private void Management_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

    

        private void LoadDataFromDatabase()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Veri";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

      

        private void INSERT_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Veri (ID, lokasyon, puan, HWID) VALUES (@ID, @lokasyon, @puan, @HWID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", IDINSERT.Text);
                    command.Parameters.AddWithValue("@lokasyon", LOKINSERT.Text);
                    command.Parameters.AddWithValue("@puan", PINSERT.Text);
                    command.Parameters.AddWithValue("@HWID", "NULL");

                    command.ExecuteNonQuery();
                    LoadDataFromDatabase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Veri SET lokasyon = @lokasyon, puan = @puan WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", KID.Text);
                    command.Parameters.AddWithValue("@lokasyon", LOKUP.Text);
                    command.Parameters.AddWithValue("@puan", PUPDATE.Text);

                    command.ExecuteNonQuery();
                    LoadDataFromDatabase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Veri WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", DID.Text);

                    command.ExecuteNonQuery();
                    LoadDataFromDatabase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
