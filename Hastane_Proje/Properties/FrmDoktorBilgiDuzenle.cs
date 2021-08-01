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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tc;
        sqlconnection bgl = new sqlconnection();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = tc;
            SqlCommand komut = new SqlCommand(" Select * From Doctor_Tbl where DoctorTc=@a1", bgl.connection());
            komut.Parameters.AddWithValue("a1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txdad.Text = dr[1].ToString();
                txdsoyad.Text = dr[2].ToString();
                cmbbrans.Text = dr[3].ToString();
                mskTc.Text = dr[4].ToString();
                txdpassword.Text = dr[5].ToString();
            }
            bgl.connection().Close();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Doctor_TBL set DoctorAd=@p1,DoctorSoyad=@p2,DoctorBrans=@p3,DoctorSifre=@p4 where DoctorTc=@p5", bgl.connection());
            komut2.Parameters.AddWithValue("@p1", txdad.Text);
            komut2.Parameters.AddWithValue("@p2", txdsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut2.Parameters.AddWithValue("@p4", txdpassword.Text);
            komut2.Parameters.AddWithValue("@p5", mskTc.Text);
            komut2.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Update is ready");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDoktorDetay fr = new FrmDoktorDetay();
            fr.Show();
            this.Hide();
        }
    }
}
