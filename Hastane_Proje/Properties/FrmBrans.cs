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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {

            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();

        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Select * From TBL_Brans ", bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


     }

        private void btadd_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_Brans(BransAd) values (@b1)", bgl.connection());
            komut.Parameters.AddWithValue("@b1", txdbransad.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Done", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txdid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txdbransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
           
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_Brans where BransId=@p1", bgl.connection());
            komut.Parameters.AddWithValue("@p1", txdid.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Done", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_Brans set BransAd=@p2 where bransid=@p1", bgl.connection());
            komut.Parameters.AddWithValue("@p1", txdid.Text);
            komut.Parameters.AddWithValue("@p2", txdbransad.Text);
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
