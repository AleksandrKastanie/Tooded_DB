using Aspose.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using TextBox = System.Windows.Forms.TextBox;



namespace Tooded_DB
{
    public partial class Form1 : Form
    {
        string img, priv_name,new_name;
        int x;
        OpenFileDialog openfiledialog;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roof1\source\repos\Tooded_DB\Appdata\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd, cmd1;
        SqlDataAdapter adapter_toode, adapter_kat, adapter_kat1;
        public Form1()
        {
            openfiledialog = new OpenFileDialog
            {
                RestoreDirectory = true,
                Title = "Browse Text Files",
                Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" + "s (*.*)|*.*",

            };
            InitializeComponent();
            Naita_andmed();
        }
        private void Lisa_Kat_Click(object sender, EventArgs e)
        {
            connect.Open();
            Kustuta_andmed();
            cmd = new SqlCommand("INSERT INTO KategooriaTable (Kategooria_nimetus)VALUES(@kat)", connect);
            cmd.Parameters.AddWithValue("@kat", Kategooria_cb.Text);
            cmd.ExecuteNonQuery();
            connect.Close();
            Naita_Kat();


        }
        public void Kogus_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = false;
            }
        }

        public void Kustuta_andmed()
        {
            Toode_txt.Text = "";
            Hind_txt.Text = "";
            Kogus_txt.Text = "";
            Kategooria_cb.Items.Clear();
        }

        public void Naita_Kat()
        {
            connect.Open();
            adapter_kat = new SqlDataAdapter("SELECT Kategooria_nimetus FROM KategooriaTable", connect);
            DataTable dt_kat = new DataTable();
            adapter_kat.Fill(dt_kat);
            foreach (DataRow nimetus in dt_kat.Rows)
            {
                Kategooria_cb.Items.Add(nimetus["Kategooria_nimetus"]);
            }
            connect.Close();
        }

        public int GetID(string kategor)
        {
            Console.WriteLine(kategor);
            connect.Open();
            List<int> ss = new List<int>();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM KategooriaTable WHERE Kategooria_nimetus =@kat1", connect);
            cmd.Parameters.AddWithValue("@kat1", kategor);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                    ss.Add(reader.GetInt32(0));
            }
            x = ss[0];
            connect.Close();
            return x;
        }




        private void Lisa_btn_Click(object sender, EventArgs e)
        {
            x = GetID(Kategooria_cb.SelectedItem.ToString());
            var vastus = MessageBox.Show("Unustasite tootele pildi lisada, lisage ?", "Kusimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {

            }
            else
            {
                Save();
            }
            if (Toode_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty && Kategooria_cb.SelectedItem != null)
            {
                cmd = new SqlCommand("INSERT INTO Toodedtable (Toodenimetus,Kogus,Hind,Pilt,Kategooria_ID) VALUES (@toode,@kogus,@hind,@pilt,@kat)", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@toode", Toode_txt.Text);
                cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                cmd.Parameters.AddWithValue("@hind", Hind_txt.Text);
                cmd.Parameters.AddWithValue("@pilt", Toode_txt.Text + img);
                cmd.Parameters.AddWithValue("@kat", x);
                cmd.ExecuteNonQuery();
                connect.Close();
                Kustuta_andmed();
                Naita_andmed();
            }
            else
            {
                MessageBox.Show("Sisesta andmeid!");
            }
        }


        private void Kustutanbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kas soovite üksuse eemaldada?", "Toode", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dataGridView.SelectedRows.Count == 0)
                    return;

                string sql = "DELETE from Toodedtable WHERE  Id =@rowID";
                using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
                {
                    connect.Open();

                    int selectedIndex = dataGridView.SelectedRows[0].Index;
                    int rowID = Convert.ToInt32(dataGridView[0, selectedIndex].Value);
                    deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowID;
                    deleteRecord.ExecuteNonQuery();
                    dataGridView.Rows.RemoveAt(selectedIndex);

                    connect.Close();
                }
            }
            else if (result == DialogResult.No)
            {
                if (Kategooria_cb.Text == "")
                    return;

                string sql = "DELETE from KategooriaTable WHERE  Kategooria_nimetus =@kat";
                using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
                {
                    connect.Open();
                    deleteRecord.Parameters.AddWithValue("@kat", Kategooria_cb.Text);
                    deleteRecord.ExecuteNonQuery();
                    connect.Close();
                    Kustuta_andmed();
                    Naita_andmed();
                }
            }
        }

        private void Save()
        {
            OpenFileDialog open = new OpenFileDialog();
            Toode_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            open.InitialDirectory = @"C:\Users\";
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            FileInfo open_info = new FileInfo(@"C:\Users\" + open.FileName);
            if (open.ShowDialog() == DialogResult.OK && Toode_txt != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\Images");
                save.FileName = Toode_txt.Text + Path.GetExtension(open.FileName); //".jpg";            
                save.Filter = "Image Files" + Path.GetExtension(open.FileName) + "|" + Path.GetExtension(open.FileName);


                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(open.FileName, save.FileName);
                    img = Path.GetExtension(open.FileName);
                    save.RestoreDirectory = true;
                    Toode_pb.Image = System.Drawing.Image.FromFile(save.FileName);
                }
            }
        }

        private void Kogus_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }



        private void Hind_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // saate panna ainult 1 punkti
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Klient_Click(object sender, EventArgs e)
        {
            Kliendid kl = new Kliendid();
            kl.Show();
        }

        private void Otsi_btn_Click(object sender, EventArgs e)
        {
            Save();
        }
        int id;

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value;//kui andmed puuduvad reas
            Toode_txt.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            Kogus_txt.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            Hind_txt.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            Toode_pb.Image = System.Drawing.Image.FromFile(@"..\..\Images\" + dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            string v = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            Kategooria_cb.SelectedIndex = Int32.Parse(v) - 1;
            priv_name = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            img = Path.GetExtension(priv_name);
        }

        
        private void uuenda_btn_Click(object sender, EventArgs e)
        {
            if (Toode_txt.Text != "" && Kogus_txt.Text != "" && Hind_txt.Text != "" && Kategooria_cb.Text != null)
            {
                cmd = new SqlCommand("UPDATE ToodedTable SET ToodeNimetus=@toode,Kogus=@kogus,Hind=@hind,Pilt=@pilt WHERE Id=@id", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@toode", Toode_txt.Text);
                cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                cmd.Parameters.AddWithValue("@hind", Hind_txt.Text.Replace(",", ".")); 
                string file_pilt = Toode_txt.Text + img;
                cmd.Parameters.AddWithValue("@pilt", file_pilt);
                new_name = Toode_txt.Text + img;
                if (priv_name == new_name)
                {
                    
                }
                else
                {
                    File.Copy(@"..\..\Images\" + priv_name, @"..\..\Images\" + new_name);
                }
                cmd.ExecuteNonQuery();
                connect.Close();
                Kustuta_andmed();
                Naita_andmed();
                MessageBox.Show("Andmed uuendatud");
            }
            else
            {
                MessageBox.Show("Sisesta andmeid!");
            }
        }


        public void Naita_andmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM  Toodedtable",connect);
            adapter_toode.Fill(dt_toode);
            dataGridView.DataSource = dt_toode;
            
            Toode_pb.Image = System.Drawing.Image.FromFile("../../Images/1.jpg");
            Toode_pb.SizeMode = PictureBoxSizeMode.StretchImage;

            connect.Close();
            Naita_Kat();
        }



    }
}
