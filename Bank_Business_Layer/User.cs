using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_Data_Layer;

namespace Bank_Business_Layer
{
    public class clsUser : clsPerson
{
    public string User_ID { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public int Permission { get; set; }

    public User(string person_ID, string firstName, string lastName, string country, string city, string street, string user_ID, string email, string password, string phone, int permission)
        : base(person_ID, firstName, lastName, country, city, street)
    {
        User_ID = user_ID;
        Email = email;
        Password = password;
        Phone = phone;
        Permission = permission;
    }
}
}
