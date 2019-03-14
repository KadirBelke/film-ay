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
    public partial class frmTurOyuncuPanel : Form
    {
        public frmTurOyuncuPanel()
        {
            InitializeComponent();
        }
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = FilmAy.accdb; Jet OLEDB:Database Password = film");
        void grid()
        {
            lvOyuncu.Items.Clear();
            lvTur.Items.Clear();
            cmbOID.Items.Clear();
            cmbTID.Items.Clear();
            OleDbCommand cmd = new OleDbCommand("select * from Tur", con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            string ID;
            while (dr.Read())
            {
                ID = dr["TurID"].ToString();
                ListViewItem ıtem = new ListViewItem(ID);
                cmbTID.Items.Add(ID);
                ıtem.SubItems.Add(dr["Adi"].ToString());
                lvTur.Items.Add(ıtem);
            }
            con.Close();
            OleDbCommand cmdO = new OleDbCommand("select * from Oyuncular", con);
            con.Open();
            OleDbDataReader drO = cmdO.ExecuteReader();
            while (drO.Read())
            {
                ID = drO["OyuncuID"].ToString();
                ListViewItem ıtem = new ListViewItem(ID);
                cmbOID.Items.Add(ID);
                ıtem.SubItems.Add(drO["Adi"].ToString());
                ıtem.SubItems.Add(drO["Soyadi"].ToString());
                ıtem.SubItems.Add(drO["Yasi"].ToString());
                lvOyuncu.Items.Add(ıtem);
            }
            con.Close();

        }
        private void frmTurOyuncuPanel_Load(object sender, EventArgs e)
        {
            grid();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("select * from Tur where TurID=" + cmbTID.SelectedItem.ToString() + "", con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            dr.Read();
            txtTAdi.Text = dr["Adi"].ToString();
            con.Close();
            btnEkle.Enabled = false;
        }

        private void btnOGoster_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("select * from Oyuncular where OyuncuID=" + cmbOID.SelectedItem.ToString() + "", con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            dr.Read();
            txtOAdi.Text = dr["Adi"].ToString();
            txtOSoyadi.Text = dr["Soyadi"].ToString();
            txtOYasi.Text = dr["Yasi"].ToString();
            con.Close();
            btnOEkle.Enabled = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("insert into Tur(Adi) values('" + txtTAdi.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            grid();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("update Tur set Adi='" + txtTAdi.Text + "' where TurID=" + cmbTID.SelectedItem.ToString() + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            grid();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("delete * from Tur  where TurID=" + cmbTID.SelectedItem.ToString() + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            grid();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTAdi.Text = "";
            btnEkle.Enabled = true;
        }

        private void btnOEkle_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("insert into Oyuncular(Adi,Soyadi,Yasi) values('" + txtOAdi.Text + "','" + txtOSoyadi.Text + "','" + txtOYasi.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            grid();
        }

        private void btnOGuncelle_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("update Oyuncular set Adi='" + txtOAdi.Text + "',Soyadi='" + txtOSoyadi.Text + "',Yasi='" + txtOYasi.Text + "' where OyuncuID=" + cmbOID.SelectedItem.ToString() + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            grid();
        }

        private void btnOSil_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("delete * from Oyuncular where OyuncuID=" + cmbOID.SelectedItem.ToString() + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            grid();

        }

        private void btnOTemizli_Click(object sender, EventArgs e)
        {
            txtOAdi.Text = "";
            txtOSoyadi.Text = "";
            txtOYasi.Text = "";
            btnOEkle.Enabled = true;
        }

       

        private void btnFilmler_Click(object sender, EventArgs e)
        {
            frmAdminPanel frm = new frmAdminPanel();
            this.Hide();
            frm.Show();
        }

        private void btnKulanicilar_Click(object sender, EventArgs e)
        {
            frmKullanicilarPanel frm = new frmKullanicilarPanel();
            this.Hide();
            frm.Show(); 
        }
    }
}
