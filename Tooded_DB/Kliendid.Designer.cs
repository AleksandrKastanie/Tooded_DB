namespace Tooded_DB
{
    partial class Kliendid
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
            this.Kliendid_dgv = new System.Windows.Forms.DataGridView();
            this.Lisa_Klient = new System.Windows.Forms.Button();
            this.Kustuta_Klient = new System.Windows.Forms.Button();
            this.Uenda_Klient = new System.Windows.Forms.Button();
            this.Uend_tab = new System.Windows.Forms.Button();
            this.Pere_Nimi_tb = new System.Windows.Forms.TextBox();
            this.Nimi_tb = new System.Windows.Forms.TextBox();
            this.Parool = new System.Windows.Forms.Label();
            this.Kasutajanimi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Kliendid_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Kliendid_dgv
            // 
            this.Kliendid_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kliendid_dgv.Location = new System.Drawing.Point(35, 26);
            this.Kliendid_dgv.Name = "Kliendid_dgv";
            this.Kliendid_dgv.Size = new System.Drawing.Size(559, 282);
            this.Kliendid_dgv.TabIndex = 0;
            this.Kliendid_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Kliendid_dgv_RowHeaderMouseClick);
            // 
            // Lisa_Klient
            // 
            this.Lisa_Klient.Location = new System.Drawing.Point(35, 327);
            this.Lisa_Klient.Name = "Lisa_Klient";
            this.Lisa_Klient.Size = new System.Drawing.Size(99, 59);
            this.Lisa_Klient.TabIndex = 1;
            this.Lisa_Klient.Text = "Lisa uus Klient";
            this.Lisa_Klient.UseVisualStyleBackColor = true;
            this.Lisa_Klient.Click += new System.EventHandler(this.Lisa_Klient_Click);
            // 
            // Kustuta_Klient
            // 
            this.Kustuta_Klient.Location = new System.Drawing.Point(152, 327);
            this.Kustuta_Klient.Name = "Kustuta_Klient";
            this.Kustuta_Klient.Size = new System.Drawing.Size(99, 59);
            this.Kustuta_Klient.TabIndex = 2;
            this.Kustuta_Klient.Text = "Kustuta Klient";
            this.Kustuta_Klient.UseVisualStyleBackColor = true;
            this.Kustuta_Klient.Click += new System.EventHandler(this.Kustuta_Klient_Click);
            // 
            // Uenda_Klient
            // 
            this.Uenda_Klient.Location = new System.Drawing.Point(271, 327);
            this.Uenda_Klient.Name = "Uenda_Klient";
            this.Uenda_Klient.Size = new System.Drawing.Size(99, 59);
            this.Uenda_Klient.TabIndex = 3;
            this.Uenda_Klient.Text = "Värskendage andmeid";
            this.Uenda_Klient.UseVisualStyleBackColor = true;
            this.Uenda_Klient.Click += new System.EventHandler(this.Uenda_Klient_Click);
            // 
            // Uend_tab
            // 
            this.Uend_tab.Location = new System.Drawing.Point(391, 327);
            this.Uend_tab.Name = "Uend_tab";
            this.Uend_tab.Size = new System.Drawing.Size(99, 59);
            this.Uend_tab.TabIndex = 4;
            this.Uend_tab.Text = "Värskenda tabelit";
            this.Uend_tab.UseVisualStyleBackColor = true;
            this.Uend_tab.Click += new System.EventHandler(this.Uend_tab_Click);
            // 
            // Pere_Nimi_tb
            // 
            this.Pere_Nimi_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pere_Nimi_tb.Location = new System.Drawing.Point(809, 95);
            this.Pere_Nimi_tb.Name = "Pere_Nimi_tb";
            this.Pere_Nimi_tb.Size = new System.Drawing.Size(217, 30);
            this.Pere_Nimi_tb.TabIndex = 21;
            // 
            // Nimi_tb
            // 
            this.Nimi_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nimi_tb.Location = new System.Drawing.Point(809, 26);
            this.Nimi_tb.Name = "Nimi_tb";
            this.Nimi_tb.Size = new System.Drawing.Size(217, 30);
            this.Nimi_tb.TabIndex = 20;
            // 
            // Parool
            // 
            this.Parool.AutoSize = true;
            this.Parool.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parool.Location = new System.Drawing.Point(603, 95);
            this.Parool.Name = "Parool";
            this.Parool.Size = new System.Drawing.Size(136, 25);
            this.Parool.TabIndex = 18;
            this.Parool.Text = "Uus Pere Nimi";
            // 
            // Kasutajanimi
            // 
            this.Kasutajanimi.AutoSize = true;
            this.Kasutajanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kasutajanimi.Location = new System.Drawing.Point(603, 31);
            this.Kasutajanimi.Name = "Kasutajanimi";
            this.Kasutajanimi.Size = new System.Drawing.Size(90, 25);
            this.Kasutajanimi.TabIndex = 17;
            this.Kasutajanimi.Text = "Uus Nimi";
            // 
            // Kliendid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 443);
            this.Controls.Add(this.Pere_Nimi_tb);
            this.Controls.Add(this.Nimi_tb);
            this.Controls.Add(this.Parool);
            this.Controls.Add(this.Kasutajanimi);
            this.Controls.Add(this.Uend_tab);
            this.Controls.Add(this.Uenda_Klient);
            this.Controls.Add(this.Kustuta_Klient);
            this.Controls.Add(this.Lisa_Klient);
            this.Controls.Add(this.Kliendid_dgv);
            this.Name = "Kliendid";
            this.Text = "Kliendid";
            ((System.ComponentModel.ISupportInitialize)(this.Kliendid_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Kliendid_dgv;
        private System.Windows.Forms.Button Lisa_Klient;
        private System.Windows.Forms.Button Kustuta_Klient;
        private System.Windows.Forms.Button Uenda_Klient;
        private System.Windows.Forms.Button Uend_tab;
        private System.Windows.Forms.TextBox Pere_Nimi_tb;
        private System.Windows.Forms.TextBox Nimi_tb;
        private System.Windows.Forms.Label Parool;
        private System.Windows.Forms.Label Kasutajanimi;
    }
}