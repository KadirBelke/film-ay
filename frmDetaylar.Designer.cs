namespace FilmAy
{
    partial class frmDetaylar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaylar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblOyuncular = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblFiyati = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnFragman = new System.Windows.Forms.Button();
            this.mpFilm = new AxWMPLib.AxWindowsMediaPlayer();
            this.mpFragman = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpFragman)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(140, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 127);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Nova Flat", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAd.Location = new System.Drawing.Point(265, 120);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(118, 48);
            this.lblAd.TabIndex = 18;
            this.lblAd.Text = "lblAd";
            // 
            // lblTur
            // 
            this.lblTur.BackColor = System.Drawing.Color.Transparent;
            this.lblTur.Font = new System.Drawing.Font("Nova Flat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTur.Location = new System.Drawing.Point(136, 285);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(365, 65);
            this.lblTur.TabIndex = 19;
            this.lblTur.Text = "tür";
            // 
            // lblOyuncular
            // 
            this.lblOyuncular.BackColor = System.Drawing.Color.Transparent;
            this.lblOyuncular.Font = new System.Drawing.Font("Nova Flat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOyuncular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblOyuncular.Location = new System.Drawing.Point(136, 350);
            this.lblOyuncular.Name = "lblOyuncular";
            this.lblOyuncular.Size = new System.Drawing.Size(365, 112);
            this.lblOyuncular.TabIndex = 20;
            this.lblOyuncular.Text = "Oyuncular";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoEllipsis = true;
            this.lblAciklama.BackColor = System.Drawing.Color.Transparent;
            this.lblAciklama.Font = new System.Drawing.Font("Nova Flat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAciklama.Location = new System.Drawing.Point(136, 462);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(365, 174);
            this.lblAciklama.TabIndex = 21;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblFiyati
            // 
            this.lblFiyati.AutoSize = true;
            this.lblFiyati.BackColor = System.Drawing.Color.Transparent;
            this.lblFiyati.Font = new System.Drawing.Font("Nova Flat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiyati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblFiyati.Location = new System.Drawing.Point(136, 668);
            this.lblFiyati.Name = "lblFiyati";
            this.lblFiyati.Size = new System.Drawing.Size(65, 24);
            this.lblFiyati.TabIndex = 22;
            this.lblFiyati.Text = "fiyati";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.BackColor = System.Drawing.Color.Transparent;
            this.lblPuan.Font = new System.Drawing.Font("Nova Flat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblPuan.Location = new System.Drawing.Point(136, 233);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(77, 24);
            this.lblPuan.TabIndex = 23;
            this.lblPuan.Text = "Pauanı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 25;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.BackColor = System.Drawing.Color.Transparent;
            this.btnSatinAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatinAl.Font = new System.Drawing.Font("Nova Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSatinAl.Location = new System.Drawing.Point(412, 671);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(109, 38);
            this.btnSatinAl.TabIndex = 26;
            this.btnSatinAl.Text = "SATIN AL";
            this.btnSatinAl.UseVisualStyleBackColor = false;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.BackColor = System.Drawing.Color.Transparent;
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFilm.Location = new System.Drawing.Point(613, 161);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(73, 25);
            this.btnFilm.TabIndex = 31;
            this.btnFilm.Text = "FİLM";
            this.btnFilm.UseVisualStyleBackColor = false;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // btnFragman
            // 
            this.btnFragman.BackColor = System.Drawing.Color.Transparent;
            this.btnFragman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFragman.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.btnFragman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFragman.Location = new System.Drawing.Point(527, 161);
            this.btnFragman.Name = "btnFragman";
            this.btnFragman.Size = new System.Drawing.Size(86, 25);
            this.btnFragman.TabIndex = 30;
            this.btnFragman.Text = "FRAGMAN";
            this.btnFragman.UseVisualStyleBackColor = false;
            this.btnFragman.Click += new System.EventHandler(this.btnFragman_Click);
            // 
            // mpFilm
            // 
            this.mpFilm.Enabled = true;
            this.mpFilm.Location = new System.Drawing.Point(527, 186);
            this.mpFilm.Name = "mpFilm";
            this.mpFilm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpFilm.OcxState")));
            this.mpFilm.Size = new System.Drawing.Size(658, 343);
            this.mpFilm.TabIndex = 32;
            // 
            // mpFragman
            // 
            this.mpFragman.Enabled = true;
            this.mpFragman.Location = new System.Drawing.Point(527, 186);
            this.mpFragman.Name = "mpFragman";
            this.mpFragman.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpFragman.OcxState")));
            this.mpFragman.Size = new System.Drawing.Size(658, 343);
            this.mpFragman.TabIndex = 33;
            // 
            // frmDetaylar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 730);
            this.Controls.Add(this.mpFragman);
            this.Controls.Add(this.mpFilm);
            this.Controls.Add(this.btnFilm);
            this.Controls.Add(this.btnFragman);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblFiyati);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblOyuncular);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetaylar";
            this.Text = "frmKullanici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpFragman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblOyuncular;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblFiyati;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Button btnFragman;
        private AxWMPLib.AxWindowsMediaPlayer mpFilm;
        private AxWMPLib.AxWindowsMediaPlayer mpFragman;
    }
}