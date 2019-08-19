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
    public partial class DokumanEkle : Form
    {
        public Dökümanlar FrmDokumanlar;
        public DokumanEkle()
        {
            
            InitializeComponent();
        }

        

        string tasinacakDosya = "", tasinacakDosyaIsmi = "", dosyaninTasinacagiKlasor = "";

        public void Bilgi_Mail_Gonder(string vr_Subject,string vr_Klasör_Dizin)
        {

            Microsoft.Office.Interop.Outlook.Application OutlookObject = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem MailObject = (Microsoft.Office.Interop.Outlook.MailItem)(OutlookObject.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem));
            MailObject.To = "helpdesk@soft.com.tr";
            MailObject.CC = "";
            MailObject.Subject ="Merhaba, " + "#"+vr_Subject+ "  "+ tasinacakDosyaIsmi + "  İsimli Döküman Yayınlandı.";
            MailObject.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceNormal;
            //string htmlString = @"<html> 
            //          <body> 
            //          <p>Dear xxxx,</p> 
            //          <p>It has been long since we...</p> 
            //          <p>Sincerely,<br>Scott</br></p> 
            //          </body> 
            //          </html> 
            //         ";
            string htmlString = $@"<html>
<head>
<meta http-equiv='Content-Language' content='tr'>
<meta http-equiv='Content-Type' content='text/html; charset=windows-1254'>
<title>Yeni Sayfa 1</title>
</head>
<body>
<form>
<br>
<br>
<br>
<table border='1' width='659' height='25' align='center'>
	<tr>
		<td height='25' width='659' colspan='2'><b>DÖKÜMAN EKLEME BİLGİSİ</b></td>
	</tr>
	<tr>
		<td height='25' width='330'><b>Döküman Uygulaması</b></td>
		<td height='25' width='329'>{vr_Subject}</td>
    </tr>
	<tr>
		<td height='25' width='330'><b>Döküman Adı</b></td>
		<td height='25' width='329'>{tasinacakDosyaIsmi}</td>
	</tr>
	<tr>
		<td height='25' width='330'><b>Döküman Yolu</b></td>
		<td height='25' width='329'>{vr_Klasör_Dizin}</td>
	</tr>
</table>
</Form>
</body>
</html>
                     ";
            MailObject.HTMLBody = htmlString;
            MailObject.Attachments.Add(tasinacakDosya, Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue, 1, "Ek Adı");
            MailObject.Send();     
            

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            cmbSec.Text = "";

            // Bilgi_Mail_Gonder("SOFTTRANS", FrmDokumanlar.SofTransDizin);
            chckMailGonder.Checked = false;
            FrmDokumanlar.Show();
            FrmDokumanlar.dizinIcerigiListView.Items.Clear();
            FrmDokumanlar.btnDokumaniAc.Enabled = false;
            FrmDokumanlar.btnDokumaniSil.Enabled = false;
            FrmDokumanlar.btnDokumaniMailGonder.Enabled = false;
            this.Hide();
        }

        private void btnDokumaniEkle_Click(object sender, EventArgs e)
        {
            // Bilgi_Mail_Gonder();

            //MessageBox.Show(tasinacakDosya);
            //MessageBox.Show(tasinacakDosyaIsmi);
            if (chckMailGonder.Checked == true)
            {
                if (cmbSec.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Eklenecek Döküman veya Döküman Tipi Seçilmemiştir.", "Döküman Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (cmbSec.Text != "" && textBox1.Text != "")
                {
                    if (cmbSec.Text == "SOFTTRANS")
                    {
                        if (FrmDokumanlar.SofTransDizin != "" && tasinacakDosya != "")
                        {
                            if (File.Exists(FrmDokumanlar.SofTransDizin + "\\" + tasinacakDosyaIsmi))
                            {
                                MessageBox.Show("Belirtilen klasörde " + tasinacakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                Bilgi_Mail_Gonder("SOFTTRANS", FrmDokumanlar.SofTransDizin);
                                File.Move(tasinacakDosya, FrmDokumanlar.SofTransDizin + "\\" + tasinacakDosyaIsmi);
                                MessageBox.Show("Dosya Taşıma İşlemi Başarılı", "Dosya Taşındı...");
                            }
                        }
                        else if (FrmDokumanlar.SofTransDizin == "")
                        {
                            MessageBox.Show("Dosyanın Taşınacağı Klasörü Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (tasinacakDosya == "")
                        {
                            MessageBox.Show("Dosya Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (cmbSec.Text == "SOFTFİNANS")
                    {
                        if (FrmDokumanlar.SoftFinansDizin != "" && tasinacakDosya != "")
                        {
                            if (File.Exists(FrmDokumanlar.SoftFinansDizin + "\\" + tasinacakDosyaIsmi))
                            {
                                MessageBox.Show("Belirtilen klasörde " + tasinacakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                Bilgi_Mail_Gonder("SOFTFİNANS", FrmDokumanlar.SoftFinansDizin);
                                File.Move(tasinacakDosya, FrmDokumanlar.SoftFinansDizin + "\\" + tasinacakDosyaIsmi);
                                MessageBox.Show("Dosya Taşıma İşlemi Başarılı", "Dosya Taşındı...");
                            }
                        }
                        else if (FrmDokumanlar.SoftFinansDizin == "")
                        {
                            MessageBox.Show("Dosyanın Taşınacağı Klasörü Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (tasinacakDosya == "")
                        {
                            MessageBox.Show("Dosya Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else if (cmbSec.Text == "EBELGEPORTAL")
                    {
                        if (File.Exists(FrmDokumanlar.SoftEBelgePortalDizin + "\\" + tasinacakDosyaIsmi))
                        {
                            MessageBox.Show("Belirtilen klasörde " + tasinacakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            Bilgi_Mail_Gonder("EBELGEPORTAL", FrmDokumanlar.SoftEBelgePortalDizin);
                            File.Move(tasinacakDosya, FrmDokumanlar.SoftEBelgePortalDizin + "\\" + tasinacakDosyaIsmi);
                            MessageBox.Show("Dosya Taşıma İşlemi Başarılı", "Dosya Taşındı...");
                        }
                    }
                    else if (FrmDokumanlar.SoftEBelgePortalDizin == "")
                    {
                        MessageBox.Show("Dosyanın Taşınacağı Klasörü Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (tasinacakDosya == "")
                    {
                        MessageBox.Show("Dosya Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else if (chckMailGonder.Checked == false)
            {
                if (cmbSec.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Eklenecek Döküman veya Döküman Tipi Seçilmemiştir.", "Döküman Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (cmbSec.Text != "" && textBox1.Text != "")
                {
                    if (cmbSec.Text == "SOFTTRANS")
                    {
                        if (FrmDokumanlar.SofTransDizin != "" && tasinacakDosya != "")
                        {
                            if (File.Exists(FrmDokumanlar.SofTransDizin + "\\" + tasinacakDosyaIsmi))
                            {
                                MessageBox.Show("Belirtilen klasörde " + tasinacakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                File.Move(tasinacakDosya, FrmDokumanlar.SofTransDizin + "\\" + tasinacakDosyaIsmi);
                                MessageBox.Show("Dosya Taşıma İşlemi Başarılı", "Dosya Taşındı...");
                            }
                        }
                        else if (FrmDokumanlar.SofTransDizin == "")
                        {
                            MessageBox.Show("Dosyanın Taşınacağı Klasörü Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (tasinacakDosya == "")
                        {
                            MessageBox.Show("Dosya Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (cmbSec.Text == "SOFTFİNANS")
                    {
                        if (FrmDokumanlar.SoftFinansDizin != "" && tasinacakDosya != "")
                        {
                            if (File.Exists(FrmDokumanlar.SoftFinansDizin + "\\" + tasinacakDosyaIsmi))
                            {
                                MessageBox.Show("Belirtilen klasörde " + tasinacakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                File.Move(tasinacakDosya, FrmDokumanlar.SoftFinansDizin + "\\" + tasinacakDosyaIsmi);
                                MessageBox.Show("Dosya Taşıma İşlemi Başarılı", "Dosya Taşındı...");
                            }
                        }
                        else if (FrmDokumanlar.SoftFinansDizin == "")
                        {
                            MessageBox.Show("Dosyanın Taşınacağı Klasörü Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (tasinacakDosya == "")
                        {
                            MessageBox.Show("Dosya Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else if (cmbSec.Text == "EBELGEPORTAL")
                    {
                        if (File.Exists(FrmDokumanlar.SoftEBelgePortalDizin + "\\" + tasinacakDosyaIsmi))
                        {
                            MessageBox.Show("Belirtilen klasörde " + tasinacakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            File.Move(tasinacakDosya, FrmDokumanlar.SoftEBelgePortalDizin + "\\" + tasinacakDosyaIsmi);
                            MessageBox.Show("Dosya Taşıma İşlemi Başarılı", "Dosya Taşındı...");
                        }
                    }
                    else if (FrmDokumanlar.SoftEBelgePortalDizin == "")
                    {
                        MessageBox.Show("Dosyanın Taşınacağı Klasörü Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (tasinacakDosya == "")
                    {
                        MessageBox.Show("Dosya Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
          

            textBox1.Text = "";
            cmbSec.Text = "";
            chckMailGonder.Checked = false;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Outlook.Application OutlookObject = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem MailObject = (Microsoft.Office.Interop.Outlook.MailItem)(OutlookObject.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem));
            MailObject.To = "ersin.SIK@soft.com.tr";
            MailObject.CC = "";
            MailObject.Subject = "#Test" + tasinacakDosyaIsmi + "  İsimli Döküman Yayınlandı.";
            MailObject.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceNormal;
            string htmlString = $@"<html>
<head>
<meta http-equiv='Content-Language' content='tr'>
<meta http-equiv='Content-Type' content='text/html; charset=windows-1254'>
<title>Yeni Sayfa 1</title>
</head>
<body>
<form>
<table border='1' width='659' height='25' align='center'>
	<tr>
		<td height='25' width='659' colspan='2'><b>DÖKÜMAN EKLEME BİLGİSİ</b></td>
	</tr>
	<tr>
		<td height='25' width='330'>Döküman Uygulaması</td>
		<td height='25' width='329'>{FrmDokumanlar.SoftEBelgePortalDizin}</td>
    </tr>
	<tr>
		<td height='25' width='330'>Döküman Adı</td>
		<td height='25' width='329'>{tasinacakDosyaIsmi}</td>
	</tr>
	<tr>
		<td height='25' width='330'>Döküman Yolu</td>
		<td height='25' width='329'>{textBox1.Text}</td>
	</tr>
</table>
</Form>
</body>
</html>
                     ";
            MailObject.HTMLBody = htmlString;
            //MailObject.Attachments.Add(tasinacakDosya, Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue, 1, "Ek Adı");
            MailObject.Send();
        }

        private void DokumanEkle_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DokumanEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Taşınacak Dosyayı Seçiniz...";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tasinacakDosyaIsmi = openFileDialog1.SafeFileName.ToString();
                tasinacakDosya = openFileDialog1.FileName.ToString();
                textBox1.Text = tasinacakDosya;
            }
            else
            {
                MessageBox.Show("Dosya Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
