using hw13_CodeFirst.DB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hw13_CodeFirst.DB
{
    public class TopListContext : DbContext
    {
        public TopListContext()
           : base("DbConnection")
        { }

        public DbSet<Result> R { get; set; }
        public DbSet<Palyer> Players { get; set; }
    }
}
