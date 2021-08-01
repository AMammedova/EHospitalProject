
namespace Hastane_Proje
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.txdsoyad = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txdpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.btnsign = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txdsoyad
            // 
            this.txdsoyad.Location = new System.Drawing.Point(167, 102);
            this.txdsoyad.Name = "txdsoyad";
            this.txdsoyad.Size = new System.Drawing.Size(164, 33);
            this.txdsoyad.TabIndex = 2;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(167, 157);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(164, 33);
            this.mskTc.TabIndex = 3;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "SurName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "TCNo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Phone";
            // 
            // txdpassword
            // 
            this.txdpassword.Location = new System.Drawing.Point(167, 271);
            this.txdpassword.Name = "txdpassword";
            this.txdpassword.Size = new System.Drawing.Size(164, 33);
            this.txdpassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender";
            // 
            // txdad
            // 
            this.txdad.Location = new System.Drawing.Point(167, 63);
            this.txdad.Name = "txdad";
            this.txdad.Size = new System.Drawing.Size(164, 33);
            this.txdad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Name";
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(167, 215);
            this.mskPhone.Mask = "000-000-00-00";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(164, 33);
            this.mskPhone.TabIndex = 4;
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Man",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(167, 322);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(164, 34);
            this.cmbgender.TabIndex = 6;
            // 
            // btnsign
            // 
            this.btnsign.BackColor = System.Drawing.Color.CadetBlue;
            this.btnsign.Location = new System.Drawing.Point(143, 378);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(145, 60);
            this.btnsign.TabIndex = 19;
            this.btnsign.Text = "Sign Up";
            this.btnsign.UseVisualStyleBackColor = false;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmHastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
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
            this.Name = "FrmHastaKayit";
            this.Text = "Patient Sign Up";
            this.Load += new System.EventHandler(this.FrmHastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txdsoyad;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txdpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.Button btnsign;
        private System.Windows.Forms.Button button2;
    }
}