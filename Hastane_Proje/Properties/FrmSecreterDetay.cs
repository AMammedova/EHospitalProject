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
    public partial class FrmSecreterDetay : Form
    {
        public FrmSecreterDetay()
        {
            InitializeComponent();
        }
        public string tc;

        sqlconnection bgl = new sqlconnection();
        private void FrmSecreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            SqlCommand komut = new SqlCommand("Select SecreterAdSoyad From Secreter_TBL where SecreterTc=@p1",bgl.connection());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString();
            }
            bgl.connection().Close();
            //brans datagrid
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Select * From TBL_Brans", bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //doctor
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select ( DoctorAd + ' ' + DoctorSoyad) as 'Doctors' , DoctorBrans From Doctor_TBL", bgl.connection());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;


            SqlCommand komut2 = new SqlCommand("Select BransAd From TBL_Brans ", bgl.connection());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.connection().Close();

           

        }
        //bransi aktarma

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert TBL_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoctor) values (@r1,@r2,@r3,@r4)", bgl.connection());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbdoctor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Done");
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoctor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select ( DoctorAd + ' ' + DoctorSoyad) From Doctor_TBL where DoctorBrans=@t1", bgl.connection());
            komut3.Parameters.AddWithValue("@t1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoctor.Items.Add(dr3[0]);
            }

            bgl.connection().Close();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" Insert into TBL_Duyuru (duyuru) values (@r1)", bgl.connection());
            komut.Parameters.AddWithValue("@r1", rchduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Done");
        }

        private void btndoctor_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();
            fr.Show();
            this.Hide();
            
        }

        private void btnbrans_Click(object sender, EventArgs e)
        {
            FrmBrans fr = new FrmBrans();
            fr.Show();
            this.Hide();
           
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();
           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris fr = new FrmSekreterGiris();
            fr.Show();
            this.Hide();
        }
    }
}
