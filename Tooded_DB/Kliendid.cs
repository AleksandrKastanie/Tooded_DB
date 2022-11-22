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
    public partial class Kliendid : Form
    {
        OpenFileDialog openfiledialog;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roof1\source\repos\Tooded_DB\Appdata\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd, cmd1;
        string toode, max, max1;
        int kogus, id;
        int arvenumber;

        private void Lisa_Klient_Click(object sender, EventArgs e)
        {
            uus_klient uos= new uus_klient();
            uos.Show();
        }

        private void Kustuta_Klient_Click(object sender, EventArgs e)
        {
            if (Kliendid_dgv.SelectedRows.Count == 0)
                return;

            string sql = "DELETE from kliendid WHERE  Id =@rowID";
            using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
            {
                connect.Open();

                int selectedIndex = Kliendid_dgv.SelectedRows[0].Index;
                int rowID = Convert.ToInt32(Kliendid_dgv[0, selectedIndex].Value);
                deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowID;
                deleteRecord.ExecuteNonQuery();
                Kliendid_dgv.Rows.RemoveAt(selectedIndex);

                connect.Close();
                Naita_klient();
            }
        }

        private void Uenda_Klient_Click(object sender, EventArgs e)
        {
            if (Nimi_tb.Text.Trim() !=null)
            {
                if (Pere_Nimi_tb.Text.Trim() != null)
                {
                    cmd = new SqlCommand("UPDATE kliendid SET Nimi=@Nimi,PereNimi=@PereNimi WHERE Id=@id", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@Nimi", Nimi_tb.Text);
                    cmd.Parameters.AddWithValue("@PereNimi", Pere_Nimi_tb.Text);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Naita_klient();
                    MessageBox.Show("Andmed uuendatud");
                }
                else
                {
                    MessageBox.Show("Sisesta andmeid!");
                }
            }
        }

        private void Uend_tab_Click(object sender, EventArgs e)
        {
            Naita_klient();
        }

        private void Kliendid_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)Kliendid_dgv.Rows[e.RowIndex].Cells[0].Value;//kui andmed puuduvad reas
        }

        SqlDataAdapter adapter_klient, adapter_kat, adapter_kat1;
        public Kliendid()
        {
            InitializeComponent();
            Naita_klient();
        }
        public void Naita_klient()
        {
            connect.Open();
            DataTable dt_klient = new DataTable();
            adapter_klient = new SqlDataAdapter("SELECT * FROM kliendid", connect);
            adapter_klient.Fill(dt_klient);
            Kliendid_dgv.DataSource = dt_klient;
            Kliendid_dgv.Columns["Id"].Visible = false;
            connect.Close();
        }   
    }
}
