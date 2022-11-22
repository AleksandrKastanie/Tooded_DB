namespace Tooded_DB
{
    partial class uus_klient
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
            this.Pere_Nimi_tb = new System.Windows.Forms.TextBox();
            this.Nimi_tb = new System.Windows.Forms.TextBox();
            this.Registreerimine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Parool = new System.Windows.Forms.Label();
            this.Kasutajanimi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Sulge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pere_Nimi_tb
            // 
            this.Pere_Nimi_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pere_Nimi_tb.Location = new System.Drawing.Point(313, 131);
            this.Pere_Nimi_tb.Name = "Pere_Nimi_tb";
            this.Pere_Nimi_tb.Size = new System.Drawing.Size(217, 30);
            this.Pere_Nimi_tb.TabIndex = 15;
            // 
            // Nimi_tb
            // 
            this.Nimi_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nimi_tb.Location = new System.Drawing.Point(313, 62);
            this.Nimi_tb.Name = "Nimi_tb";
            this.Nimi_tb.Size = new System.Drawing.Size(217, 30);
            this.Nimi_tb.TabIndex = 14;
            // 
            // Registreerimine
            // 
            this.Registreerimine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registreerimine.Location = new System.Drawing.Point(112, 346);
            this.Registreerimine.Name = "Registreerimine";
            this.Registreerimine.Size = new System.Drawing.Size(163, 44);
            this.Registreerimine.TabIndex = 12;
            this.Registreerimine.Text = "Registreerimine";
            this.Registreerimine.UseVisualStyleBackColor = true;
            this.Registreerimine.Click += new System.EventHandler(this.Registreerimine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Isikukood";
            // 
            // Parool
            // 
            this.Parool.AutoSize = true;
            this.Parool.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parool.Location = new System.Drawing.Point(107, 131);
            this.Parool.Name = "Parool";
            this.Parool.Size = new System.Drawing.Size(96, 25);
            this.Parool.TabIndex = 9;
            this.Parool.Text = "Pere Nimi";
            // 
            // Kasutajanimi
            // 
            this.Kasutajanimi.AutoSize = true;
            this.Kasutajanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kasutajanimi.Location = new System.Drawing.Point(107, 67);
            this.Kasutajanimi.Name = "Kasutajanimi";
            this.Kasutajanimi.Size = new System.Drawing.Size(50, 25);
            this.Kasutajanimi.TabIndex = 8;
            this.Kasutajanimi.Text = "Nimi";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(313, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 30);
            this.textBox1.TabIndex = 16;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Sulge
            // 
            this.Sulge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sulge.Location = new System.Drawing.Point(425, 346);
            this.Sulge.Name = "Sulge";
            this.Sulge.Size = new System.Drawing.Size(163, 44);
            this.Sulge.TabIndex = 17;
            this.Sulge.Text = "Sulge";
            this.Sulge.UseVisualStyleBackColor = true;
            this.Sulge.Click += new System.EventHandler(this.Sulge_Click);
            // 
            // uus_klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sulge);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pere_Nimi_tb);
            this.Controls.Add(this.Nimi_tb);
            this.Controls.Add(this.Registreerimine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parool);
            this.Controls.Add(this.Kasutajanimi);
            this.Name = "uus_klient";
            this.Text = "uus_klient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pere_Nimi_tb;
        private System.Windows.Forms.TextBox Nimi_tb;
        private System.Windows.Forms.Button Registreerimine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Parool;
        private System.Windows.Forms.Label Kasutajanimi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Sulge;
    }
}