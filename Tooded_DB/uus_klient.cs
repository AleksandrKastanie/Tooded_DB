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
    public partial class uus_klient : Form
    {
        OpenFileDialog openfiledialog;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roof1\source\repos\Tooded_DB\Appdata\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd, cmd1;
        string toode, max, max1;
        int kogus;
        int arvenumber;

        private void Sulge_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public uus_klient()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Registreerimine_Click(object sender, EventArgs e)
        {
            if (Nimi_tb.Text  != null )
            {
                if ( Pere_Nimi_tb.Text != null)
                {
                    if (textBox1.Text != null)
                    {
                        string tags = textBox1.Text;
                        int count = tags.Length;
                        if (count == 11 )
                        {
                            cmd = new SqlCommand("INSERT INTO kliendid (Nimi,PereNimi,Isikukood) VALUES (@Nimi,@PereNimi,@Isikukood)", connect);
                            connect.Open();
                            cmd.Parameters.AddWithValue("@Nimi", Nimi_tb.Text);
                            cmd.Parameters.AddWithValue("@PereNimi", Pere_Nimi_tb.Text);
                            cmd.Parameters.AddWithValue("@Isikukood", textBox1.Text);
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Kliendi lisamine õnnestus! =)");
                            this.Close();   
                        }
                        else
                        {
                            MessageBox.Show("Isikukoda peab sisaldama 11 tähemärki!");
                        }
                    }
                }
            }
        }
    }
}
