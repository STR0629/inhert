using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhert
{
    internal class Customer
    {
        internal int customersid;
        int customerid;
        string name;
        string email;
        int phone;
        public int Customerid{
            get { return customerid; }
            set { customerid = value; }
        }
         public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
       
       public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        /*public Customer()
        { }
        public Customer(int id  ,string name,string email, int phone)
        {
            customerid = id;
            this.name = name;
            this.email = email; 
            this.phone = phone; 
        }
        public int Customerid
        {
            get { return customerid; }
        }
        public string Name
        {
            get { return name; }

        }
        public string Email
        {
            get { return email; }

        }
        public int Phone
        {
            get { return phone; }
        }*/
    }
}
