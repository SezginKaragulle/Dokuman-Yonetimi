namespace Dökümanı_Var
{
    partial class DokumanEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DokumanEkle));
            this.btnDokumaniEkle = new System.Windows.Forms.Button();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCikis = new System.Windows.Forms.Button();
            this.cmbSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chckMailGonder = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDokumaniEkle
            // 
            this.btnDokumaniEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDokumaniEkle.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnDokumaniEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDokumaniEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnDokumaniEkle.Image")));
            this.btnDokumaniEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDokumaniEkle.Location = new System.Drawing.Point(12, 47);
            this.btnDokumaniEkle.Name = "btnDokumaniEkle";
            this.btnDokumaniEkle.Size = new System.Drawing.Size(130, 23);
            this.btnDokumaniEkle.TabIndex = 4;
            this.btnDokumaniEkle.Text = "Dökümanı Ekle";
            this.btnDokumaniEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDokumaniEkle.UseVisualStyleBackColor = true;
            this.btnDokumaniEkle.Click += new System.EventHandler(this.btnDokumaniEkle_Click);
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDosyaSec.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnDosyaSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDosyaSec.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaSec.Image")));
            this.btnDosyaSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDosyaSec.Location = new System.Drawing.Point(297, 12);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(157, 23);
            this.btnDosyaSec.TabIndex = 3;
            this.btnDosyaSec.Text = "Dosya Seç";
            this.btnDosyaSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.Location = new System.Drawing.Point(167, 47);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(130, 23);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // cmbSec
            // 
            this.cmbSec.FormattingEnabled = true;
            this.cmbSec.Items.AddRange(new object[] {
            "SOFTTRANS",
            "SOFTFİNANS",
            "EBELGEPORTAL"});
            this.cmbSec.Location = new System.Drawing.Point(413, 49);
            this.cmbSec.Name = "cmbSec";
            this.cmbSec.Size = new System.Drawing.Size(140, 21);
            this.cmbSec.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(328, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Döküman Tipi :";
            // 
            // chckMailGonder
            // 
            this.chckMailGonder.AutoSize = true;
            this.chckMailGonder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.chckMailGonder.Location = new System.Drawing.Point(574, 51);
            this.chckMailGonder.Name = "chckMailGonder";
            this.chckMailGonder.Size = new System.Drawing.Size(83, 17);
            this.chckMailGonder.TabIndex = 9;
            this.chckMailGonder.Text = "Mail Gönder";
            this.chckMailGonder.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Mail Test(Sadece Test Butonudur)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DokumanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 83);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chckMailGonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSec);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnDokumaniEkle);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DokumanEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döküman Ekle";
            this.Load += new System.EventHandler(this.DokumanEkle_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DokumanEkle_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDokumaniEkle;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ComboBox cmbSec;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox chckMailGonder;
        private System.Windows.Forms.Button button1;
    }
}