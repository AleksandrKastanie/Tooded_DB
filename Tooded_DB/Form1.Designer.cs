namespace Tooded_DB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Toode_txt = new System.Windows.Forms.TextBox();
            this.Kogus_txt = new System.Windows.Forms.TextBox();
            this.Hind_txt = new System.Windows.Forms.TextBox();
            this.Toode_lbl = new System.Windows.Forms.Label();
            this.Kogus_lbl = new System.Windows.Forms.Label();
            this.Hind_lbl = new System.Windows.Forms.Label();
            this.Kategooria_lbl = new System.Windows.Forms.Label();
            this.Kategooria_cb = new System.Windows.Forms.ComboBox();
            this.Toode_pb = new System.Windows.Forms.PictureBox();
            this.Otsi_btn = new System.Windows.Forms.Button();
            this.Lisa_btn = new System.Windows.Forms.Button();
            this.Uenda_btn = new System.Windows.Forms.Button();
            this.Kustutan_btn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Lisa_Kat = new System.Windows.Forms.Button();
            this.Klient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Toode_txt
            // 
            this.Toode_txt.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toode_txt.Location = new System.Drawing.Point(123, 21);
            this.Toode_txt.Name = "Toode_txt";
            this.Toode_txt.Size = new System.Drawing.Size(100, 25);
            this.Toode_txt.TabIndex = 0;
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kogus_txt.Location = new System.Drawing.Point(123, 62);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(100, 25);
            this.Kogus_txt.TabIndex = 1;
            this.Kogus_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kogus_txt_KeyPress_1);
            // 
            // Hind_txt
            // 
            this.Hind_txt.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hind_txt.Location = new System.Drawing.Point(123, 102);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(100, 25);
            this.Hind_txt.TabIndex = 2;
            this.Hind_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hind_txt_KeyPress);
            // 
            // Toode_lbl
            // 
            this.Toode_lbl.AutoSize = true;
            this.Toode_lbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Toode_lbl.Location = new System.Drawing.Point(4, 24);
            this.Toode_lbl.Name = "Toode_lbl";
            this.Toode_lbl.Size = new System.Drawing.Size(113, 18);
            this.Toode_lbl.TabIndex = 3;
            this.Toode_lbl.Text = "Toode nimetus";
            // 
            // Kogus_lbl
            // 
            this.Kogus_lbl.AutoSize = true;
            this.Kogus_lbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Kogus_lbl.Location = new System.Drawing.Point(66, 65);
            this.Kogus_lbl.Name = "Kogus_lbl";
            this.Kogus_lbl.Size = new System.Drawing.Size(51, 18);
            this.Kogus_lbl.TabIndex = 4;
            this.Kogus_lbl.Text = "Kogus";
            // 
            // Hind_lbl
            // 
            this.Hind_lbl.AutoSize = true;
            this.Hind_lbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Hind_lbl.Location = new System.Drawing.Point(75, 105);
            this.Hind_lbl.Name = "Hind_lbl";
            this.Hind_lbl.Size = new System.Drawing.Size(42, 18);
            this.Hind_lbl.TabIndex = 5;
            this.Hind_lbl.Text = "Hind";
            // 
            // Kategooria_lbl
            // 
            this.Kategooria_lbl.AutoSize = true;
            this.Kategooria_lbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Kategooria_lbl.Location = new System.Drawing.Point(33, 138);
            this.Kategooria_lbl.Name = "Kategooria_lbl";
            this.Kategooria_lbl.Size = new System.Drawing.Size(84, 18);
            this.Kategooria_lbl.TabIndex = 6;
            this.Kategooria_lbl.Text = "Kategooria";
            // 
            // Kategooria_cb
            // 
            this.Kategooria_cb.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Kategooria_cb.FormattingEnabled = true;
            this.Kategooria_cb.Location = new System.Drawing.Point(123, 135);
            this.Kategooria_cb.Name = "Kategooria_cb";
            this.Kategooria_cb.Size = new System.Drawing.Size(100, 26);
            this.Kategooria_cb.TabIndex = 7;
            // 
            // Toode_pb
            // 
            this.Toode_pb.Location = new System.Drawing.Point(264, 21);
            this.Toode_pb.Name = "Toode_pb";
            this.Toode_pb.Size = new System.Drawing.Size(307, 137);
            this.Toode_pb.TabIndex = 8;
            this.Toode_pb.TabStop = false;
            // 
            // Otsi_btn
            // 
            this.Otsi_btn.Location = new System.Drawing.Point(577, 102);
            this.Otsi_btn.Name = "Otsi_btn";
            this.Otsi_btn.Size = new System.Drawing.Size(107, 54);
            this.Otsi_btn.TabIndex = 9;
            this.Otsi_btn.Text = "Otsi fail";
            this.Otsi_btn.UseVisualStyleBackColor = true;
            this.Otsi_btn.Click += new System.EventHandler(this.Otsi_btn_Click);
            // 
            // Lisa_btn
            // 
            this.Lisa_btn.Location = new System.Drawing.Point(351, 164);
            this.Lisa_btn.Name = "Lisa_btn";
            this.Lisa_btn.Size = new System.Drawing.Size(107, 54);
            this.Lisa_btn.TabIndex = 10;
            this.Lisa_btn.Text = "Lisa";
            this.Lisa_btn.UseVisualStyleBackColor = true;
            this.Lisa_btn.Click += new System.EventHandler(this.Lisa_btn_Click);
            // 
            // Uenda_btn
            // 
            this.Uenda_btn.Location = new System.Drawing.Point(464, 164);
            this.Uenda_btn.Name = "Uenda_btn";
            this.Uenda_btn.Size = new System.Drawing.Size(107, 54);
            this.Uenda_btn.TabIndex = 11;
            this.Uenda_btn.Text = "Uenda";
            this.Uenda_btn.UseVisualStyleBackColor = true;
            this.Uenda_btn.Click += new System.EventHandler(this.uuenda_btn_Click);
            // 
            // Kustutan_btn
            // 
            this.Kustutan_btn.Location = new System.Drawing.Point(577, 164);
            this.Kustutan_btn.Name = "Kustutan_btn";
            this.Kustutan_btn.Size = new System.Drawing.Size(107, 54);
            this.Kustutan_btn.TabIndex = 12;
            this.Kustutan_btn.Text = "Kustuta";
            this.Kustutan_btn.UseVisualStyleBackColor = true;
            this.Kustutan_btn.Click += new System.EventHandler(this.Kustutanbtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView.Location = new System.Drawing.Point(37, 232);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(646, 198);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // Lisa_Kat
            // 
            this.Lisa_Kat.Location = new System.Drawing.Point(238, 164);
            this.Lisa_Kat.Name = "Lisa_Kat";
            this.Lisa_Kat.Size = new System.Drawing.Size(107, 54);
            this.Lisa_Kat.TabIndex = 14;
            this.Lisa_Kat.Text = "Lisa Kategooriat";
            this.Lisa_Kat.UseVisualStyleBackColor = true;
            this.Lisa_Kat.Click += new System.EventHandler(this.Lisa_Kat_Click);
            // 
            // Klient
            // 
            this.Klient.Location = new System.Drawing.Point(576, 42);
            this.Klient.Name = "Klient";
            this.Klient.Size = new System.Drawing.Size(107, 54);
            this.Klient.TabIndex = 15;
            this.Klient.Text = "Klientide andmebaas";
            this.Klient.UseVisualStyleBackColor = true;
            this.Klient.Click += new System.EventHandler(this.Klient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Klient);
            this.Controls.Add(this.Lisa_Kat);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Kustutan_btn);
            this.Controls.Add(this.Uenda_btn);
            this.Controls.Add(this.Lisa_btn);
            this.Controls.Add(this.Otsi_btn);
            this.Controls.Add(this.Toode_pb);
            this.Controls.Add(this.Kategooria_cb);
            this.Controls.Add(this.Kategooria_lbl);
            this.Controls.Add(this.Hind_lbl);
            this.Controls.Add(this.Kogus_lbl);
            this.Controls.Add(this.Toode_lbl);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.Toode_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Toode_txt;
        private System.Windows.Forms.TextBox Kogus_txt;
        private System.Windows.Forms.TextBox Hind_txt;
        private System.Windows.Forms.Label Toode_lbl;
        private System.Windows.Forms.Label Kogus_lbl;
        private System.Windows.Forms.Label Hind_lbl;
        private System.Windows.Forms.Label Kategooria_lbl;
        private System.Windows.Forms.ComboBox Kategooria_cb;
        private System.Windows.Forms.PictureBox Toode_pb;
        private System.Windows.Forms.Button Otsi_btn;
        private System.Windows.Forms.Button Lisa_btn;
        private System.Windows.Forms.Button Uenda_btn;
        private System.Windows.Forms.Button Kustutan_btn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Lisa_Kat;
        private System.Windows.Forms.Button Klient;
    }
}

