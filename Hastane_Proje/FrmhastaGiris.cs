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
    public partial class FrmhastaGiris : Form
    {
        public FrmhastaGiris()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" Select * From Hastalar_TBL where HastaTc=@p1 and HastaSifre=@p2",bgl.connection());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = maskedTextBox1.Text;
                fr.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Incorrect entry");
            }
            bgl.connection().Close();
             
        }

        private void FrmhastaGiris_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
