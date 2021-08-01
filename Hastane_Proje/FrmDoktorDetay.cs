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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public string tc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            //doctor ad
            SqlCommand komut = new SqlCommand("Select Doctorad ,DoctorSoyad From Doctor_TBL where DoctorTc=@p1", bgl.connection());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];

            }
            bgl.connection().Close();
            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_Randevular where RandevuDoctor='" + lbladsoyad.Text + "'", bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.tc = lbltc.Text;
            fr.Show();
            this.Hide();
            
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
            
            
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDoctorGiris fr = new FrmDoctorGiris();
            fr.Show();
            this.Hide();
        }
    }
}
