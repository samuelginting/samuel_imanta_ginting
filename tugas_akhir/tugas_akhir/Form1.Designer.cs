namespace tugas_akhir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.proses = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.merk = new System.Windows.Forms.ComboBox();
            this.ukuran = new System.Windows.Forms.ComboBox();
            this.warna = new System.Windows.Forms.ComboBox();
            this.jumlah = new System.Windows.Forms.ComboBox();
            this.nota = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // proses
            // 
            this.proses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(130)))));
            this.proses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(130)))));
            this.proses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proses.Image = ((System.Drawing.Image)(resources.GetObject("proses.Image")));
            this.proses.Location = new System.Drawing.Point(311, 257);
            this.proses.Name = "proses";
            this.proses.Size = new System.Drawing.Size(75, 72);
            this.proses.TabIndex = 0;
            this.proses.UseVisualStyleBackColor = false;
            this.proses.Click += new System.EventHandler(this.proses_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(130)))));
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(130)))));
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Image = ((System.Drawing.Image)(resources.GetObject("reset.Image")));
            this.reset.Location = new System.Drawing.Point(164, 256);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 72);
            this.reset.TabIndex = 1;
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // merk
            // 
            this.merk.FormattingEnabled = true;
            this.merk.Items.AddRange(new object[] {
            "Adidas",
            "Nike",
            "Reebok",
            "Skechers",
            "Vans"});
            this.merk.Location = new System.Drawing.Point(227, 114);
            this.merk.Name = "merk";
            this.merk.Size = new System.Drawing.Size(184, 21);
            this.merk.TabIndex = 2;
            // 
            // ukuran
            // 
            this.ukuran.FormattingEnabled = true;
            this.ukuran.Items.AddRange(new object[] {
            "38 EUR |   7 US    |    24 CM",
            "39 EUR |   8 US    |    25 CM",
            "40 EUR |  8.5 US  | 25.5 CM",
            "41 EUR |  9.5 US  | 26.5 CM ",
            "42 EUR |  10 US   |    27 CM",
            "43 EUR |  11 US   |    28 CM",
            "44 EUR | 11.5 US | 28.5 CM",
            "45 EUR | 12.5 US | 29.5 CM"});
            this.ukuran.Location = new System.Drawing.Point(227, 149);
            this.ukuran.Name = "ukuran";
            this.ukuran.Size = new System.Drawing.Size(184, 21);
            this.ukuran.TabIndex = 3;
            // 
            // warna
            // 
            this.warna.FormattingEnabled = true;
            this.warna.Items.AddRange(new object[] {
            "Hitam",
            "Putih",
            "Abu-abu"});
            this.warna.Location = new System.Drawing.Point(227, 182);
            this.warna.Name = "warna";
            this.warna.Size = new System.Drawing.Size(184, 21);
            this.warna.TabIndex = 4;
            // 
            // jumlah
            // 
            this.jumlah.FormattingEnabled = true;
            this.jumlah.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.jumlah.Location = new System.Drawing.Point(227, 216);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(184, 21);
            this.jumlah.TabIndex = 5;
            // 
            // nota
            // 
            this.nota.Location = new System.Drawing.Point(103, 342);
            this.nota.Multiline = true;
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            this.nota.Size = new System.Drawing.Size(321, 119);
            this.nota.TabIndex = 6;
            this.nota.Text = "-- Nota --\r\nNama   \t:\r\nMerk     \t:\r\nUkuran\t:\r\nWarna\t:\r\nJumlah\t:\r\n\r\nYang harus dib" +
    "ayar Rp.\r\n";
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(222, 76);
            this.nama.Multiline = true;
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(192, 26);
            this.nama.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(528, 464);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.warna);
            this.Controls.Add(this.ukuran);
            this.Controls.Add(this.merk);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.proses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(544, 503);
            this.MinimumSize = new System.Drawing.Size(544, 503);
            this.Name = "Form1";
            this.Text = "SEPATU QUE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button proses;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ComboBox merk;
        private System.Windows.Forms.ComboBox ukuran;
        private System.Windows.Forms.ComboBox warna;
        private System.Windows.Forms.ComboBox jumlah;
        private System.Windows.Forms.TextBox nota;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

