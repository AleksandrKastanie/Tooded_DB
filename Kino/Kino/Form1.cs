using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;
using Microsoft.Identity.Client;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms.VisualStyles;

namespace Kino
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\roof1\source\repos\Kino\Kino\AppData\kino.mdf;Integrated Security=True");
        TableLayoutPanel FilmTable;
        int b;
        Label description,name,saal,zanr, mainlabel;
        SqlCommand cmd, cmd1;
        List<string> names;
        List<string> descrip;
        List<string> MovieName;
        List<string> SaalNumber;
        List<string> Zanr;
        List<string> listofpilt;
        PictureBox films, Mainpicture;

        public Form1()
        {
            int b = MySql_Num_Rows();
            Text = "Kino";
            this.Size = new System.Drawing.Size(1200, 800);
            BackColor = Color.Black;

            //---movie table 

            FilmTable = new TableLayoutPanel()
            {
                ColumnCount= 2,
                RowCount= b,
                AutoScroll=true,
                MinimumSize = new System.Drawing.Size(500, 420),
                MaximumSize = new System.Drawing.Size(500, 420),
                Location = new System.Drawing.Point(600,50),
                Margin= new System.Windows.Forms.Padding(15),
            };
            this.Controls.Add( FilmTable );
            



            //---Films posters
            //new lists for labels 
            listofpilt = new List<string>();
            descrip= new List<string>();
            MovieName= new List<string>();
            SaalNumber= new List<string>();
            Zanr = new List<string>();
            //----------------------------------
            listofpilt = Getpildid();
            descrip = GetDescrip();
            MovieName = GetNameOfMovie();
            SaalNumber = Saal();
            Zanr = GetZanr();

            for (int i = 0; i < b; i++)
            {

                films = new PictureBox()
                {
                    Name = listofpilt[i].ToString(),
                    Size = new Size(200, 250),
                    Image = System.Drawing.Image.FromFile(@"C:\Users\roof1\source\repos\Kino\Kino\Pictures\" + listofpilt[i]),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };

                description = new Label()  
                {
                    Text = " Name: " + MovieName[i].ToString() + "\n Zanr: " + Zanr[i].ToString() + "\n Saal: " + SaalNumber[i].ToString() + "\n Description:  " + descrip[i].ToString(),
                    AutoSize = false,
                    Size = new Size(200, 250),
                    TextAlign = System.Drawing.ContentAlignment.BottomLeft,
                    ForeColor= Color.White
                    
                };



                FilmTable.Controls.Add(films, 0, i);
                FilmTable.Controls.Add(description,1, i);
            }
            foreach (Control control in FilmTable.Controls)
            {
                PictureBox pictureFilms = control as PictureBox;
                if (pictureFilms != null)
                {
                    pictureFilms.Click += pictureBox_Click;
                }
            }

            Mainpicture = new PictureBox()
            {
                Size = new Size(500, 420),
                Location = new Point(50,50),
                SizeMode = PictureBoxSizeMode.StretchImage,

            };
            this.Controls.Add(Mainpicture);

            mainlabel = new Label()
            {
                Location = new Point(50, 500),
                Size = new Size(500,300),
                
            };
            this.Controls.Add(mainlabel);




        }
        //Events()

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox _clicked = sender as PictureBox;
            Mainpicture.Image = _clicked.Image;
            mainlabel.Text = description.Text;
            mainlabel.ForeColor= Color.White;
            mainlabel.Font= new Font("Italic", 20, FontStyle.Italic);

        }






        //Functions()---------------------------------------------------------


        //Get names from tables 
        public List<string> Getpildid()
        {

            names = new List<string>();
            connect.Open();
            cmd = new SqlCommand("SELECT Pilt FROM kinos", connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    names.Add(reader["Pilt"].ToString());
                }
            }
            connect.Close();
            return names;
        }

        //get info(Zanr) from database 
        public List<string> GetZanr()
        {

            names = new List<string>();
            connect.Open();
            cmd = new SqlCommand("SELECT Zanr FROM kinos", connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    names.Add(reader["Zanr"].ToString());
                }
            }
            connect.Close();
            return names;
        }

        //get info(Name of Movie) from database 
        public List<string> GetNameOfMovie()
        {

            names = new List<string>();
            connect.Open();
            cmd = new SqlCommand("SELECT KinoNimetus FROM kinos", connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    names.Add(reader["KinoNimetus"].ToString());
                }
            }
            connect.Close();
            return names;
        }


        //get info(Name of Movie) from database 
        public List<string> Saal()
        {

            names = new List<string>();
            connect.Open();
            cmd = new SqlCommand("SELECT SaalNumber FROM kinos", connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    names.Add(reader["SaalNumber"].ToString());
                }
            }
            connect.Close();
            return names;
        }


        //get info(description) from database 
        public List<string> GetDescrip()
        {

            names = new List<string>();
            connect.Open();
            cmd = new SqlCommand("SELECT Discription FROM kinos", connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    names.Add(reader["Discription"].ToString());
                }
            }
            connect.Close();
            return names;
        }

        //Get count of rows for create table with posters 
        public int MySql_Num_Rows()
        {
            int c = 0;
            connect.Open();
            cmd = new SqlCommand("SELECT count(*) FROM kinos", connect);
            c = (Int32)cmd.ExecuteScalar();
            connect.Close();
            return c;
        }

    }
}