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
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roof1\source\repos\Tooded_DB\Appdata\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter_login;
        string selecteditemcombobox;
        public Login()
        {
            InitializeComponent();
        }

        private void Log_in_Click(object sender, EventArgs e)
        {
            connect.Open();
            cmd = new SqlCommand("Select * from log where Username='" + Kasutaja_tb.Text + "' and Parool='" + Parool_tb.Text + "'", connect);
            adapter_login = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter_login.Fill(dt);
            selecteditemcombobox = Tuup_cb.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Usertype"].ToString()==selecteditemcombobox)
                    {
                        MessageBox.Show("Logisite sisse kui: " + dt.Rows[i][2]);
                        if (Tuup_cb.SelectedIndex == 0)
                        {
                            Form1 f = new Form1();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            Mua mua = new Mua();
                            mua.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
            connect.Close();
        }

        private void Registreerimine_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
