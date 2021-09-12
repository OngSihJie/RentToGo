using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentToGo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Cust_FirstName { get; set; }
        public string Cust_LastName { get; set; }
        public string Cust_Address { get; set; }
        public string Cust_Country { get; set; }
        public string Cust_Username { get; set; }
        public string Cust_Password { get; set; }
    }
}
