using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using seance2;
using System.Data.Entity;

namespace TestSeance2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CompanyContext>());
            CompanyContext ctx = new CompanyContext();
            Customer customer = new Customer();
            customer.AccountBalance = 2000.38;
            customer.AddressLine1 = "Rue du palton 110b bte 5";
            customer.AddressLine2 = "Route d eghezee 98";
            customer.City = "Sambreville";
            customer.Country = "Belgium";
            customer.EMail = "tatata@gmail.com";
            customer.Id = 1;
            customer.Name = "Tourneur";
            customer.PostCode = "5000";
            customer.Remark = "Just not perfect";

            ctx.Customers1.Add(customer);

            ctx.SaveChanges();
            
        }

        public void VerifyDatabaseIsNotEmpty()
        {
            CompanyContext ctx = new CompanyContext();
            

        }
    }
}
