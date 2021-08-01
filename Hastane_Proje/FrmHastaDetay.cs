using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hastane_Proje
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlconnection bgl = new sqlconnection();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RchSikayet_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Hastalar_TBL where HastaTc=@p1",bgl.connection());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label3.Text =dr[0] + " " +dr[1];

            }
            bgl.connection().Close();
            //Randevo history
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Select * From TBL_Randevular where HastaTc="+tc,bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource=dt;

            //branslari cekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From TBL_Brans",bgl.connection());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.connection().Close();


        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoctor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoctorAd,DoctorSoyad From Doctor_TBL where DoctorBrans=@p1", bgl.connection());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.connection().Close();
        }

        private void cmbdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_Randevular where RandevuBrans='"+cmbbrans.Text+"'",bgl.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.tcno = lbltc.Text;
            fr.Show();
            

        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_Randevular set RandevuDurum=1,HastaTc=@p1,HastaSikayet=@p2 where RandevuId=@p3", bgl.connection());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            komut.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();

            MessageBox.Show("Done", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmhastaGiris fr = new FrmhastaGiris();
            fr.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
