
using System;

namespace Hastane_Proje
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.btnsign = new System.Windows.Forms.Button();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.txdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txdpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txdsoyad = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsign
            // 
            this.btnsign.BackColor = System.Drawing.Color.CadetBlue;
            this.btnsign.Location = new System.Drawing.Point(137, 345);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(145, 60);
            this.btnsign.TabIndex = 32;
            this.btnsign.Text = "Update";
            this.btnsign.UseVisualStyleBackColor = false;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Location = new System.Drawing.Point(161, 289);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(164, 34);
            this.cmbgender.TabIndex = 6;
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(161, 182);
            this.mskPhone.Mask = "000-000-00-00";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(164, 33);
            this.mskPhone.TabIndex = 4;
            // 
            // txdad
            // 
            this.txdad.Location = new System.Drawing.Point(161, 30);
            this.txdad.Name = "txdad";
            this.txdad.Size = new System.Drawing.Size(164, 33);
            this.txdad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 28;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 27;
            this.label5.Text = "Gender";
            // 
            // txdpassword
            // 
            this.txdpassword.Location = new System.Drawing.Point(161, 238);
            this.txdpassword.Name = "txdpassword";
            this.txdpassword.Size = new System.Drawing.Size(164, 33);
            this.txdpassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Phone";
            // 
            // txdsoyad
            // 
            this.txdsoyad.Location = new System.Drawing.Point(161, 69);
            this.txdsoyad.Name = "txdsoyad";
            this.txdsoyad.Size = new System.Drawing.Size(164, 33);
            this.txdsoyad.TabIndex = 2;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(161, 124);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(164, 33);
            this.mskTc.TabIndex = 3;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "SurName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "TCNo";
            // 
            // FrmBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.btnsign);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.mskPhone);
            this.Controls.Add(this.txdad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txdpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txdsoyad);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "InfoUpdate";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnsign;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.TextBox txdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txdpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txdsoyad;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}