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
    public partial class frmKullanicilarPanel : Form
    {
        public frmKullanicilarPanel()
        {
            InitializeComponent();
        }
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = FilmAy.accdb; Jet OLEDB:Database Password = film");
        void grid()
        {
            lvKullanicilar.Items.Clear();
            cmbID.Items.Clear();
            OleDbCommand cmd = new OleDbCommand("select * from Kullanicilar ", con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            string ID;
            while (dr.Read())
            {
                ID = dr["KullaniciID"].ToString();
                ListViewItem ıtem = new ListViewItem(ID);
                cmbID.Items.Add(ID);
                ıtem.SubItems.Add(dr["KullaniciAdi"].ToString());
                ıtem.SubItems.Add(dr["Adi"].ToString());
                ıtem.SubItems.Add(dr["Soyadi"].ToString());
                ıtem.SubItems.Add(dr["Sifre"].ToString());
                ıtem.SubItems.Add(dr["Yetki"].ToString());
                ıtem.SubItems.Add(dr["Bakiye"].ToString());

                lvKullanicilar.Items.Add(ıtem);
            }
            con.Close();

        }
        private void frmKullanicilarPanel_Load(object sender, EventArgs e)
        {
            grid();
        }

        private void btnGöster_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("select * from Kullanicilar where KullaniciID=" + cmbID.SelectedItem.ToString() +"",con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            dr.Read();
            txtKullaniciAdi.Text = dr["KullaniciAdi"].ToString();
            txtAd.Text = dr["Adi"].ToString();
            txtSoyadi.Text = dr["Soyadi"].ToString();
            txtSifre.Text = dr["Sifre"].ToString();
            nudYetki.Value = Convert.ToInt32(dr["Yetki"]);
            txtBakiye.Text = dr["Bakiye"].ToString();
            btnEkle.Enabled = false;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("insert into Kullanicilar(KullaniciAdi,Adi,Soyadi,Sifre,Yetki,Bakiye) values('" + txtKullaniciAdi.Text + "','" + txtAd.Text + "','" + txtSoyadi.Text + "','" + txtSifre.Text + "'," + nudYetki.Value + "," + txtBakiye.Text + ")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            grid();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("update Kullanicilar set KullaniciAdi='" + txtKullaniciAdi.Text + "',Adi='" + txtAd.Text + "',Soyadi='" + txtSoyadi.Text + "',Sifre='" + txtSifre.Text + "',Yetki=" + nudYetki.Value + ",Bakiye=" + txtBakiye.Text + " where KullaniciID="+cmbID.SelectedItem.ToString()+"", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            grid();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("delete * from Kullanicilar where KullaniciID=" + cmbID.SelectedItem.ToString() + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            grid();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtBakiye.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtSoyadi.Text = "";
            nudYetki.Value = 0;
            btnEkle.Enabled = true;

        }

        private void btnFilmler_Click(object sender, EventArgs e)
        {
            frmAdminPanel frm = new frmAdminPanel();
            this.Hide();
            frm.Show();
        }

        private void btnTurOyuncuPanel_Click(object sender, EventArgs e)
        {
            frmTurOyuncuPanel frm = new frmTurOyuncuPanel();
            this.Hide();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();

        }
    }
}
