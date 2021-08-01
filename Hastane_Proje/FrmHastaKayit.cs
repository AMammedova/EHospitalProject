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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();
        private void btnsign_Click(object sender, EventArgs e)
        {
             SqlCommand komut = new SqlCommand("Insert into Hastalar_TBL(HastaAd,HastaSoyad,HastaTc,HastaTel,HastaSifre,HastaCinsiyyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.connection());
            komut.Parameters.AddWithValue("@p1", txdad.Text);
            komut.Parameters.AddWithValue("@p2", txdsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTc.Text);
            komut.Parameters.AddWithValue("@p4", mskPhone.Text);
            komut.Parameters.AddWithValue("@p5", txdpassword.Text);
            komut.Parameters.AddWithValue("@p6", cmbgender.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Your registration is complete" + txdpassword.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FrmHastaKayit_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmhastaGiris fr = new FrmhastaGiris();
            fr.Show();
            this.Hide();
        }
    }
}
