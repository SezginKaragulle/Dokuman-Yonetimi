namespace Dökümanı_Var
{
    partial class Dökümanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dökümanlar));
            this.dizinIcerigiListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSoftTrans = new System.Windows.Forms.Button();
            this.btnSoftFinans = new System.Windows.Forms.Button();
            this.btnEBelgePortal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDegiskenler = new System.Windows.Forms.Button();
            this.btnDokumaniSil = new System.Windows.Forms.Button();
            this.btnDokumaniAc = new System.Windows.Forms.Button();
            this.btnDokumanEkle = new System.Windows.Forms.Button();
            this.btnDokumaniMailGonder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dizinIcerigiListView
            // 
            this.dizinIcerigiListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3});
            this.dizinIcerigiListView.FullRowSelect = true;
            this.dizinIcerigiListView.GridLines = true;
            this.dizinIcerigiListView.Location = new System.Drawing.Point(7, 5);
            this.dizinIcerigiListView.Name = "dizinIcerigiListView";
            this.dizinIcerigiListView.Size = new System.Drawing.Size(566, 246);
            this.dizinIcerigiListView.TabIndex = 1;
            this.dizinIcerigiListView.UseCompatibleStateImageBehavior = false;
            this.dizinIcerigiListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 252;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tür";
            this.columnHeader4.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Boyut(byte)";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oluşturma Tarihi";
            this.columnHeader3.Width = 123;
            // 
            // btnSoftTrans
            // 
            this.btnSoftTrans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnSoftTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftTrans.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnSoftTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnSoftTrans.Image = ((System.Drawing.Image)(resources.GetObject("btnSoftTrans.Image")));
            this.btnSoftTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSoftTrans.Location = new System.Drawing.Point(6, 152);
            this.btnSoftTrans.Name = "btnSoftTrans";
            this.btnSoftTrans.Size = new System.Drawing.Size(158, 23);
            this.btnSoftTrans.TabIndex = 2;
            this.btnSoftTrans.Text = "SOFT TRANS";
            this.btnSoftTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoftTrans.UseVisualStyleBackColor = true;
            this.btnSoftTrans.Click += new System.EventHandler(this.btnSoftTrans_Click);
            // 
            // btnSoftFinans
            // 
            this.btnSoftFinans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnSoftFinans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftFinans.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnSoftFinans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnSoftFinans.Image = ((System.Drawing.Image)(resources.GetObject("btnSoftFinans.Image")));
            this.btnSoftFinans.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSoftFinans.Location = new System.Drawing.Point(6, 125);
            this.btnSoftFinans.Name = "btnSoftFinans";
            this.btnSoftFinans.Size = new System.Drawing.Size(158, 23);
            this.btnSoftFinans.TabIndex = 3;
            this.btnSoftFinans.Text = "SOFT FİNANS";
            this.btnSoftFinans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoftFinans.UseVisualStyleBackColor = true;
            this.btnSoftFinans.Click += new System.EventHandler(this.btnSoftFinans_Click);
            // 
            // btnEBelgePortal
            // 
            this.btnEBelgePortal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnEBelgePortal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEBelgePortal.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnEBelgePortal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnEBelgePortal.Image = ((System.Drawing.Image)(resources.GetObject("btnEBelgePortal.Image")));
            this.btnEBelgePortal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEBelgePortal.Location = new System.Drawing.Point(6, 96);
            this.btnEBelgePortal.Name = "btnEBelgePortal";
            this.btnEBelgePortal.Size = new System.Drawing.Size(158, 23);
            this.btnEBelgePortal.TabIndex = 4;
            this.btnEBelgePortal.Text = "E-BELGE PORTAL";
            this.btnEBelgePortal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEBelgePortal.UseVisualStyleBackColor = true;
            this.btnEBelgePortal.Click += new System.EventHandler(this.btnEBelgePortal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDokumaniMailGonder);
            this.groupBox1.Controls.Add(this.btnDegiskenler);
            this.groupBox1.Controls.Add(this.btnDokumaniSil);
            this.groupBox1.Controls.Add(this.btnDokumaniAc);
            this.groupBox1.Controls.Add(this.btnDokumanEkle);
            this.groupBox1.Controls.Add(this.btnEBelgePortal);
            this.groupBox1.Controls.Add(this.btnSoftTrans);
            this.groupBox1.Controls.Add(this.btnSoftFinans);
            this.groupBox1.Location = new System.Drawing.Point(580, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 246);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDegiskenler
            // 
            this.btnDegiskenler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDegiskenler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegiskenler.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegiskenler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDegiskenler.Image = ((System.Drawing.Image)(resources.GetObject("btnDegiskenler.Image")));
            this.btnDegiskenler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDegiskenler.Location = new System.Drawing.Point(6, 181);
            this.btnDegiskenler.Name = "btnDegiskenler";
            this.btnDegiskenler.Size = new System.Drawing.Size(158, 23);
            this.btnDegiskenler.TabIndex = 8;
            this.btnDegiskenler.Text = "DEĞİŞKENLER";
            this.btnDegiskenler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDegiskenler.UseVisualStyleBackColor = true;
            this.btnDegiskenler.Click += new System.EventHandler(this.btnDegiskenler_Click);
            // 
            // btnDokumaniSil
            // 
            this.btnDokumaniSil.Enabled = false;
            this.btnDokumaniSil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDokumaniSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDokumaniSil.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnDokumaniSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDokumaniSil.Image = ((System.Drawing.Image)(resources.GetObject("btnDokumaniSil.Image")));
            this.btnDokumaniSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDokumaniSil.Location = new System.Drawing.Point(6, 70);
            this.btnDokumaniSil.Name = "btnDokumaniSil";
            this.btnDokumaniSil.Size = new System.Drawing.Size(158, 23);
            this.btnDokumaniSil.TabIndex = 7;
            this.btnDokumaniSil.Text = "DÖKÜMANI SİL";
            this.btnDokumaniSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDokumaniSil.UseVisualStyleBackColor = true;
            this.btnDokumaniSil.Click += new System.EventHandler(this.btnDokumaniSil_Click_1);
            // 
            // btnDokumaniAc
            // 
            this.btnDokumaniAc.Enabled = false;
            this.btnDokumaniAc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDokumaniAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDokumaniAc.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnDokumaniAc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDokumaniAc.Image = ((System.Drawing.Image)(resources.GetObject("btnDokumaniAc.Image")));
            this.btnDokumaniAc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDokumaniAc.Location = new System.Drawing.Point(6, 45);
            this.btnDokumaniAc.Name = "btnDokumaniAc";
            this.btnDokumaniAc.Size = new System.Drawing.Size(158, 23);
            this.btnDokumaniAc.TabIndex = 6;
            this.btnDokumaniAc.Text = "DÖKÜMANI AÇ";
            this.btnDokumaniAc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDokumaniAc.UseVisualStyleBackColor = true;
            this.btnDokumaniAc.Click += new System.EventHandler(this.btnDokumaniAc_Click);
            // 
            // btnDokumanEkle
            // 
            this.btnDokumanEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDokumanEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDokumanEkle.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnDokumanEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDokumanEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnDokumanEkle.Image")));
            this.btnDokumanEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDokumanEkle.Location = new System.Drawing.Point(6, 19);
            this.btnDokumanEkle.Name = "btnDokumanEkle";
            this.btnDokumanEkle.Size = new System.Drawing.Size(158, 23);
            this.btnDokumanEkle.TabIndex = 5;
            this.btnDokumanEkle.Text = "DÖKÜMAN EKLE";
            this.btnDokumanEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDokumanEkle.UseVisualStyleBackColor = true;
            this.btnDokumanEkle.Click += new System.EventHandler(this.btnDokumanEkle_Click);
            // 
            // btnDokumaniMailGonder
            // 
            this.btnDokumaniMailGonder.Enabled = false;
            this.btnDokumaniMailGonder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDokumaniMailGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDokumaniMailGonder.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnDokumaniMailGonder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDokumaniMailGonder.Image = ((System.Drawing.Image)(resources.GetObject("btnDokumaniMailGonder.Image")));
            this.btnDokumaniMailGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDokumaniMailGonder.Location = new System.Drawing.Point(6, 211);
            this.btnDokumaniMailGonder.Name = "btnDokumaniMailGonder";
            this.btnDokumaniMailGonder.Size = new System.Drawing.Size(158, 23);
            this.btnDokumaniMailGonder.TabIndex = 9;
            this.btnDokumaniMailGonder.Text = "DÖKÜMANI MAİL GÖNDER";
            this.btnDokumaniMailGonder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDokumaniMailGonder.UseVisualStyleBackColor = true;
            this.btnDokumaniMailGonder.Click += new System.EventHandler(this.btnDokumaniMailGonder_Click);
            // 
            // Dökümanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dizinIcerigiListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Dökümanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dökümanlar";
            this.Load += new System.EventHandler(this.Dökümanlar_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dökümanlar_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListView dizinIcerigiListView;
        public System.Windows.Forms.Button btnSoftTrans;
        public System.Windows.Forms.Button btnSoftFinans;
        public System.Windows.Forms.Button btnEBelgePortal;
        public System.Windows.Forms.Button btnDokumaniAc;
        public System.Windows.Forms.Button btnDokumanEkle;
        public System.Windows.Forms.Button btnDokumaniSil;
        public System.Windows.Forms.Button btnDegiskenler;
        public System.Windows.Forms.Button btnDokumaniMailGonder;
    }
}

