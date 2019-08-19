namespace Dökümanı_Var
{
    partial class DegiskenGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DegiskenGuncelle));
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnDegiskenGuncelle = new System.Windows.Forms.Button();
            this.cmbDegiskenTuru = new System.Windows.Forms.ComboBox();
            this.lblDegiskenTur = new System.Windows.Forms.Label();
            this.txtDegiskenBilgisi = new System.Windows.Forms.TextBox();
            this.txtDegiskenAdi = new System.Windows.Forms.TextBox();
            this.lblDegiskenBilgisi = new System.Windows.Forms.Label();
            this.lblDegiskenAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.Location = new System.Drawing.Point(169, 155);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(113, 23);
            this.btnCikis.TabIndex = 15;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnDegiskenGuncelle
            // 
            this.btnDegiskenGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegiskenGuncelle.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnDegiskenGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDegiskenGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnDegiskenGuncelle.Image")));
            this.btnDegiskenGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDegiskenGuncelle.Location = new System.Drawing.Point(17, 155);
            this.btnDegiskenGuncelle.Name = "btnDegiskenGuncelle";
            this.btnDegiskenGuncelle.Size = new System.Drawing.Size(113, 23);
            this.btnDegiskenGuncelle.TabIndex = 14;
            this.btnDegiskenGuncelle.Text = "Güncelle";
            this.btnDegiskenGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDegiskenGuncelle.UseVisualStyleBackColor = true;
            this.btnDegiskenGuncelle.Click += new System.EventHandler(this.btnDegiskenGuncelle_Click);
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
            this.cmbDegiskenTuru.Location = new System.Drawing.Point(93, 69);
            this.cmbDegiskenTuru.Name = "cmbDegiskenTuru";
            this.cmbDegiskenTuru.Size = new System.Drawing.Size(157, 21);
            this.cmbDegiskenTuru.TabIndex = 13;
            // 
            // lblDegiskenTur
            // 
            this.lblDegiskenTur.AutoSize = true;
            this.lblDegiskenTur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.lblDegiskenTur.Location = new System.Drawing.Point(7, 69);
            this.lblDegiskenTur.Name = "lblDegiskenTur";
            this.lblDegiskenTur.Size = new System.Drawing.Size(80, 13);
            this.lblDegiskenTur.TabIndex = 12;
            this.lblDegiskenTur.Text = "Değişken Türü:";
            // 
            // txtDegiskenBilgisi
            // 
            this.txtDegiskenBilgisi.Location = new System.Drawing.Point(93, 42);
            this.txtDegiskenBilgisi.Name = "txtDegiskenBilgisi";
            this.txtDegiskenBilgisi.Size = new System.Drawing.Size(157, 20);
            this.txtDegiskenBilgisi.TabIndex = 11;
            // 
            // txtDegiskenAdi
            // 
            this.txtDegiskenAdi.Location = new System.Drawing.Point(93, 15);
            this.txtDegiskenAdi.Name = "txtDegiskenAdi";
            this.txtDegiskenAdi.Size = new System.Drawing.Size(157, 20);
            this.txtDegiskenAdi.TabIndex = 10;
            // 
            // lblDegiskenBilgisi
            // 
            this.lblDegiskenBilgisi.AutoSize = true;
            this.lblDegiskenBilgisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.lblDegiskenBilgisi.Location = new System.Drawing.Point(3, 42);
            this.lblDegiskenBilgisi.Name = "lblDegiskenBilgisi";
            this.lblDegiskenBilgisi.Size = new System.Drawing.Size(84, 13);
            this.lblDegiskenBilgisi.TabIndex = 9;
            this.lblDegiskenBilgisi.Text = "Değişken Bilgisi:";
            // 
            // lblDegiskenAdi
            // 
            this.lblDegiskenAdi.AutoSize = true;
            this.lblDegiskenAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.lblDegiskenAdi.Location = new System.Drawing.Point(14, 15);
            this.lblDegiskenAdi.Name = "lblDegiskenAdi";
            this.lblDegiskenAdi.Size = new System.Drawing.Size(73, 13);
            this.lblDegiskenAdi.TabIndex = 8;
            this.lblDegiskenAdi.Text = "Değişken Adı:";
            // 
            // DegiskenGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 184);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnDegiskenGuncelle);
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
            this.Name = "DegiskenGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Değişken Güncelle";
            this.Load += new System.EventHandler(this.DegiskenGuncelle_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DegiskenGuncelle_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnDegiskenGuncelle;
        private System.Windows.Forms.Label lblDegiskenTur;
        private System.Windows.Forms.Label lblDegiskenBilgisi;
        private System.Windows.Forms.Label lblDegiskenAdi;
        public System.Windows.Forms.ComboBox cmbDegiskenTuru;
        public System.Windows.Forms.TextBox txtDegiskenBilgisi;
        public System.Windows.Forms.TextBox txtDegiskenAdi;
    }
}