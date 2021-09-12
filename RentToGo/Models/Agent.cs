using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentToGo.Models
{
    public class Agent
    {
        public int Id { get; set; }
        public Customer Cust_ { get; set; }
        public Property Property_ { get; set; }
        public string Agent_Name { get; set; }
        public string Agent_Email { get; set; }
        public string Agent_Mobile { get; set; }
        public string Office_Location { get; set; }
    }
}
