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
    public string User_ID { get; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public int Permission { get; set; }

    public clsUser(int person_ID, string firstName, string lastName, string country, string city, string street, string user_ID, string email, string password, string phone, int permission)
        : base(person_ID, firstName, lastName, country, city, street)
    {
        User_ID = user_ID;
        Email = email;
        Password = password;
        Phone = phone;
        Permission = permission;
    }

    public clsUser FindUser(int User_ID, ref int Person_ID, ref string FirstName, 
                    ref string LastName,ref string Country,ref string City,
                    ref string Street,ref string Email,ref string Password,
                    ref string Phone,ref int Permission){

                        if (clsDataAccessLayer.Find_User_By_ID(int User_ID, ref int Person_ID, ref string FirstName, 
                            ref  LastName,ref  Country,ref  City,ref  Street,
                            ref  Email,ref  Password,ref  Phone,ref  Permission){
clsUser
    })
                        {
                            User_ID = User_ID ; 
                            Person_ID = Person_ID ; 
                            FirstName = FirstName ; 
                            Street = Street ; 
                            Email = Email ; 
                            Password = Password ; 
                            Phone = Phone ; 
                            Permission = Permission ; 
                        }
                        else
                        {
                            return null ; 
                        }            

                                        }
    
}
}
