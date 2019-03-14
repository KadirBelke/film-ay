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
    public partial class frmProfil : Form
    {
        public frmProfil()
        {
            InitializeComponent();
        }

        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = FilmAy.accdb; Jet OLEDB:Database Password = film");
        private void frmProfil_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = "Bakiye : " + Info.Bakiye+" ₺";
            lblKullaniciAdi.Text = Info.KullaniciAdi;
            lblAd.Text = Info.Ad;
            lblSoyad.Text = Info.soyad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKutuphane frm = new frmKutuphane();
            this.Hide();
            frm.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (Info.sifre==txtSifre.Text)
            {
                OleDbCommand cmd = new OleDbCommand("update Kullanicilar set sifre='" + txtYeniSifre.Text + "' where KullaniciID="+Info.KullaniciId+"", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Şifre Değiştirildi");
            }

        }

        private void btnFiyatEkle_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("update KulLanicilar set Bakiye=" + (Info.Bakiye + Convert.ToInt32(txtFiyat.Text)) + " where KullaniciID="+Info.KullaniciId+ "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            OleDbCommand cmdSorgu = new OleDbCommand("select Bakiye from Kullanicilar where KullaniciID=" + Info.KullaniciId + "", con);
            con.Open();
            Info.Bakiye =Convert.ToDouble(cmdSorgu.ExecuteScalar());
            con.Close();
            lblBakiye.Text = "Bakiye : " + Info.Bakiye+" ₺";

        }
    }
}
