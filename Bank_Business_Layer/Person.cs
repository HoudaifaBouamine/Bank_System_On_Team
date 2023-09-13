using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_Data_Layer;

namespace Bank_Business_Layer
{
    public class clsPerson
    {
        public int Person_ID { get;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        protected clsPerson(int person_ID, string firstName, string lastName, string country, string city, string street)
        {
            Person_ID = person_ID;
            FirstName = firstName;
            LastName = lastName;
            Country = country;
            City = city;
            Street = street;
        }
    }

}
