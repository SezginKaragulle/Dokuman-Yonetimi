using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dökümanı_Var
{
    public partial class Dökümanlar : Form
    {
        public DokumanEkle FrmDokumanEkle;
        public Değişkenler FrmDegiskenler;
        public DegiskenEkle FrmDegiskenEkle;
        public DegiskenGuncelle FrmDegiskenGuncelle;
        public ExcelEkleme FrmExcelEkleme;
        public MailGonder FrmMailGonder;
        public Dökümanlar()
        {
            FrmDokumanEkle = new DokumanEkle();
            FrmDegiskenler = new Değişkenler();
            FrmDegiskenEkle = new DegiskenEkle();
            FrmDegiskenGuncelle = new DegiskenGuncelle();
            FrmExcelEkleme = new ExcelEkleme();
            FrmMailGonder = new MailGonder();
            FrmMailGonder.FrmDokumanlar = this;
            FrmDegiskenGuncelle.FrmDokumanlar = this;
            FrmDegiskenEkle.FrmDokumanlar = this;
            FrmDegiskenler.FrmDokumanlar = this;
            FrmDokumanEkle.FrmDokumanlar = this;
            FrmExcelEkleme.FrmDokumanlar = this;
            InitializeComponent();
        }

        public void DokListem(string vr_Dizin)
        {
            dizinIcerigiListView.Items.Clear();
            string[] dizindekiKlasorler = Directory.GetDirectories(vr_Dizin);
            string[] dizindekiDosyalar = Directory.GetFiles(vr_Dizin);
            foreach (string klasor in dizindekiKlasorler)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(klasor);
                string klasorAdi = dirInfo.Name;
                DateTime olsTarihi = dirInfo.CreationTime;

                ListViewItem item = new ListViewItem(klasorAdi);
                item.SubItems.Add("Klasör");
                item.SubItems.Add("");
                item.SubItems.Add(olsTarihi.ToString("dd.MM.yyyy HH:mm"));

                dizinIcerigiListView.Items.Add(item);
            }
            foreach (string dosya in dizindekiDosyalar)
            {
                FileInfo fileInfo = new FileInfo(dosya);

                string dosyaAdi = fileInfo.Name;
                long byteBoyut = fileInfo.Length;
                DateTime olsTarihi = fileInfo.CreationTime;

                ListViewItem item = new ListViewItem(dosyaAdi);
                item.SubItems.Add("Dosya");
                item.SubItems.Add(byteBoyut.ToString());
                item.SubItems.Add(olsTarihi.ToString("dd.MM.yyyy HH:mm"));
                dizinIcerigiListView.Items.Add(item);
            }
        }

       public string SofTransDizin = @"U:\HelpDesk\DÖKÜMANLAR\SOFTRANS";
       public string SoftFinansDizin = @"U:\HelpDesk\DÖKÜMANLAR\SOFTFİNANS";
       public string SoftEBelgePortalDizin = @"U:\HelpDesk\DÖKÜMANLAR\EBELGEPORTAL";
       public string AcilacakDeger;
       public string DosyaUzantisi;
       public string DosyaBilgisi;
        private void btnSoftTrans_Click(object sender, EventArgs e)
        {
            btnDokumaniAc.Enabled = true;
            btnDokumaniSil.Enabled = true;
            btnDokumaniMailGonder.Enabled = true;
            AcilacakDeger = "SOFTRANS";
            DokListem(SofTransDizin);
            
        }

        private void btnDokumaniAc_Click(object sender, EventArgs e)
        {
                               

            if (AcilacakDeger == "SOFTRANS")
            {
                string deger = dizinIcerigiListView.SelectedItems[0].Text.ToString();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/K" + SofTransDizin + "\\" + deger;
                process.StartInfo = startInfo;
                process.Start();
            }
          else  if (AcilacakDeger == "SOFTFİNANS")
            {
                string deger = dizinIcerigiListView.SelectedItems[0].Text.ToString();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/K" + SoftFinansDizin + "\\" + deger;
                process.StartInfo = startInfo;
                process.Start();
            }
            else if (AcilacakDeger == "EBELGEPORTAL")
            {
                string deger = dizinIcerigiListView.SelectedItems[0].Text.ToString();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/K" + SoftEBelgePortalDizin + "\\" + deger;
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        private void btnSoftFinans_Click(object sender, EventArgs e)
        {
            btnDokumaniAc.Enabled = true;
            btnDokumaniSil.Enabled = true;
            btnDokumaniMailGonder.Enabled = true;
            AcilacakDeger = "SOFTFİNANS";
            DokListem(SoftFinansDizin);
        }

        private void btnEBelgePortal_Click(object sender, EventArgs e)
        {
            btnDokumaniAc.Enabled = true;
            btnDokumaniSil.Enabled = true;
            btnDokumaniMailGonder.Enabled = true;
            AcilacakDeger = "EBELGEPORTAL";
            DokListem(SoftEBelgePortalDizin);
        }

        private void Dökümanlar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnDokumanEkle_Click(object sender, EventArgs e)
        {
            FrmDokumanEkle.Show();
            this.Hide();
        }

        private void Dökümanlar_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDokumaniSil_Click(object sender, EventArgs e)
        {

        }

        private void btnDokumaniSil_Click_1(object sender, EventArgs e)
        {
            DialogResult yanit;
            yanit = MessageBox.Show("Dökümanı Silmek İstiyor musunuz ?", "Dökümanı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (yanit == DialogResult.Yes)
            {
                if (AcilacakDeger == "SOFTRANS")
                {
                    File.Delete(SofTransDizin + "\\" + dizinIcerigiListView.SelectedItems[0].Text.ToString());
                    dizinIcerigiListView.Items.Clear();
                }
                else if (AcilacakDeger == "SOFTFİNANS")
                {
                    File.Delete(SoftFinansDizin + "\\" + dizinIcerigiListView.SelectedItems[0].Text.ToString());
                    dizinIcerigiListView.Items.Clear();
                }
                else if (AcilacakDeger == "EBELGEPORTAL")
                {
                    File.Delete(SoftEBelgePortalDizin + "\\" + dizinIcerigiListView.SelectedItems[0].Text.ToString());
                    dizinIcerigiListView.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("İşlem Tamamlanmamıştır", "Dökümanı Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            
        }

        private void btnDegiskenler_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Düzenleme yapılıyor");
            FrmDegiskenler.Show();
            //FrmDegiskenler.Degisken_Yukle();
            FrmDegiskenler.rdbBasanDegereGore.Enabled = false;
            FrmDegiskenler.rdbDegiskeneGore.Enabled = false;
            FrmDegiskenler.txtBasanDegereGore.Enabled = false;
            FrmDegiskenler.txtDegiskeneGore.Enabled = false;
            FrmDegiskenler.btnDegiskenGuncelle.Enabled = false;
            FrmDegiskenler.btnDegiskenSil.Enabled = false;
            FrmDegiskenler.btnDegiskenAra.Enabled = false;
            FrmDegiskenler.dgwDegiskenler.DataSource = "";
            this.Hide();
        }

        private void btnDokumaniMailGonder_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(SofTransDizin + "\\" + dizinIcerigiListView.SelectedItems[0].Text.ToString() + " " + AcilacakDeger);

            if (AcilacakDeger == "SOFTRANS")
            {
                DosyaUzantisi = SofTransDizin + "\\" + dizinIcerigiListView.SelectedItems[0].Text.ToString();
                DosyaBilgisi = dizinIcerigiListView.SelectedItems[0].Text.ToString();
                FrmMailGonder.Show();
                FrmMailGonder.txtMailAtt.Text = DosyaUzantisi;
                this.Hide();

            }
            else if (AcilacakDeger == "SOFTFİNANS")
            {
                DosyaUzantisi = SoftFinansDizin + "\\" + dizinIcerigiListView.SelectedItems[0].Text.ToString();
                DosyaBilgisi = dizinIcerigiListView.SelectedItems[0].Text.ToString();
                FrmMailGonder.Show();
                FrmMailGonder.txtMailAtt.Text = DosyaUzantisi;
                this.Hide();
            }
            else if (AcilacakDeger == "EBELGEPORTAL")
            {
                DosyaUzantisi = SoftEBelgePortalDizin + "\\" + dizinIcerigiListView.SelectedItems[0].Text.ToString();
                DosyaBilgisi = dizinIcerigiListView.SelectedItems[0].Text.ToString();
                FrmMailGonder.Show();
                FrmMailGonder.txtMailAtt.Text = DosyaUzantisi;
                this.Hide();
            }

        }
    }
}
