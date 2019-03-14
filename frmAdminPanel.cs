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
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();
        }
        
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = FilmAy.accdb; Jet OLEDB:Database Password = film");
        string ıd;
        List<string> turAdi=new List<string>();
        List<int> turID=new List<int>();
        List<string> oyuncuAdi = new List<string>();
        List<int> oyuncuID = new List<int>();
        void grid()
        {
            lvfilmler.Items.Clear();
            cmbID.Items.Clear();
            
            OleDbCommand cmdfilmler = new OleDbCommand("select * from Filmler", con);
            con.Open();
            OleDbDataReader dr = cmdfilmler.ExecuteReader();
            string ID;
            while (dr.Read())
            {
                ID = dr["FilmID"].ToString();
                ListViewItem item = new ListViewItem(ID);
                cmbID.Items.Add(ID);
                item.SubItems.Add(dr["Adi"].ToString());
                item.SubItems.Add(dr["Fiyati"].ToString());
                item.SubItems.Add(dr["Puan"].ToString());
                item.SubItems.Add(dr["Aciklama"].ToString());
                item.SubItems.Add(dr["Afis"].ToString());
                item.SubItems.Add(dr["Fragman"].ToString());
                item.SubItems.Add(dr["film"].ToString());
                lvfilmler.Items.Add(item);
            }
            con.Close();

        }
    
        private void frmAdminPanel_Load(object sender, EventArgs e)
        {
            OleDbCommand cmdTur = new OleDbCommand("select * from Tur ", con);
            con.Open();
            OleDbDataReader drTur = cmdTur.ExecuteReader();
            while (drTur.Read())
            {
                clbTur.Items.Add(drTur["Adi"].ToString());
                turAdi.Add(drTur["Adi"].ToString());
                turID.Add(Convert.ToInt32(drTur["TurID"]));
            }
            con.Close();
            OleDbCommand cmdOyuncu = new OleDbCommand("select * from Oyuncular ", con);
            con.Open();
            OleDbDataReader drOyuncu = cmdOyuncu.ExecuteReader();
            string adSoyad;
            while (drOyuncu.Read())
            {
                adSoyad = drOyuncu["Adi"] + " " + drOyuncu["Soyadi"];
                clbOyuncular.Items.Add(adSoyad);
                oyuncuAdi.Add(adSoyad);
                oyuncuID.Add(Convert.ToInt32(drOyuncu["OyuncuID"]));
            }
            con.Close();
            grid();
        }
        private void btnAfis_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            txtAfis.Text = dosyayolu;
        }

        private void btnFragman_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Video Dosyası |*.mp4;*.MP4 |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            txtFragman.Text = dosyayolu;
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Video Dosyası |*.mp4;*.MP4 |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            txtFilm.Text = dosyayolu;
        }

        private void btnGöster_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbOyuncular.Items.Count; i++)
            {
                clbOyuncular.SetItemChecked(i, false);
            }
            for (int i = 0; i < clbTur.Items.Count; i++)
            {
                clbTur.SetItemChecked(i, false);
            }
            OleDbCommand cmd = new OleDbCommand("select * from Filmler where FilmID="+cmbID.SelectedItem.ToString()+"",con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            dr.Read();
            txtAd.Text = dr["Adi"].ToString();
            txtAciklama.Text = dr["Aciklama"].ToString();
            txtAfis.Text = dr["Afis"].ToString();
            txtFilm.Text = dr["Film"].ToString();
            txtFiyat.Text = dr["Fiyati"].ToString();
            txtFragman.Text = dr["Fragman"].ToString();
            txtPuan.Text = dr["Puan"].ToString();
            con.Close();
            OleDbCommand cmdTur = new OleDbCommand("select Tur.Adi from Tur inner join TurFilm on Tur.TurID = TurFilm.TurID where TurFilm.FılmID = "+cmbID.SelectedItem.ToString()+"", con);
            con.Open();
            OleDbDataReader drTur = cmdTur.ExecuteReader();
            while (drTur.Read())
            {
                for (int i = 0; i < turID.Count; i++)
                {
                    if (drTur[0].ToString()==turAdi[i])
                    {
                        clbTur.SetItemChecked(i,true);
                    }
                }
                
            }
            con.Close();
            OleDbCommand cmdOyuncu = new OleDbCommand("select Oyuncular.Adi,Oyuncular.Soyadi from Oyuncular inner join OyuncuFilm on Oyuncular.OyuncuID=OyuncuFilm.OyuncuID where OyuncuFilm.FilmID=" + cmbID.SelectedItem.ToString() + "", con);
            con.Open();
            OleDbDataReader drOyuncu = cmdOyuncu.ExecuteReader();
            while (drOyuncu.Read())
            {
                for (int i = 0; i < oyuncuID.Count; i++)
                {
                    if (drOyuncu[0]+" "+drOyuncu[1]==oyuncuAdi[i])
                    {
                        clbOyuncular.SetItemChecked(i, true);
                    }
                }
            }
            con.Close();
            btnEkle.Enabled = false;
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string[] afis=txtAfis.Text.Split('\\');
            string[] fragman = txtFragman.Text.Split('\\');
            string[] film=txtFilm.Text.Split('\\');
            OleDbCommand cmdInsert = new OleDbCommand("insert into Filmler(Adi,Fiyati,Puan,Aciklama,Afis,Fragman,Film) values('" + txtAd.Text + "',@Fiyat,@Paun,@Aciklama,@Afis,@Fragman,@Film)", con);
            con.Open();
            cmdInsert.Parameters.AddWithValue("@Fiyat", Convert.ToDouble(txtFiyat.Text));
            cmdInsert.Parameters.AddWithValue("@Paun", Convert.ToDouble(txtPuan.Text));
            cmdInsert.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
            cmdInsert.Parameters.AddWithValue("@Afis", afis[afis.Length - 2] + "\\" + afis[afis.Length - 1]);
            cmdInsert.Parameters.AddWithValue("@Fragman", fragman[fragman.Length - 2] + "\\" + fragman[fragman.Length - 1]);
            cmdInsert.Parameters.AddWithValue("@Film", film[film.Length - 2] + "\\" + film[film.Length - 1]);
            cmdInsert.ExecuteNonQuery();
            con.Close();
            OleDbCommand cmd = new OleDbCommand("select max(FilmID) from Filmler", con);
            con.Open();
            string ıd = cmd.ExecuteScalar().ToString();
            con.Close();
            foreach (object item in clbTur.CheckedItems)
            {
                for (int i = 0; i < turAdi.Count; i++)
                {
                    if (turAdi[i] == item)
                    {
                        OleDbCommand cmdInsetTur = new OleDbCommand("insert into TurFilm(FılmID,TurID) values(" + ıd + "," + turID[i] + ")", con);
                        con.Open();
                        cmdInsetTur.ExecuteNonQuery();
                        con.Close();
                    }
                }

            }
            foreach (object item in clbOyuncular.CheckedItems)
            {
                for (int i = 0; i < oyuncuAdi.Count; i++)
                {
                    if (oyuncuAdi[i] == item)
                    {
                        OleDbCommand cmdInsertOyuncular = new OleDbCommand("insert into OyuncuFilm(FilmID,OyuncuID) values(" + ıd + "," + oyuncuID[i] + ")", con);
                        con.Open();
                        cmdInsertOyuncular.ExecuteNonQuery();
                        con.Close();
                    }
                }

            }
            grid();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAciklama.Text = "";
            txtAd.Text = "";
            txtAfis.Text = "";
            txtFilm.Text = "";
            txtFiyat.Text = "";
            txtFragman.Text = "";
            txtPuan.Text = "";
            for (int i = 0; i < clbOyuncular.Items.Count; i++)
            {
                clbOyuncular.SetItemChecked(i, false);
            }
            for (int i = 0; i < clbTur.Items.Count; i++)
            {
                clbTur.SetItemChecked(i, false);
            }
            btnEkle.Enabled = true;
        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string[] afis = txtAfis.Text.Split('\\');
            string[] fragman = txtFragman.Text.Split('\\');
            string[] film = txtFilm.Text.Split('\\');
            OleDbCommand cmd = new OleDbCommand("update Filmler set Adi='"+txtAd.Text+ "',Fiyati=@Fiyat,Puan=@Paun,Aciklama= @Aciklama, Afis=@Afis,Fragman=@Fragman,Film=@Film where FilmID="+cmbID.SelectedItem.ToString()+"", con);
            cmd.Parameters.AddWithValue("@Fiyat", Convert.ToDouble(txtFiyat.Text));
            cmd.Parameters.AddWithValue("@Paun", Convert.ToDouble(txtPuan.Text));
            cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@Afis", afis[afis.Length - 2] + "\\" + afis[afis.Length - 1]);
            cmd.Parameters.AddWithValue("@Fragman", fragman[fragman.Length - 2] + "\\" + fragman[fragman.Length - 1]);
            cmd.Parameters.AddWithValue("@Film", film[film.Length - 2] + "\\" + film[film.Length - 1]);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            OleDbCommand cmdd = new OleDbCommand("delete * from TurFilm where FılmID=" + cmbID.SelectedItem.ToString() + "", con);
            con.Open();
            cmdd.ExecuteNonQuery();
            con.Close();
            OleDbCommand cmddd = new OleDbCommand("delete * from OyuncuFilm where FilmID=" + cmbID.SelectedItem.ToString() + "", con);
            con.Open();
            cmddd.ExecuteNonQuery();
            con.Close();
            foreach (object item in clbTur.CheckedItems)
            {
                for (int i = 0; i < turAdi.Count; i++)
                {
                    if (turAdi[i] == item)
                    {
                        OleDbCommand cmdInsetTur = new OleDbCommand("insert into TurFilm(FılmID,TurID) values(" + cmbID.SelectedItem.ToString() + "," + turID[i] + ")", con);
                        con.Open();
                        cmdInsetTur.ExecuteNonQuery();
                        con.Close();
                    }
                }

            }
            foreach (object item in clbOyuncular.CheckedItems)
            {
                for (int i = 0; i < oyuncuAdi.Count; i++)
                {
                    if (oyuncuAdi[i] == item)
                    {
                        OleDbCommand cmdInsertOyuncular = new OleDbCommand("insert into OyuncuFilm(FilmID,OyuncuID) values(" + cmbID.SelectedItem.ToString() + "," + oyuncuID[i] + ")", con);
                        con.Open();
                        cmdInsertOyuncular.ExecuteNonQuery();
                        con.Close();
                    }
                }

            }
            grid();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("delete * from Filmler where FilmID=" + cmbID.SelectedItem.ToString() + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            OleDbCommand cmdd = new OleDbCommand("delete * from TurFilm where FılmID=" + cmbID.SelectedItem.ToString() + "", con);
            con.Open();
            cmdd.ExecuteNonQuery();
            con.Close();
            OleDbCommand cmddd = new OleDbCommand("delete * from OyuncuFilm where FilmID=" + cmbID.SelectedItem.ToString() + "", con);
            con.Open();
            cmddd.ExecuteNonQuery();
            con.Close();
            grid();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void btnKullanacilar_Click(object sender, EventArgs e)
        {
            frmKullanicilarPanel frm = new frmKullanicilarPanel();
            this.Hide();
            frm.Show();
        }

        private void btnTVO_Click(object sender, EventArgs e)
        {
            frmTurOyuncuPanel frm = new frmTurOyuncuPanel();
            this.Hide();
            frm.Show();
        }
    }
}
