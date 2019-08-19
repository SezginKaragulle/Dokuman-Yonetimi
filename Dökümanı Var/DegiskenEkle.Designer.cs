namespace Dökümanı_Var
{
    partial class DegiskenEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DegiskenEkle));
            this.lblDegiskenAdi = new System.Windows.Forms.Label();
            this.lblDegiskenBilgisi = new System.Windows.Forms.Label();
            this.txtDegiskenAdi = new System.Windows.Forms.TextBox();
            this.txtDegiskenBilgisi = new System.Windows.Forms.TextBox();
            this.lblDegiskenTur = new System.Windows.Forms.Label();
            this.cmbDegiskenTuru = new System.Windows.Forms.ComboBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnDegiskenEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDegiskenAdi
            // 
            this.lblDegiskenAdi.AutoSize = true;
            this.lblDegiskenAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.lblDegiskenAdi.Location = new System.Drawing.Point(13, 6);
            this.lblDegiskenAdi.Name = "lblDegiskenAdi";
            this.lblDegiskenAdi.Size = new System.Drawing.Size(73, 13);
            this.lblDegiskenAdi.TabIndex = 0;
            this.lblDegiskenAdi.Text = "Değişken Adı:";
            // 
            // lblDegiskenBilgisi
            // 
            this.lblDegiskenBilgisi.AutoSize = true;
            this.lblDegiskenBilgisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.lblDegiskenBilgisi.Location = new System.Drawing.Point(2, 33);
            this.lblDegiskenBilgisi.Name = "lblDegiskenBilgisi";
            this.lblDegiskenBilgisi.Size = new System.Drawing.Size(84, 13);
            this.lblDegiskenBilgisi.TabIndex = 1;
            this.lblDegiskenBilgisi.Text = "Değişken Bilgisi:";
            // 
            // txtDegiskenAdi
            // 
            this.txtDegiskenAdi.Location = new System.Drawing.Point(92, 6);
            this.txtDegiskenAdi.Name = "txtDegiskenAdi";
            this.txtDegiskenAdi.Size = new System.Drawing.Size(157, 20);
            this.txtDegiskenAdi.TabIndex = 2;
            // 
            // txtDegiskenBilgisi
            // 
            this.txtDegiskenBilgisi.Location = new System.Drawing.Point(92, 33);
            this.txtDegiskenBilgisi.Name = "txtDegiskenBilgisi";
            this.txtDegiskenBilgisi.Size = new System.Drawing.Size(157, 20);
            this.txtDegiskenBilgisi.TabIndex = 3;
            // 
            // lblDegiskenTur
            // 
            this.lblDegiskenTur.AutoSize = true;
            this.lblDegiskenTur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.lblDegiskenTur.Location = new System.Drawing.Point(6, 60);
            this.lblDegiskenTur.Name = "lblDegiskenTur";
            this.lblDegiskenTur.Size = new System.Drawing.Size(80, 13);
            this.lblDegiskenTur.TabIndex = 4;
            this.lblDegiskenTur.Text = "Değişken Türü:";
            // 
            // cmbDegiskenTuru
            // 
            this.cmbDegiskenTuru.FormattingEnabled = true;
            this.cmbDegiskenTuru.Items.AddRange(new object[] {
            "Kara",
            "Hava",
            "Deniz",
            "Fatura",
            "Depo_Evrak",
            "Depo_Fatura",
            "Demiryolu",
            "Konteyner_Taşımacılığı",
            "Finans_Fatura_İrsaliye",
            "Fuar",
            "Ambar_Barkod",
            "Cari_Bookmark",
            "AraçFilo_Bookmark",
            "Teklif_Bookmark"});
            this.cmbDegiskenTuru.Location = new System.Drawing.Point(92, 60);
            this.cmbDegiskenTuru.Name = "cmbDegiskenTuru";
            this.cmbDegiskenTuru.Size = new System.Drawing.Size(157, 21);
            this.cmbDegiskenTuru.TabIndex = 5;
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.Location = new System.Drawing.Point(168, 154);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(113, 23);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnDegiskenEkle
            // 
            this.btnDegiskenEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegiskenEkle.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnDegiskenEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDegiskenEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnDegiskenEkle.Image")));
            this.btnDegiskenEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDegiskenEkle.Location = new System.Drawing.Point(16, 154);
            this.btnDegiskenEkle.Name = "btnDegiskenEkle";
            this.btnDegiskenEkle.Size = new System.Drawing.Size(113, 23);
            this.btnDegiskenEkle.TabIndex = 6;
            this.btnDegiskenEkle.Text = "Kaydet";
            this.btnDegiskenEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDegiskenEkle.UseVisualStyleBackColor = true;
            this.btnDegiskenEkle.Click += new System.EventHandler(this.btnDegiskenEkle_Click);
            // 
            // DegiskenEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 184);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnDegiskenEkle);
            this.Controls.Add(this.cmbDegiskenTuru);
            this.Controls.Add(this.lblDegiskenTur);
            this.Controls.Add(this.txtDegiskenBilgisi);
            this.Controls.Add(this.txtDegiskenAdi);
            this.Controls.Add(this.lblDegiskenBilgisi);
            this.Controls.Add(this.lblDegiskenAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DegiskenEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Değişken Ekle";
            this.Load += new System.EventHandler(this.DegiskenEkle_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DegiskenEkle_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDegiskenAdi;
        private System.Windows.Forms.Label lblDegiskenBilgisi;
        private System.Windows.Forms.Label lblDegiskenTur;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnDegiskenEkle;
        public System.Windows.Forms.TextBox txtDegiskenAdi;
        public System.Windows.Forms.TextBox txtDegiskenBilgisi;
        public System.Windows.Forms.ComboBox cmbDegiskenTuru;
    }
}