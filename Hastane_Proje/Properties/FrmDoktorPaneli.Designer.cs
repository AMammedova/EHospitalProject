
using System;

namespace Hastane_Proje
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            this.btadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.txdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txdpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txdsoyad = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(23, 322);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(139, 47);
            this.btadd.TabIndex = 53;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 52;
            this.label1.Text = "Brans";
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.ItemHeight = 26;
            this.cmbbrans.Location = new System.Drawing.Point(159, 186);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(163, 34);
            this.cmbbrans.TabIndex = 51;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // txdad
            // 
            this.txdad.Location = new System.Drawing.Point(159, 38);
            this.txdad.Name = "txdad";
            this.txdad.Size = new System.Drawing.Size(164, 33);
            this.txdad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 49;
            this.label6.Text = "Name";
            // 
            // txdpassword
            // 
            this.txdpassword.Location = new System.Drawing.Point(159, 246);
            this.txdpassword.Name = "txdpassword";
            this.txdpassword.Size = new System.Drawing.Size(164, 33);
            this.txdpassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 47;
            this.label4.Text = "Password";
            // 
            // txdsoyad
            // 
            this.txdsoyad.Location = new System.Drawing.Point(159, 77);
            this.txdsoyad.Name = "txdsoyad";
            this.txdsoyad.Size = new System.Drawing.Size(164, 33);
            this.txdsoyad.TabIndex = 2;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(159, 132);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(164, 33);
            this.mskTc.TabIndex = 3;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 44;
            this.label3.Text = "SurName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 43;
            this.label2.Text = "TCNo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(359, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(922, 277);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(198, 322);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(139, 47);
            this.btnremove.TabIndex = 55;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(23, 375);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(314, 47);
            this.btnupdate.TabIndex = 56;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1063, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 42);
            this.button2.TabIndex = 57;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1281, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.txdad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txdpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txdsoyad);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoktorPaneli";
            this.Text = "Doctor`s Panel";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.TextBox txdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txdpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txdsoyad;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button2;
    }
}