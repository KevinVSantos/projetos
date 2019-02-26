using SiteDoZero.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteDoZero.Data
{
    public class DataContexte : DbContext
    {
        //public DataContexte() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SiteDoZero;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        //{
        //    Database.SetInitializer(new DbInitializer());
        //}

        //public DbSet<Produto> MyProperty { get; set; }

    }
}
