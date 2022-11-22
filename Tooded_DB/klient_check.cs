using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooded_DB
{
    public partial class klient_check : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roof1\source\repos\Tooded_DB\Appdata\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter_login;
        string selecteditemcombobox;
        public klient_check()
        {
            InitializeComponent();
        }

        private void Isik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > 1))
            {
                e.Handled = false;
            }
        }

        private void Kinnita_Click(object sender, EventArgs e)
        {
            connect.Open();
            cmd = new SqlCommand("Select * from kliendid where Isikukood='" + Isik.Text + "'", connect);
            adapter_login = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter_login.Fill(dt);
            int count = Isik.Text.Length;
            if (count == 11)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        MessageBox.Show("Tere Tulemast " + dt.Rows[i][1] );
                        this.Close();
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
                connect.Close();
            }
            else
            {
                MessageBox.Show("Error");
                connect.Close();
            }
            connect.Close();
        }
    }
}
