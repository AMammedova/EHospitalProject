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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tcno;
        sqlconnection bgl = new sqlconnection();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = tcno;
            SqlCommand komut = new SqlCommand(" Select * From Hastalar_Tbl where HastaTc=@a1",bgl.connection());
            komut.Parameters.AddWithValue("a1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txdad.Text = dr[0].ToString();
                txdsoyad.Text = dr[1].ToString();
                mskPhone.Text = dr[3].ToString();
                txdpassword.Text = dr[4].ToString();
                cmbgender.Text = dr[5].ToString();
            }
            bgl.connection().Close();
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Hastalar_TBL set HastaAd=@p1,HastaSoyad=@p2,HastaTel=@p3,HastaSifre=@p4,HastaCinsiyyet=@p5 where HastaTc=@p6", bgl.connection());
            komut2.Parameters.AddWithValue("@p1", txdad.Text);
            komut2.Parameters.AddWithValue("@p2", txdsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskPhone.Text);
            komut2.Parameters.AddWithValue("@p4", txdpassword.Text);
            komut2.Parameters.AddWithValue("@p5", cmbgender.Text);
            komut2.Parameters.AddWithValue("@p6", mskTc.Text);
            komut2.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Update is ready");
        }

       
    }
}
