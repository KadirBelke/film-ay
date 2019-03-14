namespace FilmAy
{
    partial class frmTurOyuncuPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurOyuncuPanel));
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.cmbTID = new System.Windows.Forms.ComboBox();
            this.lvTur = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtOYasi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOSoyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOTemizli = new System.Windows.Forms.Button();
            this.btnOSil = new System.Windows.Forms.Button();
            this.btnOGuncelle = new System.Windows.Forms.Button();
            this.btnOEkle = new System.Windows.Forms.Button();
            this.txtOAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOGoster = new System.Windows.Forms.Button();
            this.cmbOID = new System.Windows.Forms.ComboBox();
            this.lvOyuncu = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKulanicilar = new System.Windows.Forms.Button();
            this.btnFilmler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Red;
            this.btnCikis.Location = new System.Drawing.Point(1189, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(25, 25);
            this.btnCikis.TabIndex = 36;
            this.btnCikis.Text = "x";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnGoster);
            this.groupBox1.Controls.Add(this.cmbTID);
            this.groupBox1.Controls.Add(this.lvTur);
            this.groupBox1.Font = new System.Drawing.Font("Nova Flat", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Salmon;
            this.groupBox1.Location = new System.Drawing.Point(317, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 243);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TUR EKLE GÜNCELLE VE SİL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtTAdi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(295, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 111);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTemizle.Location = new System.Drawing.Point(169, 78);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(97, 23);
            this.btnTemizle.TabIndex = 34;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(200, 49);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 33;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnGuncelle.Location = new System.Drawing.Point(95, 49);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(97, 23);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.Lime;
            this.btnEkle.Location = new System.Drawing.Point(7, 49);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 23);
            this.btnEkle.TabIndex = 31;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtTAdi
            // 
            this.txtTAdi.Location = new System.Drawing.Point(60, 22);
            this.txtTAdi.Name = "txtTAdi";
            this.txtTAdi.Size = new System.Drawing.Size(215, 21);
            this.txtTAdi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adi :";
            // 
            // btnGoster
            // 
            this.btnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoster.Location = new System.Drawing.Point(501, 67);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(69, 23);
            this.btnGoster.TabIndex = 2;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // cmbTID
            // 
            this.cmbTID.FormattingEnabled = true;
            this.cmbTID.Location = new System.Drawing.Point(355, 68);
            this.cmbTID.Name = "cmbTID";
            this.cmbTID.Size = new System.Drawing.Size(130, 22);
            this.cmbTID.TabIndex = 1;
            // 
            // lvTur
            // 
            this.lvTur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvTur.Location = new System.Drawing.Point(19, 35);
            this.lvTur.Name = "lvTur";
            this.lvTur.Size = new System.Drawing.Size(267, 191);
            this.lvTur.TabIndex = 0;
            this.lvTur.UseCompatibleStateImageBehavior = false;
            this.lvTur.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 207;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnOGoster);
            this.groupBox3.Controls.Add(this.cmbOID);
            this.groupBox3.Controls.Add(this.lvOyuncu);
            this.groupBox3.Font = new System.Drawing.Font("Nova Flat", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Salmon;
            this.groupBox3.Location = new System.Drawing.Point(229, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(774, 243);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OYUNCU EKLE GÜNCELLE VE SİL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtOYasi);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtOSoyadi);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnOTemizli);
            this.groupBox4.Controls.Add(this.btnOSil);
            this.groupBox4.Controls.Add(this.btnOGuncelle);
            this.groupBox4.Controls.Add(this.btnOEkle);
            this.groupBox4.Controls.Add(this.txtOAdi);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(483, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 166);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // txtOYasi
            // 
            this.txtOYasi.Location = new System.Drawing.Point(60, 76);
            this.txtOYasi.Name = "txtOYasi";
            this.txtOYasi.Size = new System.Drawing.Size(215, 21);
            this.txtOYasi.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 37;
            this.label6.Text = "Yaşı :";
            // 
            // txtOSoyadi
            // 
            this.txtOSoyadi.Location = new System.Drawing.Point(60, 49);
            this.txtOSoyadi.Name = "txtOSoyadi";
            this.txtOSoyadi.Size = new System.Drawing.Size(215, 21);
            this.txtOSoyadi.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 35;
            this.label5.Text = "Soyadı :";
            // 
            // btnOTemizli
            // 
            this.btnOTemizli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOTemizli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOTemizli.Location = new System.Drawing.Point(168, 137);
            this.btnOTemizli.Name = "btnOTemizli";
            this.btnOTemizli.Size = new System.Drawing.Size(97, 23);
            this.btnOTemizli.TabIndex = 34;
            this.btnOTemizli.Text = "TEMİZLE";
            this.btnOTemizli.UseVisualStyleBackColor = true;
            this.btnOTemizli.Click += new System.EventHandler(this.btnOTemizli_Click);
            // 
            // btnOSil
            // 
            this.btnOSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOSil.ForeColor = System.Drawing.Color.Red;
            this.btnOSil.Location = new System.Drawing.Point(200, 108);
            this.btnOSil.Name = "btnOSil";
            this.btnOSil.Size = new System.Drawing.Size(75, 23);
            this.btnOSil.TabIndex = 33;
            this.btnOSil.Text = "SİL";
            this.btnOSil.UseVisualStyleBackColor = true;
            this.btnOSil.Click += new System.EventHandler(this.btnOSil_Click);
            // 
            // btnOGuncelle
            // 
            this.btnOGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOGuncelle.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnOGuncelle.Location = new System.Drawing.Point(93, 108);
            this.btnOGuncelle.Name = "btnOGuncelle";
            this.btnOGuncelle.Size = new System.Drawing.Size(97, 23);
            this.btnOGuncelle.TabIndex = 32;
            this.btnOGuncelle.Text = "GÜNCELLE";
            this.btnOGuncelle.UseVisualStyleBackColor = true;
            this.btnOGuncelle.Click += new System.EventHandler(this.btnOGuncelle_Click);
            // 
            // btnOEkle
            // 
            this.btnOEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOEkle.ForeColor = System.Drawing.Color.Lime;
            this.btnOEkle.Location = new System.Drawing.Point(7, 108);
            this.btnOEkle.Name = "btnOEkle";
            this.btnOEkle.Size = new System.Drawing.Size(81, 23);
            this.btnOEkle.TabIndex = 31;
            this.btnOEkle.Text = "EKLE";
            this.btnOEkle.UseVisualStyleBackColor = true;
            this.btnOEkle.Click += new System.EventHandler(this.btnOEkle_Click);
            // 
            // txtOAdi
            // 
            this.txtOAdi.Location = new System.Drawing.Point(60, 22);
            this.txtOAdi.Name = "txtOAdi";
            this.txtOAdi.Size = new System.Drawing.Size(215, 21);
            this.txtOAdi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adi :";
            // 
            // btnOGoster
            // 
            this.btnOGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOGoster.Location = new System.Drawing.Point(689, 31);
            this.btnOGoster.Name = "btnOGoster";
            this.btnOGoster.Size = new System.Drawing.Size(69, 23);
            this.btnOGoster.TabIndex = 2;
            this.btnOGoster.Text = "GÖSTER";
            this.btnOGoster.UseVisualStyleBackColor = true;
            this.btnOGoster.Click += new System.EventHandler(this.btnOGoster_Click);
            // 
            // cmbOID
            // 
            this.cmbOID.FormattingEnabled = true;
            this.cmbOID.Location = new System.Drawing.Point(543, 32);
            this.cmbOID.Name = "cmbOID";
            this.cmbOID.Size = new System.Drawing.Size(130, 22);
            this.cmbOID.TabIndex = 1;
            // 
            // lvOyuncu
            // 
            this.lvOyuncu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvOyuncu.Location = new System.Drawing.Point(19, 35);
            this.lvOyuncu.Name = "lvOyuncu";
            this.lvOyuncu.Size = new System.Drawing.Size(444, 191);
            this.lvOyuncu.TabIndex = 0;
            this.lvOyuncu.UseCompatibleStateImageBehavior = false;
            this.lvOyuncu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 52;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adı";
            this.columnHeader4.Width = 147;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Soyadı";
            this.columnHeader5.Width = 163;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Yaşı";
            this.columnHeader6.Width = 75;
            // 
            // btnKulanicilar
            // 
            this.btnKulanicilar.BackColor = System.Drawing.Color.Transparent;
            this.btnKulanicilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKulanicilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKulanicilar.ForeColor = System.Drawing.Color.Cyan;
            this.btnKulanicilar.Location = new System.Drawing.Point(148, 27);
            this.btnKulanicilar.Name = "btnKulanicilar";
            this.btnKulanicilar.Size = new System.Drawing.Size(126, 34);
            this.btnKulanicilar.TabIndex = 40;
            this.btnKulanicilar.Text = "KULLANICILAR";
            this.btnKulanicilar.UseVisualStyleBackColor = false;
            this.btnKulanicilar.Click += new System.EventHandler(this.btnKulanicilar_Click);
            // 
            // btnFilmler
            // 
            this.btnFilmler.BackColor = System.Drawing.Color.Transparent;
            this.btnFilmler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmler.ForeColor = System.Drawing.Color.Cyan;
            this.btnFilmler.Location = new System.Drawing.Point(36, 27);
            this.btnFilmler.Name = "btnFilmler";
            this.btnFilmler.Size = new System.Drawing.Size(106, 34);
            this.btnFilmler.TabIndex = 39;
            this.btnFilmler.Text = "FİLMLER";
            this.btnFilmler.UseVisualStyleBackColor = false;
            this.btnFilmler.Click += new System.EventHandler(this.btnFilmler_Click);
            // 
            // frmTurOyuncuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 561);
            this.Controls.Add(this.btnKulanicilar);
            this.Controls.Add(this.btnFilmler);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTurOyuncuPanel";
            this.Text = "frmTurOyuncuPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTurOyuncuPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTID;
        private System.Windows.Forms.ListView lvTur;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtOYasi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOSoyadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOTemizli;
        private System.Windows.Forms.Button btnOSil;
        private System.Windows.Forms.Button btnOGuncelle;
        private System.Windows.Forms.Button btnOEkle;
        private System.Windows.Forms.TextBox txtOAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOGoster;
        private System.Windows.Forms.ComboBox cmbOID;
        private System.Windows.Forms.ListView lvOyuncu;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnKulanicilar;
        private System.Windows.Forms.Button btnFilmler;
    }
}