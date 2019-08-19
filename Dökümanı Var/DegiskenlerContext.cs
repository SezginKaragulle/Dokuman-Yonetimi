using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;


namespace Dökümanı_Var
{
  public class DegiskenlerContext:DbContext
    {
        public DbSet<Degiskenler> Degiskenlerim { get; set; }
    }
}
