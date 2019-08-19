using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;


namespace Dökümanı_Var
{
    public partial class Değişkenler : Form
    {
        public Dökümanlar FrmDokumanlar;
        public Değişkenler()
        {
            InitializeComponent();
        }
        DegiskenDal _DegiskenDal = new DegiskenDal();
        public string Vr_Deger;
        public string DosyaYoluSayac = Application.StartupPath + "\\DegiskenSayac.xml";
        public string DosyaYoluKara = Application.StartupPath + "\\DegiskenKara.xml";
        public string DosyaYoluHava = Application.StartupPath + "\\DegiskenHava.xml";
        public string DosyaYoluDeniz = Application.StartupPath + "\\DegiskenDeniz.xml";
        public string DosyaYoluFatura = System.Windows.Forms.Application.StartupPath + "\\DegiskenFatura.xml";
        public string DosyaYoluDepoEvrak = System.Windows.Forms.Application.StartupPath + "\\DegiskenDepoEvrak.xml";
        public string DosyaYoluDepoFatura = System.Windows.Forms.Application.StartupPath + "\\DegiskenDepoFatura.xml";
        public string DosyaYoluDemiryolu = System.Windows.Forms.Application.StartupPath + "\\DegiskenDemiryolu.xml";
        public string DosyaYoluKonteyner = System.Windows.Forms.Application.StartupPath + "\\DegiskenKonteyner.xml";
        public string DosyaYoluFinansFaturaİrsaliye = System.Windows.Forms.Application.StartupPath + "\\DegiskenFinansFaturaİrsaliye.xml";
        public string DosyaYoluFuar = System.Windows.Forms.Application.StartupPath + "\\DegiskenFuar.xml";
        public string DosyaYoluAmbarBarkod = System.Windows.Forms.Application.StartupPath + "\\DegiskenAmbarBarkod.xml";
        public string DosyaYoluCari = System.Windows.Forms.Application.StartupPath + "\\DegiskenCari.xml";
        public string DosyaYoluAracFilo = System.Windows.Forms.Application.StartupPath + "\\DegiskenAracFilo.xml";
        public string DosyaYoluTeklif = System.Windows.Forms.Application.StartupPath + "\\DegiskenTeklif.xml";
        public void Degisken_Yukle()
        {
            dgwDegiskenler.DataSource = _DegiskenDal.GetAll();
            dgwDegiskenler.Columns[0].HeaderText = "ID";
            dgwDegiskenler.Columns[1].HeaderText = "DEĞİŞKEN ADI";
            dgwDegiskenler.Columns[2].HeaderText = "DEĞİŞKEN BİLGİSİ";
            dgwDegiskenler.Columns[3].HeaderText = "DEĞİŞKEN TÜRÜ";

        }

        public void Dokuman_Getir( string dr_DosyaYol)
        {

            DataSet ds = new DataSet();
            ds.ReadXml(dr_DosyaYol);
            dgwDegiskenler.DataSource = ds.Tables[0];
            //dgwDegiskenler.Columns[0].HeaderText = "DÖKÜMAN ADI";
            //dgwDegiskenler.Columns[1].HeaderText = "DÖKÜMAN YOLU";
            //dgwDegiskenler.Columns[2].HeaderText = "DÖKÜMAN NUMARASI";
        }


        public void MTDegiskenSil(string VrDosyaYol)
        {
       

            XDocument x = XDocument.Load(VrDosyaYol);


            x.Root.Elements().Where(a => a.Element("DegiskenNo").Value == dgwDegiskenler.CurrentRow.Cells[0].Value.ToString().Trim()).Remove();
            x.Save(VrDosyaYol);
            MessageBox.Show("Değişken Silme İşlemi Gerçekleştirildi", " Değişken Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        public void MTDegiskenNoGetir(string VrDosyaYol,string VrDegiskenKod,DataGridView dt_Degiskenler)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(VrDosyaYol);
            /* dt_Degiskenler.DataSource = ds.Tables[0].DefaultView.RowFilter.Contains("DegiskenKodu = '" + VrDegiskenKod + "'");*/
            /* ds.Tables[0].DefaultView.RowFilter = "DegiskenKodu = '" + VrDegiskenKod + "'";*/
            ds.Tables[0].DefaultView.RowFilter = String.Format("DegiskenKodu LIKE '%{0}%'", VrDegiskenKod);
            dt_Degiskenler.DataSource = ds.Tables[0];      

        }

        public void MTDegiskenBilgiGetir(string VrDosyaYol, string VrDegiskenBilgi, DataGridView dt_Degiskenler)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(VrDosyaYol);
            /* dt_Degiskenler.DataSource = ds.Tables[0].DefaultView.RowFilter.Contains("DegiskenKodu = '" + VrDegiskenKod + "'");*/
            /* ds.Tables[0].DefaultView.RowFilter = "DegiskenKodu = '" + VrDegiskenKod + "'";*/
            ds.Tables[0].DefaultView.RowFilter = String.Format("DegiskenAciklama LIKE '%{0}%'", VrDegiskenBilgi);
            dt_Degiskenler.DataSource = ds.Tables[0];

        }

