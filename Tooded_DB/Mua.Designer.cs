namespace Tooded_DB
{
    partial class Mua
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
            this.Arve_btn = new System.Windows.Forms.Button();
            this.N_Arve_btn = new System.Windows.Forms.Button();
            this.Koosta_btn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Toode_pb = new System.Windows.Forms.PictureBox();
            this.Hind_lbl = new System.Windows.Forms.Label();
            this.Kogus_lbl = new System.Windows.Forms.Label();
            this.Toode_lbl = new System.Windows.Forms.Label();
            this.Toode_lab = new System.Windows.Forms.Label();
            this.Hind_lab = new System.Windows.Forms.Label();
            this.Koogus_num = new System.Windows.Forms.NumericUpDown();
            this.Korv = new System.Windows.Forms.DataGridView();
            this.Kustamine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koogus_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Korv)).BeginInit();
            this.SuspendLayout();
            // 
            // Arve_btn
            // 
            this.Arve_btn.Location = new System.Drawing.Point(150, 172);
            this.Arve_btn.Name = "Arve_btn";
            this.Arve_btn.Size = new System.Drawing.Size(107, 54);
            this.Arve_btn.TabIndex = 36;
            this.Arve_btn.Text = "Lisa arvele";
            this.Arve_btn.UseVisualStyleBackColor = true;
            this.Arve_btn.Click += new System.EventHandler(this.Arve_btn_Click);
            // 
            // N_Arve_btn
            // 
            this.N_Arve_btn.Location = new System.Drawing.Point(272, 172);
            this.N_Arve_btn.Name = "N_Arve_btn";
            this.N_Arve_btn.Size = new System.Drawing.Size(107, 54);
            this.N_Arve_btn.TabIndex = 35;
            this.N_Arve_btn.Text = "Näita arve";
            this.N_Arve_btn.UseVisualStyleBackColor = true;
            this.N_Arve_btn.Click += new System.EventHandler(this.N_Arve_btn_Click);
            // 
            // Koosta_btn
            // 
            this.Koosta_btn.Location = new System.Drawing.Point(37, 172);
            this.Koosta_btn.Name = "Koosta_btn";
            this.Koosta_btn.Size = new System.Drawing.Size(107, 54);
            this.Koosta_btn.TabIndex = 34;
            this.Koosta_btn.Text = "Koosta arve";
            this.Koosta_btn.UseVisualStyleBackColor = true;
            this.Koosta_btn.Click += new System.EventHandler(this.Koosta_btn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView.Location = new System.Drawing.Point(37, 232);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(342, 198);
            this.dataGridView.TabIndex = 32;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // Toode_pb
            // 
            this.Toode_pb.Location = new System.Drawing.Point(264, 21);
            this.Toode_pb.Name = "Toode_pb";
            this.Toode_pb.Size = new System.Drawing.Size(307, 137);
            this.Toode_pb.TabIndex = 27;
            this.Toode_pb.TabStop = false;
            // 
            // Hind_lbl
            // 
            this.Hind_lbl.AutoSize = true;
            this.Hind_lbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Hind_lbl.Location = new System.Drawing.Point(75, 105);
            this.Hind_lbl.Name = "Hind_lbl";
            this.Hind_lbl.Size = new System.Drawing.Size(42, 18);
            this.Hind_lbl.TabIndex = 24;
            this.Hind_lbl.Text = "Hind";
            // 
            // Kogus_lbl
            // 
            this.Kogus_lbl.AutoSize = true;
            this.Kogus_lbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Kogus_lbl.Location = new System.Drawing.Point(66, 65);
            this.Kogus_lbl.Name = "Kogus_lbl";
            this.Kogus_lbl.Size = new System.Drawing.Size(51, 18);
            this.Kogus_lbl.TabIndex = 23;
            this.Kogus_lbl.Text = "Kogus";
            // 
            // Toode_lbl
            // 
            this.Toode_lbl.AutoSize = true;
            this.Toode_lbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Toode_lbl.Location = new System.Drawing.Point(4, 24);
            this.Toode_lbl.Name = "Toode_lbl";
            this.Toode_lbl.Size = new System.Drawing.Size(113, 18);
            this.Toode_lbl.TabIndex = 22;
            this.Toode_lbl.Text = "Toode nimetus";
            // 
            // Toode_lab
            // 
            this.Toode_lab.AutoSize = true;
            this.Toode_lab.Location = new System.Drawing.Point(130, 27);
            this.Toode_lab.Name = "Toode_lab";
            this.Toode_lab.Size = new System.Drawing.Size(0, 13);
            this.Toode_lab.TabIndex = 37;
            // 
            // Hind_lab
            // 
            this.Hind_lab.AutoSize = true;
            this.Hind_lab.Location = new System.Drawing.Point(124, 105);
            this.Hind_lab.Name = "Hind_lab";
            this.Hind_lab.Size = new System.Drawing.Size(0, 13);
            this.Hind_lab.TabIndex = 38;
            // 
            // Koogus_num
            // 
            this.Koogus_num.Location = new System.Drawing.Point(131, 67);
            this.Koogus_num.Name = "Koogus_num";
            this.Koogus_num.Size = new System.Drawing.Size(105, 20);
            this.Koogus_num.TabIndex = 39;
            // 
            // Korv
            // 
            this.Korv.AllowUserToOrderColumns = true;
            this.Korv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Korv.Cursor = System.Windows.Forms.Cursors.Default;
            this.Korv.Location = new System.Drawing.Point(406, 232);
            this.Korv.Name = "Korv";
            this.Korv.Size = new System.Drawing.Size(342, 198);
            this.Korv.TabIndex = 40;
            this.Korv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Korv_RowHeaderMouseClick);
            // 
            // Kustamine
            // 
            this.Kustamine.Location = new System.Drawing.Point(406, 172);
            this.Kustamine.Name = "Kustamine";
            this.Kustamine.Size = new System.Drawing.Size(107, 54);
            this.Kustamine.TabIndex = 41;
            this.Kustamine.Text = "Kustuta toode";
            this.Kustamine.UseVisualStyleBackColor = true;
            this.Kustamine.Click += new System.EventHandler(this.Kustamine_Click);
            // 
            // Mua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kustamine);
            this.Controls.Add(this.Korv);
            this.Controls.Add(this.Koogus_num);
            this.Controls.Add(this.Hind_lab);
            this.Controls.Add(this.Toode_lab);
            this.Controls.Add(this.Arve_btn);
            this.Controls.Add(this.N_Arve_btn);
            this.Controls.Add(this.Koosta_btn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Toode_pb);
            this.Controls.Add(this.Hind_lbl);
            this.Controls.Add(this.Kogus_lbl);
            this.Controls.Add(this.Toode_lbl);
            this.Name = "Mua";
            this.Text = "Kassa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koogus_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Korv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Arve_btn;
        private System.Windows.Forms.Button N_Arve_btn;
        private System.Windows.Forms.Button Koosta_btn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox Toode_pb;
        private System.Windows.Forms.Label Hind_lbl;
        private System.Windows.Forms.Label Kogus_lbl;
        private System.Windows.Forms.Label Toode_lbl;
        private System.Windows.Forms.Label Toode_lab;
        private System.Windows.Forms.Label Hind_lab;
        private System.Windows.Forms.NumericUpDown Koogus_num;
        private System.Windows.Forms.DataGridView Korv;
        private System.Windows.Forms.Button Kustamine;
    }
}