using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FilmAy
{
    public partial class frmKutuphane : Form
    {
        public frmKutuphane()
        {
            InitializeComponent();
        }
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = FilmAy.accdb; Jet OLEDB:Database Password = film");
        public int kayitSayisi;
        public string[,] str;

        
        private void islemm(int a)
        {
      
            while (grbAna.Controls.Count!=0)
            {
                grbAna.Controls.Remove(grbAna.Controls[0]);
            }
            int sayac = 0+(12*(a-1));
            for (int i = 1; i < 3; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    if (kayitSayisi <= sayac)
                    {
                        break;
                    }
                    GroupBox grb = new GroupBox();
                    grb.Location = new Point((j * 180) - 135, (i * 250) - 220);
                    grb.Size = new Size(175, 245);
                    string ss = str[sayac, 0];
                    if (ss.Length>12)
                    {
                        grb.Text = ss.Substring(0,12) + "...";
                    }
                    else
                    {
                        grb.Text = ss;
                    }   
                    grb.BackColor = Color.Transparent;
                    grb.ForeColor = Color.Aqua;
                    grb.Font = new Font("Nova Flat", 12, FontStyle.Bold);
                    grbAna.Controls.Add(grb);
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(32, 20);
                    pb.Size = new Size(110, 140);
                    grb.Controls.Add(pb);
                    pb.Image = Image.FromFile(str[sayac, 1]);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    Label lbl = new Label();
                    lbl.Location = new Point(35, 165);
                    lbl.ForeColor = Color.Aqua;
                    lbl.BackColor = Color.Transparent;
                    lbl.Font = new Font("Nova Flat", 8, FontStyle.Bold);
                    lbl.Text = "Fiyatı = " + str[sayac, 2] + "₺";
                    grb.Controls.Add(lbl);
                    Label lbl2 = new Label();
                    lbl2.Location = new Point(45, 190);
                    lbl2.ForeColor = Color.Aqua;
                    lbl2.BackColor = Color.Transparent;
                    lbl2.Font = new Font("Nova Flat", 8, FontStyle.Bold);
                    lbl2.Text = "Puanı = " + str[sayac, 3];
                    grb.Controls.Add(lbl2);
                    Button btn = new Button();
                    btn.Location = new Point(45, 213);
                    btn.Size = new Size(80, 26);
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.LightGreen;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Nova Flat", 10, FontStyle.Bold);
                    btn.Text = "Detaylar";
                    btn.Name = str[sayac, 4];
                    grb.Controls.Add(btn);
                    btn.Click += btnClick;
                    sayac++;
                    if (kayitSayisi == ((i - 1) * 7) + j)
                    {
                        break;
                    } 
                }
            }
        }
        private void btnClick(object sender,EventArgs e)
        {
            Info.filmDurum = 0;
            Button btn = (sender as Button);
            frmDetaylar frm = new frmDetaylar();
            frm.ıd = btn.Name;
            this.Hide();
            frm.Show();
        }
        private void frmKutuphane_Load(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("select count(*) from Filmler", con);
            con.Open();
            kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar()) ;
            con.Close();
            OleDbCommand cmdTur = new OleDbCommand("select * from Tur ", con);
            con.Open();
            OleDbDataReader drTur = cmdTur.ExecuteReader();
            while (drTur.Read())
            {
                cmbTur.Items.Add(drTur["Adi"].ToString());
            }
            con.Close();
            if (kayitSayisi==0)
            {
                Label lbl = new Label();
                lbl.Top = 200;
                lbl.Left = 300;
                lbl.Width = 1000;
                lbl.ForeColor = Color.Aqua;
                lbl.BackColor = Color.Transparent;
                lbl.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lbl.Text = "Film Bulunamadı!";
                this.Controls.Add(lbl);
            }
            else
            {
                label8.Text = kayitSayisi + " adet.";
                OleDbCommand cmdsearch = new OleDbCommand("select * from Filmler", con);
                con.Open();
                OleDbDataReader dr = cmdsearch.ExecuteReader();

                str = new string[kayitSayisi, 5];
                for (int i = 0; dr.Read(); i++)
                {
                    str[i, 0] = dr["Adi"].ToString();
                    str[i, 1] = dr["Afis"].ToString();
                    str[i, 2] = dr["Fiyati"].ToString();
                    str[i, 3] = dr["Puan"].ToString();
                    str[i, 4] = dr["FilmID"].ToString();
                }
                con.Close();
                label8.Text = kayitSayisi + " adet film.";

                nudSayfa.Maximum = ((kayitSayisi - 1) / 12) + 1;
                nudSayfa.Minimum = 1;
                islemm((int)nudSayfa.Value);
            }
            lblBakiye.Text ="Bakiye : "+ Info.Bakiye+" ₺";
           
        }
        private void nudSayfa_ValueChanged(object sender, EventArgs e)
        {
            islemm((int)nudSayfa.Value);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbCommand cmdES = new OleDbCommand("select count(*) from (select distinct(Filmler.Adi) from Tur inner join (Filmler inner join TurFilm on Filmler.FilmID = TurFilm.FılmID) on Tur.TurID = TurFilm.TurID where (Filmler.Adi='" + txtAd.Text + "' or Tur.Adi='" + cmbTur.Text + "' or (Filmler.Puan between " + nudPuanMin.Value + " and " + nudPuanMax.Value + ") or (Filmler.Fiyati between " + txtFiyatMin.Text + " and " + txtFiyatMax.Text + ")))  as t;", con);
            con.Open();
            kayitSayisi = (int)cmdES.ExecuteScalar();
            
            con.Close();
            OleDbCommand cmd = new OleDbCommand("SELECT distinct Filmler.FilmID, Filmler.Adi, Filmler.Puan, Filmler.Fiyati, Fİlmler.Afis from Tur inner join (Filmler inner join TurFilm on Filmler.FilmID = TurFilm.FılmID) on Tur.TurID = TurFilm.TurID where Filmler.Adi='" + txtAd.Text+"' or Tur.Adi='"+cmbTur.Text+"' or (Filmler.Puan between "+nudPuanMin.Value+" and "+nudPuanMax.Value+") or (Filmler.Fiyati between "+txtFiyatMin.Text+" and "+txtFiyatMax.Text+") ", con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            str = new string[kayitSayisi, 5];
            for (int i = 0; dr.Read(); i++)
            {
                str[i, 4] = dr["FilmID"].ToString();
                str[i, 0] = dr["Adi"].ToString();
                str[i, 1] = dr["Afis"].ToString();
                str[i, 2] = dr["Fiyati"].ToString();
                str[i, 3] = dr["Puan"].ToString();
            }
            
            label8.Text = kayitSayisi + " adet film.";
            nudSayfa.Maximum = ((kayitSayisi-1) / 12) + 1;
            con.Close();
            islemm((int)nudSayfa.Value);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmProfil frm = new frmProfil();
            this.Hide();
            frm.Show();
        }

        private void btnKullanıcıKutuphane_Click(object sender, EventArgs e)
        {
            frmSatinAlinanlar frm = new frmSatinAlinanlar();
            this.Hide();
            frm.Show();
        }
    }
}
