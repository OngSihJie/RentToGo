using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentToGo.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Property_Name { get; set; }
        public string Property_WeeklyRent { get; set; }
        public string Property_Number_of_Bedrooms { get; set; }
        public string Property_Number_of_Bathrooms { get; set; }
        public string Property_Location { get; set; }
    }
}