        private void Değişkenler_Load(object sender, EventArgs e)
        {

           // Degisken_Yukle();
            
        }
     
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            rdbBasanDegereGore.Checked = false;
            rdbDegiskeneGore.Checked = false;
            txtBasanDegereGore.Text = "";
            txtDegiskeneGore.Text = "";
            FrmDokumanlar.Show();
            FrmDokumanlar.dizinIcerigiListView.Items.Clear();
           FrmDokumanlar.btnDokumaniAc.Enabled = false;
            FrmDokumanlar.btnDokumaniSil.Enabled = false;
            FrmDokumanlar.btnDokumaniMailGonder.Enabled = false;
            this.Hide();
        }

        private void Değişkenler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                DialogResult yanit;
                yanit = MessageBox.Show("Programdan çıkmak istiyor musunuz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yanit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void btnDegiskenAra_Click(object sender, EventArgs e)
        {
            
            if (rdbDegiskeneGore.Checked == false && rdbBasanDegereGore.Checked == false)
            {
                MessageBox.Show("Arama Kriteri Seçmelisiniz", "Arama", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else if (rdbDegiskeneGore.Checked == true)
            {
                if (Vr_Deger == Degisken_Degerleri.Kara.ToString())
                {
                    /* _DegiskenDal.DegiskenKodAra(txtDegiskeneGore.Text, dgwDegiskenler, _DegiskenDal);*/
                    MTDegiskenNoGetir(DosyaYoluKara, txtDegiskeneGore.Text.Trim(),dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }

               else if (Vr_Deger == Degisken_Degerleri.Hava.ToString())
                {
                    MTDegiskenNoGetir(DosyaYoluHava, txtDegiskeneGore.Text.Trim(), dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Deniz.ToString())
                {
                    MTDegiskenNoGetir(DosyaYoluDeniz, txtDegiskeneGore.Text.Trim(), dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }

                else if (Vr_Deger == Degisken_Degerleri.Fatura.ToString())
                {
                    MTDegiskenNoGetir(DosyaYoluFatura, txtDegiskeneGore.Text.Trim(), dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Depo_Evrak.ToString())
                {
                    MTDegiskenNoGetir(DosyaYoluDepoEvrak, txtDegiskeneGore.Text.Trim(), dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Depo_Fatura.ToString())
                {
                    MTDegiskenNoGetir(DosyaYoluDepoFatura, txtDegiskeneGore.Text.Trim(), dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Demiryolu.ToString())
                {
                    MTDegiskenNoGetir(DosyaYoluDemiryolu, txtDegiskeneGore.Text.Trim(), dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }

                else if (Vr_Deger == Degisken_Degerleri.Konteyner_Taşımacılığı.ToString())
                {
                    MTDegiskenNoGetir(DosyaYoluKonteyner, txtDegiskeneGore.Text.Trim(), dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }

                else if (Vr_Deger == Degisken_Degerleri.Finans_Fatura_İrsaliye.ToString())
                {
                    MTDegiskenNoGetir(DosyaYoluFinansFaturaİrsaliye, txtDegiskeneGore.Text.Trim(), dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }

                else if (Vr_Deger == Degisken_Degerleri.Fuar.ToString())
                {
                    MTDegiskenNoGetir(DosyaYoluFuar, txtDegiskeneGore.Text.Trim(), dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Ambar_Barkod.ToString())
                {
                    MTDegiskenNoGetir(DosyaYoluAmbarBarkod, txtDegiskeneGore.Text.Trim(), dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Cari_Bookmark.ToString())
                {
                    MTDegiskenNoGetir(DosyaYoluCari, txtDegiskeneGore.Text.Trim(), dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.AraçFilo_Bookmark.ToString())
                {
                    MTDegiskenNoGetir(DosyaYoluAracFilo, txtDegiskeneGore.Text.Trim(), dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Teklif_Bookmark.ToString())
                {
                    MTDegiskenNoGetir(DosyaYoluTeklif, txtDegiskeneGore.Text.Trim(), dgwDegiskenler);
                    rdbDegiskeneGore.Checked = false;
                    txtDegiskeneGore.Text = "";
                }

            }
            else if (rdbBasanDegereGore.Checked == true)
            {
                if (Vr_Deger == Degisken_Degerleri.Kara.ToString())
                {
                    //_DegiskenDal.DegiskenBilgiAra(txtBasanDegereGore.Text, dgwDegiskenler, _DegiskenDal);
                    MTDegiskenBilgiGetir(DosyaYoluKara, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }

                else if (Vr_Deger == Degisken_Degerleri.Hava.ToString())
                {
                    MTDegiskenBilgiGetir(DosyaYoluHava, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Deniz.ToString())
                {
                    MTDegiskenBilgiGetir(DosyaYoluDeniz, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }

                else if (Vr_Deger == Degisken_Degerleri.Fatura.ToString())
                {
                    MTDegiskenBilgiGetir(DosyaYoluFatura, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Depo_Evrak.ToString())
                {
                    MTDegiskenBilgiGetir(DosyaYoluDepoEvrak, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Depo_Fatura.ToString())
                {
                    MTDegiskenBilgiGetir(DosyaYoluDepoFatura, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Demiryolu.ToString())
                {
                    MTDegiskenBilgiGetir(DosyaYoluDemiryolu, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }

                else if (Vr_Deger == Degisken_Degerleri.Konteyner_Taşımacılığı.ToString())
                {
                    MTDegiskenBilgiGetir(DosyaYoluKonteyner, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }

                else if (Vr_Deger == Degisken_Degerleri.Finans_Fatura_İrsaliye.ToString())
                {
                    MTDegiskenBilgiGetir(DosyaYoluFinansFaturaİrsaliye, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }

                else if (Vr_Deger == Degisken_Degerleri.Fuar.ToString())
                {
                    MTDegiskenBilgiGetir(DosyaYoluFuar, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Ambar_Barkod.ToString())
                {
                    MTDegiskenBilgiGetir(DosyaYoluAmbarBarkod, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Cari_Bookmark.ToString())
                {
                    MTDegiskenBilgiGetir(DosyaYoluCari, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.AraçFilo_Bookmark.ToString())
                {
                    MTDegiskenBilgiGetir(DosyaYoluAracFilo, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }
                else if (Vr_Deger == Degisken_Degerleri.Teklif_Bookmark.ToString())
                {
                    MTDegiskenBilgiGetir(DosyaYoluTeklif, txtBasanDegereGore.Text.Trim(), dgwDegiskenler);
                    rdbBasanDegereGore.Checked = false;
                    txtBasanDegereGore.Text = "";
                }
            }
        }

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDegiskenEkle_Click(object sender, EventArgs e)
        {

            pnlControls.Controls.Clear();
            FrmDokumanlar.FrmDegiskenEkle.TopLevel = false;
            pnlControls.Controls.Add(FrmDokumanlar.FrmDegiskenEkle);
            FrmDokumanlar.FrmDegiskenEkle.Show();
            FrmDokumanlar.FrmDegiskenEkle.txtDegiskenAdi.Text = "";
            FrmDokumanlar.FrmDegiskenEkle.txtDegiskenBilgisi.Text = "";
            FrmDokumanlar.FrmDegiskenEkle.cmbDegiskenTuru.Text = "";
            FrmDokumanlar.FrmDegiskenEkle.Dock = DockStyle.Fill;
            FrmDokumanlar.FrmDegiskenEkle.BringToFront();
            //FrmDokumanlar.FrmDegiskenEkle.MTSayac();
        }

        private void btnDegiskenGuncelle_Click(object sender, EventArgs e)
        {
            pnlControls.Controls.Clear();
            FrmDokumanlar.FrmDegiskenGuncelle.TopLevel = false;
            pnlControls.Controls.Add(FrmDokumanlar.FrmDegiskenGuncelle);
            FrmDokumanlar.FrmDegiskenGuncelle.Show();
            FrmDokumanlar.FrmDegiskenGuncelle.Dock = DockStyle.Fill;
            FrmDokumanlar.FrmDegiskenGuncelle.BringToFront();
            FrmDokumanlar.FrmDegiskenGuncelle.Degisken_Deger_Getir();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnKaraDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.Kara.ToString();
            //_DegiskenDal.DegiskenList(Degisken_Degerleri.Kara.ToString(), dgwDegiskenler, _DegiskenDal);
            //_DegiskenDal.Degiskenleri_Getir(dgwDegiskenler);
            Dokuman_Getir(DosyaYoluKara);

        }

        private void btnDenizDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.Deniz.ToString();
            Dokuman_Getir(DosyaYoluDeniz);

        }

        private void btnHavaDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.Hava.ToString();
            //_DegiskenDal.DegiskenList(Degisken_Degerleri.Hava.ToString(), dgwDegiskenler, _DegiskenDal);
            Dokuman_Getir(DosyaYoluHava);

        }

        private void btnFaturaDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.Fatura.ToString();
            //_DegiskenDal.DegiskenList(Degisken_Degerleri.Fatura.ToString(), dgwDegiskenler, _DegiskenDal);
            Dokuman_Getir(DosyaYoluFatura);
        }

        private void btnDepoEvrakDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.Depo_Evrak.ToString();
            //_DegiskenDal.DegiskenList(Degisken_Degerleri.Depo_Evrak.ToString(), dgwDegiskenler, _DegiskenDal);
            Dokuman_Getir(DosyaYoluDepoEvrak);

        }

        private void btnDepoFaturaDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.Depo_Fatura.ToString();
            // _DegiskenDal.DegiskenList(Degisken_Degerleri.Depo_Fatura.ToString(), dgwDegiskenler, _DegiskenDal);
            Dokuman_Getir(DosyaYoluDepoFatura);

        }

        private void btnDemiryoluDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.Demiryolu.ToString();
            //_DegiskenDal.DegiskenList(Degisken_Degerleri.Demiryolu.ToString(), dgwDegiskenler, _DegiskenDal);
            Dokuman_Getir(DosyaYoluDemiryolu);

        }

        private void btnKonteynerDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.Konteyner_Taşımacılığı.ToString();
            //_DegiskenDal.DegiskenList(Degisken_Degerleri.Konteyner_Taşımacılığı.ToString(), dgwDegiskenler, _DegiskenDal);
            Dokuman_Getir(DosyaYoluKonteyner);

        }

        private void btnFinansFatİrsaliyeDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.Finans_Fatura_İrsaliye.ToString();
            //_DegiskenDal.DegiskenList(Degisken_Degerleri.Finans_Fatura_İrsaliye.ToString(), dgwDegiskenler, _DegiskenDal);
            Dokuman_Getir(DosyaYoluFinansFaturaİrsaliye);

        }

        private void btnFuarDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.Fuar.ToString();
            //_DegiskenDal.DegiskenList(Degisken_Degerleri.Fuar.ToString(), dgwDegiskenler, _DegiskenDal);
            Dokuman_Getir(DosyaYoluFuar);

        }

        private void btnAmbarBarkodDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.Ambar_Barkod.ToString();
            //_DegiskenDal.DegiskenList(Degisken_Degerleri.Ambar_Barkod.ToString(), dgwDegiskenler, _DegiskenDal);
            Dokuman_Getir(DosyaYoluAmbarBarkod);

        }

        private void btnCariBookmarkDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.Cari_Bookmark.ToString();
            //_DegiskenDal.DegiskenList(Degisken_Degerleri.Cari_Bookmark.ToString(), dgwDegiskenler, _DegiskenDal);
            Dokuman_Getir(DosyaYoluCari);

        }

        private void btnAracFiloBookmarkDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.AraçFilo_Bookmark.ToString();
            //_DegiskenDal.DegiskenList(Degisken_Degerleri.AraçFilo_Bookmark.ToString(), dgwDegiskenler, _DegiskenDal);
            Dokuman_Getir(DosyaYoluAracFilo);

        }

        private void btnTeklifBookmarkDegiskenleri_Click(object sender, EventArgs e)
        {
            
            rdbBasanDegereGore.Enabled = true;
            rdbDegiskeneGore.Enabled = true;
            txtBasanDegereGore.Enabled = true;
            txtDegiskeneGore.Enabled = true;
            btnDegiskenGuncelle.Enabled = true;
            btnDegiskenSil.Enabled = true;
            btnDegiskenAra.Enabled = true;
            Vr_Deger = Degisken_Degerleri.Teklif_Bookmark.ToString();
            //_DegiskenDal.DegiskenList(Degisken_Degerleri.Teklif_Bookmark.ToString(), dgwDegiskenler, _DegiskenDal);
            Dokuman_Getir(DosyaYoluTeklif);

        }

        private void btnDegiskenSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(dgwDegiskenler.CurrentRow.Cells[1].Value.ToString() + " kodlu değişkeni silmek istiyor musunuz ?", "Değişken Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                /* _DegiskenDal.Degisken_Sil(new Degiskenler
                 {
                     Id = Convert.ToInt32(dgwDegiskenler.CurrentRow.Cells[0].Value.ToString())
                 });
                 MessageBox.Show("Değişken Silme İşlemi Gerçekleştirildi", "Silme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                 rdbBasanDegereGore.Enabled = false;
                 rdbDegiskeneGore.Enabled = false;
                 txtBasanDegereGore.Enabled = false;
                 txtDegiskeneGore.Enabled = false;
                 btnDegiskenGuncelle.Enabled = false;
                 btnDegiskenSil.Enabled = false;
                 btnDegiskenAra.Enabled = false;
                 dgwDegiskenler.DataSource = "";*/

                if (Vr_Deger == "Kara")
                {

                    MTDegiskenSil(DosyaYoluKara);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";


                }

                else if (Vr_Deger == "Hava")
                {

                    MTDegiskenSil(DosyaYoluHava);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";

                }

                else if (Vr_Deger == "Deniz")
                {

                    MTDegiskenSil(DosyaYoluDeniz);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";

                }

                else if (Vr_Deger == "Fatura")
                {

                    MTDegiskenSil(DosyaYoluFatura);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";

                }

                else if (Vr_Deger == "Depo_Evrak")
                {

                    MTDegiskenSil(DosyaYoluDepoEvrak);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";

                }
                else if (Vr_Deger == "Depo_Fatura")
                {

                    MTDegiskenSil(DosyaYoluDepoFatura);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";

                }

                else if (Vr_Deger == "Demiryolu")
                {

                    MTDegiskenSil(DosyaYoluDemiryolu);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";

                }

                else if (Vr_Deger == "Konteyner_Taşımacılığı")
                {

                    MTDegiskenSil(DosyaYoluKonteyner);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";

                }

                else if (Vr_Deger == "Finans_Fatura_İrsaliye")
                {

                    MTDegiskenSil(DosyaYoluFinansFaturaİrsaliye);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";

                }

                else if (Vr_Deger == "Fuar")
                {

                    MTDegiskenSil(DosyaYoluFuar);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";

                }

                else if (Vr_Deger == "Ambar_Barkod")
                {

                    MTDegiskenSil(DosyaYoluAmbarBarkod);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";

                }

                else if (Vr_Deger == "Cari_Bookmark")
                {

                    MTDegiskenSil(DosyaYoluCari);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";

                }

                else if (Vr_Deger == "AraçFilo_Bookmark")
                {

                    MTDegiskenSil(DosyaYoluAracFilo);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";

                }

                else if (Vr_Deger == "Teklif_Bookmark")
                {

                    MTDegiskenSil(DosyaYoluTeklif);
                    rdbBasanDegereGore.Enabled = false;
                    rdbDegiskeneGore.Enabled = false;
                    txtBasanDegereGore.Enabled = false;
                    txtDegiskeneGore.Enabled = false;
                    btnDegiskenGuncelle.Enabled = false;
                    btnDegiskenSil.Enabled = false;
                    btnDegiskenAra.Enabled = false;
                    dgwDegiskenler.DataSource = "";

                }




            }
            else
            {
                MessageBox.Show("Değişken Silme İşlemi Gerçekleştirilmedi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdbBasanDegereGore.Enabled = false;
                rdbDegiskeneGore.Enabled = false;
                txtBasanDegereGore.Enabled = false;
                txtDegiskeneGore.Enabled = false;
                btnDegiskenGuncelle.Enabled = false;
                btnDegiskenSil.Enabled = false;
                btnDegiskenAra.Enabled = false;
                dgwDegiskenler.DataSource = "";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelEkleme frmExcelEkleme = new ExcelEkleme();
            frmExcelEkleme.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    enum Degisken_Degerleri
    {
        Kara,
        Hava,
        Deniz,
        Fatura,
        Depo_Evrak,
        Depo_Fatura,
        Demiryolu,
        Konteyner_Taşımacılığı,
        Finans_Fatura_İrsaliye,
        Fuar,
        Ambar_Barkod,
        Cari_Bookmark,
        AraçFilo_Bookmark,
        Teklif_Bookmark,
    }
}
