using System;
using System.Collections.Generic;
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
    public partial class frmDetaylar : Form
    {
        public frmDetaylar()
        {
            InitializeComponent();
        }
        public string ad { get; set; }
        public string afis { get; set; }
        public string ıd { get; set; }
        public string filmID;
        public double fiyat;
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = FilmAy.accdb; Jet OLEDB:Database Password = film");
        private void frmKullanici_Load(object sender, EventArgs e)
        {
            if (Info.filmDurum==0)
            {
                btnFilm.Enabled = false;
                
            }
            else
            {
                btnSatinAl.Visible = false;
            }
            
            mpFilm.Visible = false;
            OleDbCommand cmd = new OleDbCommand("select * from Filmler where FilmID="+ıd+"",con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            dr.Read();
            filmID = dr["FilmID"].ToString();
            pictureBox1.Image = Image.FromFile(dr["Afis"].ToString());
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            lblAd.Text = dr["Adi"].ToString();
            mpFilm.URL = dr["Film"].ToString();
            mpFragman.URL = dr["Fragman"].ToString();
            lblPuan.Text = "Paun : "+  dr["Puan"].ToString();
            lblAciklama.Text ="Acıklama : "+ dr["Aciklama"].ToString();
            fiyat = Convert.ToDouble(dr["Fiyati"]);
            lblFiyati.Text ="Fiyati : "+fiyat.ToString();
            con.Close();
            OleDbCommand cmdOyuncu = new OleDbCommand("select Oyuncular.Adi,Oyuncular.Soyadi from Oyuncular inner join OyuncuFilm on Oyuncular.OyuncuID = OyuncuFilm.OyuncuID where OyuncuFilm.FilmID =" + ıd + "", con);
            con.Open();
            OleDbDataReader drOyuncu = cmdOyuncu.ExecuteReader();
            lblOyuncular.Text = "Oyuncular : ";
            drOyuncu.Read();
            lblOyuncular.Text += drOyuncu["Adi"] + " " + drOyuncu["Soyadi"];
            while (drOyuncu.Read())
            {
                lblOyuncular.Text += "," +drOyuncu["Adi"]+" "+drOyuncu["Soyadi"];
            }
            con.Close();
            OleDbCommand cmdTur = new OleDbCommand("select Tur.Adi from Tur inner join TurFilm on Tur.TurID = TurFilm.TurID where TurFilm.FılmID ="+ıd+"",con);
            con.Open();
            OleDbDataReader drTur = cmdTur.ExecuteReader();
            lblTur.Text = "Tür : ";
            drTur.Read();
            lblTur.Text +=drTur["Adi"].ToString() + " ";
            while (drTur.Read())
            {
                lblTur.Text += "," + drTur["Adi"].ToString() + " ";
            }
            con.Close();
            mpFilm.Ctlcontrols.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKutuphane frm = new frmKutuphane();
            this.Close();
            frm.Show();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            bool kontrol = true;
            OleDbCommand cmdKontrol = new OleDbCommand("select FilmID from Kutuphane where KullaniciID=" + Info.KullaniciId + "", con);
            con.Open();
            OleDbDataReader dr = cmdKontrol.ExecuteReader();
            while (dr.Read())
            {
                if (dr["FilmID"].ToString()==filmID)
                {
                    kontrol = false;
                }
            }
            con.Close();
            OleDbCommand cmdTutar = new OleDbCommand("selec Fiyati from Filmler where ");
            if (kontrol)
            {
                if (Info.Bakiye>=fiyat)
                {
                    OleDbCommand cmd = new OleDbCommand("insert into Kutuphane(KullaniciID,FilmId) values(" + Info.KullaniciId + "," + filmID + ")", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Info.Bakiye -= fiyat;
                    OleDbCommand cmdGuncelBakiye = new OleDbCommand("update Kullanicilar set Bakiye=" + Info.Bakiye + " where KullaniciID=" + Info.KullaniciId + "", con);
                    con.Open();
                    cmdGuncelBakiye.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Eksik Bakiye");
                }
                
            }
            else
            {
                MessageBox.Show("Film zaten satın alınmış!");
            }

            
            
        }

        private void btnFragman_Click(object sender, EventArgs e)
        {
            mpFilm.Hide();
            mpFilm.Ctlcontrols.stop();
            mpFragman.Show();
            mpFragman.Ctlcontrols.play();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            mpFragman.Hide();
            mpFragman.Ctlcontrols.stop();
            mpFilm.Show();
            mpFilm.Ctlcontrols.play();
        }
        
    }
}
