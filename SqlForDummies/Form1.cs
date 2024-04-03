//Script kid olmayın bu kodu ben kendi emeğimle yazdım ve sizde emeğime saygı gösterin.
//hepinizin canı cehenneme bu arada.
//Arch64 sunar.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlForDummies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string ad = DBAD.Text;
            string pas = DBPAS.Text;
            sqlcon();

        }

       private void sqlcon()
{
    try
    {
        string connectionString = "Data Source=192.168.1.102,1433;Initial Catalog=DBORMAN;User ID=sa;Password=SİZİNŞİFRENİZ;";

                SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string ad = DBAD.Text;
        string pas = DBPAS.Text;

        string query = "SELECT * FROM kl WHERE ad = '" + ad + "' AND pas = '" + pas + "'";
        SqlCommand cmd = new SqlCommand(query, con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            MessageBox.Show("giriş başarılı");
            Management mng = new Management();
            mng.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Kullanıcı adı veya şifre hatalı"); 
        }

        dr.Close();
        cmd.Dispose();
        con.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show("giriş hatalı " + ex.Message); 
    }
}


    }
}
