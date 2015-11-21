using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seance2
{
    public class Customer
    {
        private double accountBalance;

        public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        private string addressLine1;

        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }
        private string addressLine2;

        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private string eMail;

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string postCode;

        public string PostCode
        {
            get { return postCode; }
            set { postCode = value; }
        }
        private string remark;

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        [Timestamp]
        public byte[] RowVersion { get; set; }
        //Numéro de version de l'utilisateur pour détecter les accès concurrent.
    }
}
