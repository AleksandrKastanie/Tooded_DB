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

namespace Tooded_DB
{
    public partial class Register : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roof1\source\repos\Tooded_DB\Appdata\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter_login;
        public Register()
        {
            InitializeComponent();
        }

        private void Registreerimine_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("INSERT INTO log (Username,Parool,Usertype) VALUES (@username,@parool,@usertype)", connect);
            if (Parool_tb2.Text == Parool_tb.Text)
            {
                try
                {
                    connect.Open();
                    cmd.Parameters.AddWithValue("@username", Kasutaja_tb.Text.ToString());
                    cmd.Parameters.AddWithValue("@parool", Parool_tb.Text.ToString());
                    cmd.Parameters.AddWithValue("@usertype", Tuup_cb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Login login = new Login();
                    login.Show();
                    this.Hide();

                }
                catch (Exception)
                {
                    MessageBox.Show("Kasutajanimi on juba kasutusel!");
                    throw;
                }   
            }
            else
            {
                MessageBox.Show("Paroolid ei kattu!");
                connect.Close();    
            }
        }
    }
}
