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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Doctor_TBL", bgl.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            SqlCommand komut2 = new SqlCommand("Select BransAd From TBL_Brans ", bgl.connection());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.connection().Close();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" Insert into Doctor_TBL (DoctorAd,DoctorSoyad,DoctorBrans,DoctorTc,DoctorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.connection());
            komut.Parameters.AddWithValue("@p1", txdad.Text);
            komut.Parameters.AddWithValue("@p2", txdsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4", mskTc.Text);
            komut.Parameters.AddWithValue("@p5", txdpassword.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Done"," ", MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txdad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txdsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txdpassword.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" Delete From Doctor_TBL where DoctorTc=@p1", bgl.connection());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Items are deleted", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" Update Doctor_TBL set DoctorAd=@p1,DoctorSoyad=@p2,DoctorBrans=@p3,DoctorSifre=@p5 where DoctorTc=@p4", bgl.connection());
            komut.Parameters.AddWithValue("@p1", txdad.Text);
            komut.Parameters.AddWithValue("@p2", txdsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4", mskTc.Text);
            komut.Parameters.AddWithValue("@p5", txdpassword.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Done", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSecreterDetay fr = new FrmSecreterDetay();
            fr.Show();
            this.Hide();
        }
    }
}
