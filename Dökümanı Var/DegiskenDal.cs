using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Dökümanı_Var
{
   public class DegiskenDal
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBTest;Integrated Security=True");
        DataTable tbl = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public List<Degiskenler> GetAll()
        {
            using (DegiskenlerContext context = new DegiskenlerContext())
            {
                return context.Degiskenlerim.ToList();
            }
        }

        public void Degiskenleri_Getir(DataGridView dr_Grid)
        {
            tbl.Clear();
            connect.Open();
            SqlDataAdapter Degiskenler = new SqlDataAdapter("Select * From tblTablom", connect);
            Degiskenler.Fill(tbl);
            dr_Grid.DataSource = tbl;
            connect.Close();
           
        }
        
        public void Degisken_Ekle(Degiskenler degiskenler)
        {
            using (DegiskenlerContext context = new DegiskenlerContext())
            {
                var entity = context.Entry(degiskenler);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Degisken_Guncelle(Degiskenler degiskenler)
        {
            using (DegiskenlerContext context = new DegiskenlerContext())
            {
                var entity = context.Entry(degiskenler);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DegiskenList(string key,DataGridView dtGrid,DegiskenDal _productDal)
        {
            var result = _productDal.GetAll().Where(p=>p.Degisken_Tur.Contains(key)).ToList();
            //var result = _productDal.GetByName(key);

            dtGrid.DataSource = result;
            dtGrid.Columns[0].HeaderText = "ID";
            dtGrid.Columns[1].HeaderText = "DEĞİŞKEN ADI";
            dtGrid.Columns[2].HeaderText = "DEĞİŞKEN BİLGİSİ";
            dtGrid.Columns[3].HeaderText = "DEĞİŞKEN TÜRÜ";
        }
        public void DegiskenKodAra(string key, DataGridView dtGrid, DegiskenDal _productDal)
        {
            var result = _productDal.GetAll().Where(p => p.Degisken_Adi.ToLower().Contains(key.ToLower())).ToList();
            //var result = _productDal.GetByName(key);
            dtGrid.DataSource = result;
        }
        public void DegiskenBilgiAra(string key, DataGridView dtGrid, DegiskenDal _productDal)
        {
            var result = _productDal.GetAll().Where(p => p.Degisken_Bilgisi.ToLower().Contains(key.ToLower())).ToList();
            //var result = _productDal.GetByName(key);
            dtGrid.DataSource = result;
        }
        public void Degisken_Sil(Degiskenler degiskenler)
        {
            using (DegiskenlerContext context = new DegiskenlerContext())
            {
                var entity = context.Entry(degiskenler);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
