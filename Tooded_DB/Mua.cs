
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SautinSoft.Document;
using SautinSoft.Document.Drawing;
using Color = SautinSoft.Document.Color;
using HorizontalAlignment = SautinSoft.Document.HorizontalAlignment;


namespace Tooded_DB
{
    public partial class Mua : Form
    {
        string priv_name, new_name, img;

        OpenFileDialog openfiledialog;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roof1\source\repos\Tooded_DB\Appdata\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd, cmd1;
        double hind = 1;
        string toode, max, max1;
        int kogus;
        double kokku1,summa, d;
        int arvenumber ;
        int s = 0;

        int id;
        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value;//kui andmed puuduvad reas
            Toode_lab.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            Koogus_num.Text = "1";
            max = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            Koogus_num.Maximum = Convert.ToDecimal(max);
            Hind_lab.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            Toode_pb.Image = System.Drawing.Image.FromFile(@"..\..\Images\" + dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            string v = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            priv_name = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            img = Path.GetExtension(priv_name);
        }

        
        List<string> Tooded_list = new List<string>();


        private void Koosta_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kas olete meie juures registreerunud?", "Kus", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                klient_check kl = new klient_check();
                kl.ShowDialog();
                s++;
                DateTime now = DateTime.Now;
                // Set a path to our document.
                string docPath = @"..\..\Arved\Tsekk" + s + ".pdf";

                // Create a new document and DocumentBuilder.
                DocumentCore dc = new DocumentCore();
                DocumentBuilder db = new DocumentBuilder(dc);

                // Set page size A4.
                Section section = db.Document.Sections[0];
                section.PageSetup.PaperType = PaperType.A4;

                // Add 1st paragraph with formatted text.
                db.CharacterFormat.FontName = "Verdana";
                db.CharacterFormat.Size = 16;
                db.CharacterFormat.FontColor = Color.Black;
                db.Write("Tsekk");
                // Add a line break into the 1st paragraph.
                db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
                // Add 2nd line to the 1st paragraph, create 2nd paragraph.
                db.Writeln("Kuupaev:" + now);
                // Specify the paragraph alignment.
                (section.Blocks[0] as Paragraph).ParagraphFormat.Alignment = HorizontalAlignment.Center;

                // Add text into the 2nd paragraph.
                db.CharacterFormat.ClearFormatting();
                db.CharacterFormat.Size = 15;
                db.CharacterFormat.FontColor = Color.DarkMagenta;
                db.CharacterFormat.Bold = true;
                for (int i = 0; i < Korv.RowCount - 1; i++)
                {

                    toode = Korv.Rows[i].Cells[1].Value.ToString();
                    kogus = (int)Korv.Rows[i].Cells[3].Value;
                    hind = Convert.ToDouble(Korv.Rows[i].Cells[2].Value);
                    hind = Math.Round(hind, 2);
                    summa = hind * kogus;
                    db.Writeln($"Toode: {toode}\n Kogus: {kogus}\n Hind: {hind}€\n Summa: {summa}€\n ----------------------------");
                    kokku1 += summa;

                }
                double sodus = 0;
                if (kokku1 > 20)
                {
                    sodus = 0.05;
                }
                else if (kokku1 > 50)
                {
                    sodus = 0.15;
                }
                else if (kokku1 > 150)
                {
                    sodus = 0.3;
                }
                double a = kokku1 * sodus;
                kokku1 = kokku1 - a;
                db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
                db.CharacterFormat.Size = 20;
                db.CharacterFormat.FontColor = SautinSoft.Document.Color.Magenta;
                db.CharacterFormat.UnderlineStyle = UnderlineType.Single;
                db.CharacterFormat.Bold = false;
                db.Write($"Kokku: {kokku1}€");

                // Add a graphics figure into the paragraph.
                db.CharacterFormat.ClearFormatting();

                // Save the document to the file in PDF format.
                dc.Save(docPath, new PdfSaveOptions()
                { Compliance = PdfCompliance.PDF_A1a });

