
namespace Hastane_Proje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnhasta = new System.Windows.Forms.Button();
            this.btndoctor = new System.Windows.Forms.Button();
            this.btnsecreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhasta
            // 
            this.btnhasta.BackColor = System.Drawing.Color.Azure;
            this.btnhasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhasta.Image = ((System.Drawing.Image)(resources.GetObject("btnhasta.Image")));
            this.btnhasta.Location = new System.Drawing.Point(65, 169);
            this.btnhasta.Name = "btnhasta";
            this.btnhasta.Size = new System.Drawing.Size(190, 181);
            this.btnhasta.TabIndex = 0;
            this.btnhasta.UseVisualStyleBackColor = false;
            this.btnhasta.Click += new System.EventHandler(this.btnhasta_Click);
            // 
            // btndoctor
            // 
            this.btndoctor.AutoEllipsis = true;
            this.btndoctor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btndoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoctor.BackgroundImage")));
            this.btndoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoctor.Location = new System.Drawing.Point(311, 169);
            this.btndoctor.Name = "btndoctor";
            this.btndoctor.Size = new System.Drawing.Size(188, 181);
            this.btndoctor.TabIndex = 1;
            this.btndoctor.UseVisualStyleBackColor = false;
            this.btndoctor.Click += new System.EventHandler(this.btndoctor_Click);
            // 
            // btnsecreter
            // 
            this.btnsecreter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsecreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsecreter.BackgroundImage")));
            this.btnsecreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsecreter.Location = new System.Drawing.Point(538, 169);
            this.btnsecreter.Name = "btnsecreter";
            this.btnsecreter.Size = new System.Drawing.Size(194, 181);
            this.btnsecreter.TabIndex = 2;
            this.btnsecreter.UseVisualStyleBackColor = false;
            this.btnsecreter.Click += new System.EventHandler(this.btnsecreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(358, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(594, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secreter";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(389, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 47);
            this.label4.TabIndex = 7;
            this.label4.Text = "Diagnostic Hospital";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsecreter);
            this.Controls.Add(this.btndoctor);
            this.Controls.Add(this.btnhasta);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Diagnostic Hospital Entrance";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhasta;
        private System.Windows.Forms.Button btndoctor;
        private System.Windows.Forms.Button btnsecreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

