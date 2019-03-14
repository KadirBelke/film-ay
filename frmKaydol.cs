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
    public partial class frmKaydol : Form
    {
        public frmKaydol()
        {
            InitializeComponent();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            if (txtAd.Text==""||txtKullaniciAdi.Text==""||txtSifre.Text==""||txtSoyad.Text=="")
            {
                MessageBox.Show("Alanlar boş olmamalıdır!");
            }
            else
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = FilmAy.accdb; Jet OLEDB:Database Password = film");
                OleDbCommand cmd = new OleDbCommand("select * from Kullanicilar where KullaniciAdi='" + txtKullaniciAdi.Text + "'", con);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Bu Kullanıcı Adı Kullanılmakta!\nLütfen başka bir kullanıcı adı deneyiniz.");
                    txtKullaniciAdi.Text = "";
                }
                else
                {
                    con.Close();
                    OleDbCommand cmdIns = new OleDbCommand("insert into Kullanicilar(KullaniciAdi,Adi,Soyadi,Sifre) values ('" + txtKullaniciAdi.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtSifre.Text + "')", con);
                    con.Open();
                    cmdIns.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kayıt Başarılı");
                    txtAd.Text = "";
                    txtKullaniciAdi.Text = "";
                    txtSifre.Text = "";
                    txtSoyad.Text = "";
                }
            }
           
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();

        }
    }
}
