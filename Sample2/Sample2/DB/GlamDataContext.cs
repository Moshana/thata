using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    public class GlamDataContext: DbContext
    {

        public GlamDataContext() : base("name=Sample2.GlamDataContext")
        {
            //Database.Migrate();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }

}