                cmd = new SqlCommand("DELETE from korv", connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                Naita_andmed();
                Naita_andmed_korv();
            }
            else if (result == DialogResult.No)
            {
                DialogResult result2 = MessageBox.Show("Kas soovite saada kliendiks?", "Kus", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.Yes)
                {
                    uus_klient newklient= new uus_klient();
                    newklient.ShowDialog();
                    klient_check klop = new klient_check();
                    klop.ShowDialog();
                    s++;
                    DateTime now = DateTime.Now;
                    // Set a path to our document.
                    string docPath = @"..\..\Arved\Tsekk" + s + ".pdf";

                    // Create a new document and DocumentBuilder.
                    DocumentCore dc = new DocumentCore();
                    DocumentBuilder db = new DocumentBuilder(dc);

                    // Set page size A4.
                    Section section = db.Document.Sections[0];
                    section.PageSetup.PaperType = PaperType.A4;

                    // Add 1st paragraph with formatted text.
                    db.CharacterFormat.FontName = "Verdana";
                    db.CharacterFormat.Size = 16;
                    db.CharacterFormat.FontColor = Color.Black;
                    db.Write("Tsekk");
                    // Add a line break into the 1st paragraph.
                    db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
                    // Add 2nd line to the 1st paragraph, create 2nd paragraph.
                    db.Writeln("Kuupaev:" + now);
                    // Specify the paragraph alignment.
                    (section.Blocks[0] as Paragraph).ParagraphFormat.Alignment = HorizontalAlignment.Center;

                    // Add text into the 2nd paragraph.
                    db.CharacterFormat.ClearFormatting();
                    db.CharacterFormat.Size = 15;
                    db.CharacterFormat.FontColor = Color.DarkMagenta;
                    db.CharacterFormat.Bold = true;
                    for (int i = 0; i < Korv.RowCount - 1; i++)
                    {

                        toode = Korv.Rows[i].Cells[1].Value.ToString();
                        kogus = (int)Korv.Rows[i].Cells[3].Value;
                        hind = Convert.ToDouble(Korv.Rows[i].Cells[2].Value);
                        hind = Math.Round(hind, 2);
                        summa = hind * kogus;
                        db.Writeln($"Toode: {toode}\n Kogus: {kogus}\n Hind: {hind}€\n Summa: {summa}€\n ----------------------------");
                        kokku1 += summa;

                    }
                    double sodus = 0;
                    if (kokku1 > 20)
                    {
                        sodus = 0.05;
                    }
                    else if (kokku1 > 50)
                    {
                        sodus = 0.15;
                    }
                    else if (kokku1 > 150)
                    {
                        sodus = 0.3;
                    }
                    double a = kokku1 * sodus;
                    kokku1 = kokku1 - a;
                    db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
                    db.CharacterFormat.Size = 20;
                    db.CharacterFormat.FontColor = SautinSoft.Document.Color.Magenta;
                    db.CharacterFormat.UnderlineStyle = UnderlineType.Single;
                    db.CharacterFormat.Bold = false;
                    db.Write($"Kokku: {kokku1}€");

                    // Add a graphics figure into the paragraph.
                    db.CharacterFormat.ClearFormatting();

                    // Save the document to the file in PDF format.
                    dc.Save(docPath, new PdfSaveOptions()
                    { Compliance = PdfCompliance.PDF_A1a });

                    cmd = new SqlCommand("DELETE from korv", connect);
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Naita_andmed();
                    Naita_andmed_korv();
                }
                else if (result2 == DialogResult.No)
                {
                    s++;
                    DateTime now = DateTime.Now;
                    // Set a path to our document.
                    string docPath = @"..\..\Arved\Tsekk" + s + ".pdf";

                    // Create a new document and DocumentBuilder.
                    DocumentCore dc = new DocumentCore();
                    DocumentBuilder db = new DocumentBuilder(dc);

                    // Set page size A4.
                    Section section = db.Document.Sections[0];
                    section.PageSetup.PaperType = PaperType.A4;

                    // Add 1st paragraph with formatted text.
                    db.CharacterFormat.FontName = "Verdana";
                    db.CharacterFormat.Size = 16;
                    db.CharacterFormat.FontColor = Color.Black;
                    db.Write("Tsekk");
                    // Add a line break into the 1st paragraph.
                    db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
                    // Add 2nd line to the 1st paragraph, create 2nd paragraph.
                    db.Writeln("Kuupaev:" + now);
                    // Specify the paragraph alignment.
                    (section.Blocks[0] as Paragraph).ParagraphFormat.Alignment = HorizontalAlignment.Center;

                    // Add text into the 2nd paragraph.
                    db.CharacterFormat.ClearFormatting();
                    db.CharacterFormat.Size = 15;
                    db.CharacterFormat.FontColor = Color.DarkMagenta;
                    db.CharacterFormat.Bold = true;
                    for (int i = 0; i < Korv.RowCount - 1; i++)
                    {

                        toode = Korv.Rows[i].Cells[1].Value.ToString();
                        kogus = (int)Korv.Rows[i].Cells[3].Value;
                        hind = Convert.ToDouble(Korv.Rows[i].Cells[2].Value);
                        hind = Math.Round(hind, 2);
                        summa = hind * kogus;
                        db.Writeln($"Toode: {toode}\n Kogus: {kogus}\n Hind: {hind}€\n Summa: {summa}€\n ----------------------------");
                        kokku1 += summa;

                    }
                    db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
                    db.CharacterFormat.Size = 20;
                    db.CharacterFormat.FontColor = SautinSoft.Document.Color.Magenta;
                    db.CharacterFormat.UnderlineStyle = UnderlineType.Single;
                    db.CharacterFormat.Bold = false;
                    db.Write($"Kokku: {kokku1}€");

                    // Add a graphics figure into the paragraph.
                    db.CharacterFormat.ClearFormatting();

                    // Save the document to the file in PDF format.
                    dc.Save(docPath, new PdfSaveOptions()
                    { Compliance = PdfCompliance.PDF_A1a });

                    cmd = new SqlCommand("DELETE from korv", connect);
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Naita_andmed();
                    Naita_andmed_korv();
                }
            }
        }


