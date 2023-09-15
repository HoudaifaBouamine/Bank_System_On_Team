﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_Data_Layer;
using System.IO;

namespace Bank_Business_Layer
{
    public class clsPerson
    {

        protected int  _person_id;
        public int Person_ID { get { return _person_id; } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        protected clsPerson(int person_ID, string firstName, string lastName, string country, string city, string street)
        {
            _person_id = person_ID;
            FirstName = firstName;
            LastName = lastName;
            Country = country;
            City = city;
            Street = street;
        }

        protected clsPerson()
        {
            _person_id = -1;
            FirstName = "";
            LastName = "";
            Country = "";
            City = "";
            Street = "";
        }
    }

}
