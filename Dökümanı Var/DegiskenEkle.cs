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
    public partial class DegiskenEkle : Form
    {
        public Dökümanlar FrmDokumanlar;
        public DegiskenEkle()
        {
            InitializeComponent();
        }
        DegiskenDal _DegiskenDal = new DegiskenDal();
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
        int YeniSayacDeger;
        public void MTSayac()
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(FrmDokumanlar.FrmDegiskenler.DosyaYoluSayac);

            XmlNode SecilenNode = xmlDoc.ChildNodes[1];
            foreach (XmlNode item in SecilenNode)
            {
                //textBox1.Text = item.Attributes["SayacNo"].Value.ToString();
                YeniSayacDeger = int.Parse(item.Attributes["SayacNo"].Value.ToString());
                YeniSayacDeger = YeniSayacDeger + 1;
                //MessageBox.Show(YeniSayacDeger.ToString());
              

            }

        }

        public void MTDegiskenEkle(string VrDosyaYolum, string VrDegiskenNo, string VrDegiskenKodu, string VrDegiskenAciklama, string VrDegiskenModul)
        {


            XDocument x = XDocument.Load(VrDosyaYolum);

            x.Element("Degiskenler").Add(
            new XElement("Degisken",
            new XElement("DegiskenNo", VrDegiskenNo),
            new XElement("DegiskenKodu", VrDegiskenKodu),
            new XElement("DegiskenAciklama", VrDegiskenAciklama),
            new XElement("DegiskenModul", VrDegiskenModul)
            ));

            x.Save(VrDosyaYolum);
            MessageBox.Show("Değişken Eklemesi Başarıyla Gerçekleştirildi", "Değişken Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void MTDegiskenSayacYenile(string VrSonSayac)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(DosyaYoluSayac);

            XmlElement myElement = xmlDoc.CreateElement("Sayac");

            XmlAttribute attSonSayac = xmlDoc.CreateAttribute("SayacNo");

            attSonSayac.Value = VrSonSayac;
            myElement.Attributes.Append(attSonSayac);
            xmlDoc.DocumentElement.AppendChild(myElement);
            xmlDoc.Save(DosyaYoluSayac);

        }


        private void DegiskenEkle_Load(object sender, EventArgs e)
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

        private void btnDegiskenEkle_Click(object sender, EventArgs e)
        {
            //_DegiskenDal.Degisken_Ekle(new Degiskenler
            //{
            //    Degisken_Adi = txtDegiskenAdi.Text,
            //    Degisken_Bilgisi = txtDegiskenBilgisi.Text,
            //    Degisken_Tur = cmbDegiskenTuru.Text
            //});
            //MessageBox.Show("Değişken Ekleme Tamamlandı.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //txtDegiskenAdi.Text = "";
            //txtDegiskenBilgisi.Text = "";
            //cmbDegiskenTuru.Text = "";
            //MessageBox.Show(YeniSayacDeger.ToString());
            //MessageBox.Show(FrmDokumanlar.FrmDegiskenler.Vr_Deger);

            if (cmbDegiskenTuru.Text == "Kara")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluKara, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";

            }

            else if (cmbDegiskenTuru.Text == "Hava")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluHava, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";
            }

            else if (cmbDegiskenTuru.Text == "Deniz")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluDeniz, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";
            }

            else if (cmbDegiskenTuru.Text == "Fatura")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluFatura, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";
            }

            else if (cmbDegiskenTuru.Text == "Depo_Evrak")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluDepoEvrak, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";
            }
            else if (cmbDegiskenTuru.Text == "Depo_Fatura")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluDepoFatura, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";
            }

            else if (cmbDegiskenTuru.Text == "Demiryolu")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluDemiryolu, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";
            }

            else if (cmbDegiskenTuru.Text == "Konteyner_Taşımacılığı")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluKonteyner, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";
            }

            else if (cmbDegiskenTuru.Text == "Finans_Fatura_İrsaliye")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluFinansFaturaİrsaliye, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";
            }

            else if (cmbDegiskenTuru.Text == "Fuar")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluFuar, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";
            }

            else if (cmbDegiskenTuru.Text == "Ambar_Barkod")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluAmbarBarkod, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";
            }

            else if (cmbDegiskenTuru.Text == "Cari_Bookmark")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluCari, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";
            }

            else if (cmbDegiskenTuru.Text == "AraçFilo_Bookmark")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluAracFilo, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";
            }

            else if (cmbDegiskenTuru.Text == "Teklif_Bookmark")
            {
                MTSayac();
                MTDegiskenSayacYenile(YeniSayacDeger.ToString());
                MTDegiskenEkle(DosyaYoluTeklif, YeniSayacDeger.ToString(), txtDegiskenAdi.Text, txtDegiskenBilgisi.Text, cmbDegiskenTuru.Text);
                txtDegiskenAdi.Text = "";
                txtDegiskenBilgisi.Text = "";
                cmbDegiskenTuru.Text = "";
            }

        }

        private void DegiskenEkle_KeyPress(object sender, KeyPressEventArgs e)
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