        private void Kustamine_Click(object sender, EventArgs e)
        {
            if (Korv.SelectedRows.Count == 0)
                return;

            string sql = "DELETE from korv WHERE  Id =@rowID";
            using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
            {
                connect.Open();

                int selectedIndex = Korv.SelectedRows[0].Index;
                int rowID = Convert.ToInt32(Korv[0, selectedIndex].Value);
                deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowID;
                deleteRecord.ExecuteNonQuery();
                Korv.Rows.RemoveAt(selectedIndex);
                connect.Close();
                int pax = Int32.Parse(max);
                int pex = Int32.Parse(max1);
                cmd1 = new SqlCommand("UPDATE ToodedTable SET Kogus=@kogus WHERE Id=@id", connect);
                connect.Open();
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.Parameters.AddWithValue("@kogus", pax + pex);
                cmd1.ExecuteNonQuery();
                connect.Close();
                Naita_andmed();
                Naita_andmed_korv();
            }
        }

        private void Korv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
           max1 = Korv.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Arve_btn_Click(object sender, EventArgs e)
        {
            if (Toode_lab.Text != null)
            {
                    int sad = Int32.Parse(max);
                    cmd = new SqlCommand("INSERT INTO korv (toode,kogus,hind) VALUES (@toode,@kogus,@hind)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@toode", Toode_lab.Text);
                    cmd.Parameters.AddWithValue("@kogus", Koogus_num.Value);
                    cmd.Parameters.AddWithValue("@hind", Convert.ToDecimal(Hind_lab.Text));
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    cmd1 = new SqlCommand("UPDATE ToodedTable SET Kogus=@kogus WHERE Id=@id", connect);
                    connect.Open();
                    cmd1.Parameters.AddWithValue("@id", id);
                    cmd1.Parameters.AddWithValue("@kogus", arvenumber =  sad - (int)Koogus_num.Value);
                    cmd1.ExecuteNonQuery();
                    connect.Close();
                    Naita_andmed();
                    Naita_andmed_korv();   
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void N_Arve_btn_Click(object sender, EventArgs e)
        {
            FileStream fs = File.OpenRead(@"..\..\Arved\Arve"+ s+".pdf");
        }

        SqlDataAdapter adapter_toode, adapter_kat, adapter_kat1;
        public Mua()
        {
            openfiledialog = new OpenFileDialog
            {
                RestoreDirectory = true,
                Title = "Browse Text Files",
                Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" + "s (*.*)|*.*",

            };
            InitializeComponent();
            Naita_andmed();
            Naita_andmed_korv();
        }
        public void Naita_andmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM  Toodedtable", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView.DataSource = dt_toode;
            dataGridView.Columns["Id"].Visible = false;
            //dataGridView.Columns["Kogus"].Visible = false;
            dataGridView.Columns["Kategooria_ID"].Visible = false;

            Toode_pb.Image = System.Drawing.Image.FromFile("../../Images/1.jpg");
            Toode_pb.SizeMode = PictureBoxSizeMode.StretchImage;

            connect.Close();
        }
        public void Naita_andmed_korv()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM  korv", connect);
            adapter_toode.Fill(dt_toode);
            Korv.DataSource = dt_toode;
            Korv.Columns["Id"].Visible = false;
            connect.Close();
        }

    }
}