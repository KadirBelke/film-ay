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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text==""||txtSifre.Text=="")
            {
                MessageBox.Show("Alanlar boş olmamalıdır!");
            }
            else
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = FilmAy.accdb; Jet OLEDB:Database Password = film");
                OleDbCommand cmd = new OleDbCommand("select * from Kullanicilar where KullaniciAdi='" + txtKullaniciAdi.Text + "' and Sifre='" + txtSifre.Text + "'", con);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Info.KullaniciId = dr["KullaniciID"].ToString() ;
                    Info.KullaniciAdi=dr["KullaniciAdi"].ToString();
                    Info.Ad = dr["Adi"].ToString();
                    Info.soyad = dr["Soyadi"].ToString();
                    Info.sifre = dr["Sifre"].ToString();
                    Info.Bakiye = Convert.ToInt32(dr["Bakiye"]);

                    if ((int)dr["Yetki"]==1)
                    {
                        frmAdminPanel frm = new frmAdminPanel();
                        this.Hide();
                        frm.Show();
                    }
                    else
                    {
                        frmKutuphane frm1 = new frmKutuphane();
                        this.Hide();
                        frm1.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
                }
            }
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            frmKaydol frm = new frmKaydol();
            this.Hide();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
