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
    public partial class DegiskenGuncelle : Form
    {
        public Dökümanlar FrmDokumanlar;

        public DegiskenGuncelle()
        {
            InitializeComponent();
        }
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


        DegiskenDal _DegiskenDal = new DegiskenDal();
        private int vr_ID;
        public void Degisken_Deger_Getir()
        {
            vr_ID = Convert.ToInt32(FrmDokumanlar.FrmDegiskenler.dgwDegiskenler.CurrentRow.Cells[0].Value.ToString()); 
            txtDegiskenAdi.Text = FrmDokumanlar.FrmDegiskenler.dgwDegiskenler.CurrentRow.Cells[1].Value.ToString();
            txtDegiskenBilgisi.Text = FrmDokumanlar.FrmDegiskenler.dgwDegiskenler.CurrentRow.Cells[2].Value.ToString();
            cmbDegiskenTuru.Text = FrmDokumanlar.FrmDegiskenler.dgwDegiskenler.CurrentRow.Cells[3].Value.ToString();
            
        }

        public void MTDokumanGuncelle(string VrDosyaYolum, string VrDegiskenNo, string VrDegiskenAdi, string VrDokumanYolu, string VrModul)
        {
          
            XDocument x = XDocument.Load(VrDosyaYolum);
            XElement node = x.Element("Degiskenler").Elements("Degisken").FirstOrDefault(a => a.Element("DegiskenNo").Value.Trim() == VrDegiskenNo);
            if (node != null)
            {
                node.SetElementValue("DegiskenKodu", VrDegiskenAdi);
                node.SetElementValue("DegiskenAciklama", VrDokumanYolu);
                node.SetElementValue("DegiskenModul", VrModul);

                x.Save(VrDosyaYolum);
                MessageBox.Show("Değişken Güncelleme Gerçekleştirildi", "Değişken Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }



        private void DegiskenGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            txtDegiskenAdi.Text = "";
            txtDegiskenBilgisi.Text = "";
            cmbDegiskenTuru.Text = "";
            FrmDokumanlar.FrmDegiskenler.dgwDegiskenler.DataSource = "";
            FrmDokumanlar.FrmDegiskenler.txtBasanDegereGore.Text = "";
            FrmDokumanlar.FrmDegiskenler.txtDegiskeneGore.Text = "";
            FrmDokumanlar.FrmDegiskenler.rdbBasanDegereGore.Checked = false;
            FrmDokumanlar.FrmDegiskenler.rdbDegiskeneGore.Checked = false;
            FrmDokumanlar.FrmDegiskenler.rdbBasanDegereGore.Enabled = false;
            FrmDokumanlar.FrmDegiskenler.rdbDegiskeneGore.Enabled = false;
            FrmDokumanlar.FrmDegiskenler.txtBasanDegereGore.Enabled = false;
            FrmDokumanlar.FrmDegiskenler.txtDegiskeneGore.Enabled = false;
            FrmDokumanlar.FrmDegiskenler.btnDegiskenGuncelle.Enabled = false;
            FrmDokumanlar.FrmDegiskenler.btnDegiskenSil.Enabled = false;
            FrmDokumanlar.FrmDegiskenler.btnDegiskenAra.Enabled = false;
            FrmDokumanlar.FrmDegiskenler.dgwDegiskenler.DataSource = "";
            FrmDokumanlar.FrmDegiskenler.pnlControls.Controls.Clear();
        }

        private void btnDegiskenGuncelle_Click(object sender, EventArgs e)
        {
            /*_DegiskenDal.Degisken_Guncelle(new Degiskenler
            {
                Id = Convert.ToInt32(FrmDokumanlar.FrmDegiskenler.dgwDegiskenler.CurrentRow.Cells[0].Value.ToString()),
                Degisken_Adi = txtDegiskenAdi.Text,
                Degisken_Bilgisi = txtDegiskenBilgisi.Text,
                Degisken_Tur = cmbDegiskenTuru.Text

        });
            MessageBox.Show("Değişken Güncelleme Tamamlandı.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            if (cmbDegiskenTuru.Text == "Kara")
            {
               
                MTDokumanGuncelle(DosyaYoluKara, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                

            }

            else if (cmbDegiskenTuru.Text == "Hava")
            {

                MTDokumanGuncelle(DosyaYoluHava, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                
            }

            else if (cmbDegiskenTuru.Text == "Deniz")
            {

                MTDokumanGuncelle(DosyaYoluDeniz, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
              
            }

            else if (cmbDegiskenTuru.Text == "Fatura")
            {

                MTDokumanGuncelle(DosyaYoluFatura, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                
            }

            else if (cmbDegiskenTuru.Text == "Depo_Evrak")
            {

                MTDokumanGuncelle(DosyaYoluDepoEvrak, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
               
            }
            else if (cmbDegiskenTuru.Text == "Depo_Fatura")
            {

                MTDokumanGuncelle(DosyaYoluDepoFatura, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
               
            }

            else if (cmbDegiskenTuru.Text == "Demiryolu")
            {

                MTDokumanGuncelle(DosyaYoluDemiryolu, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
              
            }

            else if (cmbDegiskenTuru.Text == "Konteyner_Taşımacılığı")
            {
                
                MTDokumanGuncelle(DosyaYoluKonteyner, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
               
            }

            else if (cmbDegiskenTuru.Text == "Finans_Fatura_İrsaliye")
            {
                
                MTDokumanGuncelle(DosyaYoluFinansFaturaİrsaliye, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
               
            }

            else if (cmbDegiskenTuru.Text == "Fuar")
            {
                
                MTDokumanGuncelle(DosyaYoluFuar, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
               
            }

            else if (cmbDegiskenTuru.Text == "Ambar_Barkod")
            {
                
                MTDokumanGuncelle(DosyaYoluAmbarBarkod, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
               
            }

            else if (cmbDegiskenTuru.Text == "Cari_Bookmark")
            {
                
                MTDokumanGuncelle(DosyaYoluCari, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
               
            }

            else if (cmbDegiskenTuru.Text == "AraçFilo_Bookmark")
            {
                
                MTDokumanGuncelle(DosyaYoluAracFilo, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                
            }

            else if (cmbDegiskenTuru.Text == "Teklif_Bookmark")
            {
                
                MTDokumanGuncelle(DosyaYoluTeklif, vr_ID.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                
            }



        }

        private void DegiskenGuncelle_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
