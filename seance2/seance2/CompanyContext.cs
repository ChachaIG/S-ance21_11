using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seance2
{
    public class CompanyContext : DbContext
    {
        private DbSet<Customer> Customers;

        public DbSet<Customer> Customers1
        {
            get { return Customers; }
            set { Customers = value; }
        }
        public CompanyContext()
            : base(@"Data Source=vm-sql.iesn.be\stu3ig;Initial Catalog=DBIG3A6;User ID=IG3A6;Password=***********")
        {
               
        }

    }
	
}
