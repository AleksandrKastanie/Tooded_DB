namespace Tooded_DB
{
    partial class klient_check
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
            this.Isik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Kinnita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Isik
            // 
            this.Isik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Isik.Location = new System.Drawing.Point(339, 82);
            this.Isik.Name = "Isik";
            this.Isik.Size = new System.Drawing.Size(217, 30);
            this.Isik.TabIndex = 18;
            this.Isik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Isik_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(133, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Isikukood";
            // 
            // Kinnita
            // 
            this.Kinnita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kinnita.Location = new System.Drawing.Point(278, 158);
            this.Kinnita.Name = "Kinnita";
            this.Kinnita.Size = new System.Drawing.Size(163, 44);
            this.Kinnita.TabIndex = 19;
            this.Kinnita.Text = "Kinnita";
            this.Kinnita.UseVisualStyleBackColor = true;
            this.Kinnita.Click += new System.EventHandler(this.Kinnita_Click);
            // 
            // klient_check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 214);
            this.Controls.Add(this.Kinnita);
            this.Controls.Add(this.Isik);
            this.Controls.Add(this.label1);
            this.Name = "klient_check";
            this.Text = "klient_check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Isik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Kinnita;
    }
}