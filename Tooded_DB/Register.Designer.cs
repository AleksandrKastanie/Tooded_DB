﻿namespace Tooded_DB
{
    partial class Register
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
            this.Parool_tb = new System.Windows.Forms.TextBox();
            this.Kasutaja_tb = new System.Windows.Forms.TextBox();
            this.Tuup_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Parool = new System.Windows.Forms.Label();
            this.Kasutajanimi = new System.Windows.Forms.Label();
            this.Parool_tb2 = new System.Windows.Forms.TextBox();
            this.Parool2 = new System.Windows.Forms.Label();
            this.Registreerimine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Parool_tb
            // 
            this.Parool_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parool_tb.Location = new System.Drawing.Point(277, 132);
            this.Parool_tb.Name = "Parool_tb";
            this.Parool_tb.PasswordChar = '*';
            this.Parool_tb.Size = new System.Drawing.Size(217, 30);
            this.Parool_tb.TabIndex = 13;
            // 
            // Kasutaja_tb
            // 
            this.Kasutaja_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kasutaja_tb.Location = new System.Drawing.Point(277, 68);
            this.Kasutaja_tb.Name = "Kasutaja_tb";
            this.Kasutaja_tb.Size = new System.Drawing.Size(217, 30);
            this.Kasutaja_tb.TabIndex = 12;
            // 
            // Tuup_cb
            // 
            this.Tuup_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tuup_cb.FormattingEnabled = true;
            this.Tuup_cb.Items.AddRange(new object[] {
            "Omanik",
            "Kassa"});
            this.Tuup_cb.Location = new System.Drawing.Point(277, 284);
            this.Tuup_cb.Name = "Tuup_cb";
            this.Tuup_cb.Size = new System.Drawing.Size(217, 33);
            this.Tuup_cb.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kasutaja tüüp";
            // 
            // Parool
            // 
            this.Parool.AutoSize = true;
            this.Parool.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parool.Location = new System.Drawing.Point(71, 137);
            this.Parool.Name = "Parool";
            this.Parool.Size = new System.Drawing.Size(68, 25);
            this.Parool.TabIndex = 9;
            this.Parool.Text = "Parool";
            // 
            // Kasutajanimi
            // 
            this.Kasutajanimi.AutoSize = true;
            this.Kasutajanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kasutajanimi.Location = new System.Drawing.Point(71, 73);
            this.Kasutajanimi.Name = "Kasutajanimi";
            this.Kasutajanimi.Size = new System.Drawing.Size(124, 25);
            this.Kasutajanimi.TabIndex = 8;
            this.Kasutajanimi.Text = "Kasutajanimi";
            // 
            // Parool_tb2
            // 
            this.Parool_tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parool_tb2.Location = new System.Drawing.Point(277, 195);
            this.Parool_tb2.Name = "Parool_tb2";
            this.Parool_tb2.PasswordChar = '*';
            this.Parool_tb2.Size = new System.Drawing.Size(217, 30);
            this.Parool_tb2.TabIndex = 15;
            // 
            // Parool2
            // 
            this.Parool2.AutoSize = true;
            this.Parool2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parool2.Location = new System.Drawing.Point(71, 200);
            this.Parool2.Name = "Parool2";
            this.Parool2.Size = new System.Drawing.Size(131, 25);
            this.Parool2.TabIndex = 14;
            this.Parool2.Text = "Kinnita parool";
            // 
            // Registreerimine
            // 
            this.Registreerimine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registreerimine.Location = new System.Drawing.Point(277, 372);
            this.Registreerimine.Name = "Registreerimine";
            this.Registreerimine.Size = new System.Drawing.Size(163, 44);
            this.Registreerimine.TabIndex = 16;
            this.Registreerimine.Text = "Registreerimine";
            this.Registreerimine.UseVisualStyleBackColor = true;
            this.Registreerimine.Click += new System.EventHandler(this.Registreerimine_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Registreerimine);
            this.Controls.Add(this.Parool_tb2);
            this.Controls.Add(this.Parool2);
            this.Controls.Add(this.Parool_tb);
            this.Controls.Add(this.Kasutaja_tb);
            this.Controls.Add(this.Tuup_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parool);
            this.Controls.Add(this.Kasutajanimi);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Parool_tb;
        private System.Windows.Forms.TextBox Kasutaja_tb;
        private System.Windows.Forms.ComboBox Tuup_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Parool;
        private System.Windows.Forms.Label Kasutajanimi;
        private System.Windows.Forms.TextBox Parool_tb2;
        private System.Windows.Forms.Label Parool2;
        private System.Windows.Forms.Button Registreerimine;
    }
}