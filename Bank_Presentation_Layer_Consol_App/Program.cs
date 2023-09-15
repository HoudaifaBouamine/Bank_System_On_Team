using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_Business_Layer;
using System.IO;
using System.Security.Policy;

namespace Bank_Presentation_Layer_Consol_App
{
    internal class Program
    {

        static void print_user(clsUser user)
        {
             Console.WriteLine($"User_ID    : {user.User_ID   }");
             Console.WriteLine($"Person_ID  : {user.Person_ID }");
             Console.WriteLine($"FirstName  : {user.FirstName }");
             Console.WriteLine($"LastName   : {user.LastName  }");
             Console.WriteLine($"Country    : {user.Country   }");
             Console.WriteLine($"City       : {user.City      }");
             Console.WriteLine($"Street     : {user.Street    }");
             Console.WriteLine($"Email      : {user.Email     }");
             Console.WriteLine($"Password   : {user.Password  }");
             Console.WriteLine($"Phone      : {user.Phone     }");
             Console.WriteLine($"Permission : {user.Permission}");
        }
        static void find_user(int id)
        {

            clsUser user = clsUser.find(id);

            if (user == null)
            {
                Console.WriteLine($"User [{id}] Not Found\n\n");
            }
            else
            {
                print_user(user);
            }
        }

        static void update_user_phone(int id,string phone)
        {
            clsUser user =clsUser.find(id);

            if(user != null)
            {
                user.Phone = phone;

                if (!user.save())
                {
                    Console.WriteLine("Error, Con not save \n\n\n");
                }
            }
        }

        static void Main(string[] args)
        {
            find_user(1);

            //update_user_phone(1,"-3242342423");

            find_user(1);


            Console.ReadKey();
        }
    }
}
