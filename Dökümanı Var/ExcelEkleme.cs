using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;



namespace Dökümanı_Var
{
    public partial class ExcelEkleme : Form
    {
        public Dökümanlar FrmDokumanlar;
       
        public ExcelEkleme()
        {
            InitializeComponent();
        }
         string DosyaYoluSayac = System.Windows.Forms.Application.StartupPath + "\\DegiskenSayac.xml";
        //string DosyaYoluDokuman = System.Windows.Forms.Application.StartupPath + "\\Degiskenler.xml";
        public string DosyaYoluKara = System.Windows.Forms.Application.StartupPath + "\\DegiskenKara.xml";
        public string DosyaYoluHava = System.Windows.Forms.Application.StartupPath + "\\DegiskenHava.xml";
        public string DosyaYoluDeniz = System.Windows.Forms.Application.StartupPath + "\\DegiskenDeniz.xml";
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
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBTest;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DegiskenDal _DegiskenDal = new DegiskenDal();
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
                MessageBox.Show(YeniSayacDeger.ToString());

            }

        }
        public void MTDokumanEkle(string VrDokumanNo, string VrDokumanAdi, string VrDosyaYolu, string VrModul)
        {
           
            XDocument x = XDocument.Load(DosyaYoluTeklif);

            x.Element("Degiskenler").Add(
            new XElement("Degisken",
            new XElement("DegiskenNo", VrDokumanNo),
            new XElement("DegiskenKodu", VrDokumanAdi),
            new XElement("DegiskenAciklama", VrDosyaYolu),
            new XElement("DegiskenModul", VrModul)
            ));

            x.Save(DosyaYoluTeklif);
            

        }

        private void ExcelEkleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string con = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=K:\degiskenler.xlsx;" + @"Extended Properties='Excel 12.0;HDR=Yes;'";
            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [Sayfa1$]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listBox1.Items.Add(dr[0].ToString());
                        listBox2.Items.Add(dr[1].ToString());
                        listBox3.Items.Add(dr[2].ToString());


                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.Items[1].ToString());
            //MessageBox.Show(listBox2.Items[1].ToString());


            for (int i = 0; i <=listBox1.Items.Count ; i++)
            {
                if (listBox1.Items[i].ToString() == "")
                {
                    MessageBox.Show("Ekleme Bitti");
                    break;
                }
                else
                {
                    //MessageBox.Show(listBox1.Items[i].ToString().Substring(0,22));
                    //MessageBox.Show(listBox1.Items[i].ToString().Substring(22));
                    //_DegiskenDal.Degisken_Ekle(new Degiskenler
                    //{
                    //    Degisken_Adi = listBox1.Items[i].ToString(),
                    //    Degisken_Bilgisi = listBox2.Items[i].ToString(),
                    //    //Degisken_Adi = listBox1.Items[i].ToString().Substring(0, 22),
                    //    //Degisken_Bilgisi = listBox1.Items[i].ToString().Substring(22),
                    //    Degisken_Tur = "Teklif_Bookmark"
                    //});
                    //MTSayac();
                    MTDokumanEkle(i.ToString(), listBox1.Items[i].ToString(), listBox2.Items[i].ToString(), listBox3.Items[i].ToString());
                    //connect.Open();
                    //cmd.Connection = connect;
                    //cmd.CommandText = "Insert Into tblTablom (Ad,Soyad) Values ('" + listBox1.Items[i].ToString() + "','" + listBox2.Items[i].ToString() + "')";
                    //cmd.ExecuteNonQuery();
                    //connect.Close();


                }
                

            }
            

        }
    }
}
