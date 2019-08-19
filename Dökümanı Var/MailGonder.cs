using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dökümanı_Var
{
    public partial class MailGonder : Form
    {
        public Dökümanlar FrmDokumanlar;
        public MailGonder()
        {
            InitializeComponent();
        }
        public void Bilgi_Mail_Gonder()
        {

            Microsoft.Office.Interop.Outlook.Application OutlookObject = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem MailObject = (Microsoft.Office.Interop.Outlook.MailItem)(OutlookObject.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem));
            MailObject.To = txtMailTo.Text.Trim();
            MailObject.CC = txtMailCC.Text.Trim();
            MailObject.Subject = txtMailSubject.Text;
            MailObject.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceNormal;
            //string htmlString = @"<html> 
            //          <body> 
            //          <p>Dear xxxx,</p> 
            //          <p>It has been long since we...</p> 
            //          <p>Sincerely,<br>Scott</br></p> 
            //          </body> 
            //          </html> 
            //         ";

            MailObject.Body = txtMailBody.Text;
            MailObject.Attachments.Add(FrmDokumanlar.DosyaUzantisi, Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue, 1, FrmDokumanlar.DosyaBilgisi);
            MailObject.Send();


        }
        
        private void MailGonder_Load(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtMailTo.Text == "" || txtMailSubject.Text == "")
            {
                MessageBox.Show("Mail Gönderilecek Adres Alanı ve Konu Alanları Boş Olamaz","Mail Gönder",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                Bilgi_Mail_Gonder();
                txtMailTo.Text = "";
                txtMailCC.Text = "";
                txtMailSubject.Text = "";
                txtMailBody.Text = "";
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            txtMailTo.Text = "";
            txtMailCC.Text = "";
            txtMailSubject.Text = "";
            txtMailBody.Text = "";
            txtMailAtt.Text = "";
            FrmDokumanlar.Show();
            FrmDokumanlar.dizinIcerigiListView.Items.Clear();
            FrmDokumanlar.btnDokumaniAc.Enabled = false;
            FrmDokumanlar.btnDokumaniSil.Enabled = false;
            FrmDokumanlar.btnDokumaniMailGonder.Enabled = false;
            FrmDokumanlar.DosyaUzantisi = "";
            FrmDokumanlar.DosyaBilgisi = "";
            this.Hide();
        }
    }
}
