
namespace Hastane_Proje
{
    partial class FrmBrans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrans));
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btadd = new System.Windows.Forms.Button();
            this.txdid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txdbransad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(21, 229);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(314, 47);
            this.btnupdate.TabIndex = 70;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(196, 176);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(139, 47);
            this.btnremove.TabIndex = 69;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(422, 277);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(21, 176);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(139, 47);
            this.btadd.TabIndex = 67;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // txdid
            // 
            this.txdid.Location = new System.Drawing.Point(149, 59);
            this.txdid.Name = "txdid";
            this.txdid.Size = new System.Drawing.Size(164, 33);
            this.txdid.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 26);
            this.label6.TabIndex = 63;
            this.label6.Text = "BransId";
            // 
            // txdbransad
            // 
            this.txdbransad.Location = new System.Drawing.Point(149, 98);
            this.txdbransad.Name = "txdbransad";
            this.txdbransad.Size = new System.Drawing.Size(164, 33);
            this.txdbransad.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 58;
            this.label3.Text = "BransName";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 42);
            this.button2.TabIndex = 71;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.txdid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txdbransad);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBrans";
            this.Text = "Brans";
            this.Load += new System.EventHandler(this.FrmBrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox txdid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txdbransad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}