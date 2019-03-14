namespace FilmAy
{
    partial class frmSatinAlinanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatinAlinanlar));
            this.btnGeri = new System.Windows.Forms.Button();
            this.nudSayfa = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.grbAna = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.Yellow;
            this.btnGeri.Location = new System.Drawing.Point(0, 0);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(25, 25);
            this.btnGeri.TabIndex = 18;
            this.btnGeri.Text = "←";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // nudSayfa
            // 
            this.nudSayfa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudSayfa.Location = new System.Drawing.Point(582, 512);
            this.nudSayfa.Name = "nudSayfa";
            this.nudSayfa.Size = new System.Drawing.Size(30, 20);
            this.nudSayfa.TabIndex = 21;
            this.nudSayfa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSayfa.ValueChanged += new System.EventHandler(this.nudSayfa_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Nova Flat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Pink;
            this.label8.Location = new System.Drawing.Point(145, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 14);
            this.label8.TabIndex = 22;
            // 
            // grbAna
            // 
            this.grbAna.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.grbAna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAna.BackColor = System.Drawing.Color.Transparent;
            this.grbAna.Location = new System.Drawing.Point(88, 80);
            this.grbAna.Name = "grbAna";
            this.grbAna.Size = new System.Drawing.Size(1040, 410);
            this.grbAna.TabIndex = 19;
            this.grbAna.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nova Flat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Pink;
            this.label7.Location = new System.Drawing.Point(532, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Sayfa :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nova Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(85, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Film Adı :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(171, 42);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(176, 20);
            this.txtAd.TabIndex = 23;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Transparent;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Nova Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAra.Location = new System.Drawing.Point(362, 35);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(56, 31);
            this.btnAra.TabIndex = 25;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            // 
            // frmSatinAlinanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 561);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.nudSayfa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grbAna);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSatinAlinanlar";
            this.Text = "frmSatinAlinanlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSatinAlinanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.NumericUpDown nudSayfa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grbAna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnAra;
    }
}