using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_Business_Layer;
using System.IO;
using System.Security.Policy;
using System.Net;

namespace Bank_Presentation_Layer_Consol_App
{
    internal class Program
    {

        static void print_user(clsUser user)
        {

            Console.WriteLine($"===============================");
            Console.WriteLine($"=      User Info              =");
            Console.WriteLine($"===============================");
            Console.WriteLine($" User_ID    : {user.User_ID   }");
            Console.WriteLine($" Person_ID  : {user.Person_ID }");
            Console.WriteLine($" UserName  : {user.UserName }");
            Console.WriteLine($" FirstName  : {user.FirstName }");
            Console.WriteLine($" LastName   : {user.LastName  }");
            Console.WriteLine($" Country    : {user.Country   }");
            Console.WriteLine($" City       : {user.City      }");
            Console.WriteLine($" Street     : {user.Street    }");
            Console.WriteLine($" Email      : {user.Email     }");
            Console.WriteLine($" Password   : {user.Password  }");
            Console.WriteLine($" Phone      : {user.Phone     }");
            Console.WriteLine($" Permission : {user.Permission}");
            Console.WriteLine($"===============================\n\n");
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

        static void add_new_user()
        {
            clsUser new_user = new clsUser();


            new_user.FirstName  = "Houdaifa";
            new_user.LastName   = "Bouamine";
            new_user.UserName = "Admin";
            new_user.Country    = "Algeria";
            new_user.City       = "Souk-Ahras";
            new_user.Street     = "Home";
            new_user.Email      = "houdaifa@gmail.com";
            new_user.Password   = "password123";
            new_user.Phone      = "0987654321";
            new_user.Permission = -1;

            if(new_user.save())
            {
                Console.WriteLine($"User saved succssfuly with id = {new_user.User_ID}");
            }
            else
            {
                Console.WriteLine("User Failed to add");
            }
        }

        static void print_users_list()
        {
            DataTable list_users = clsUser.list();

            if(list_users.Rows.Count < 1)
            {
                Console.WriteLine("Empty list");
            }

            foreach(DataRow user in list_users.Rows) print_user(new clsUser( user));
        }



        static public void Print_user_list_as_table()
        {
            DataTable list_users = clsUser.list();

            if (list_users.Rows.Count < 1)
            {
                Console.WriteLine("Empty list");
            }


     
            foreach (DataRow user in list_users.Rows)
            {
                Console.WriteLine($"{user["User_ID"],-6} | {user["UserName"],-15} | {user["FirstName"],-15} | {user["LastName"],-15} | {user["Permission"],-5}");
            }
            
        }


        static void delete_user(int id)
        {
            clsUser user = clsUser.find(id);

            if (user == null)
            {

                Console.WriteLine("\n\nUser not found\n\n");
            }

            else
            {
                print_user(user);


                Console.WriteLine("Are you sure to delete this user ?[y/n] >> ");
                char yes_or_no = 'n';
                yes_or_no = Console.ReadLine()[0];

                if(yes_or_no == 'y')
                {
                    if (clsUser.delete(user.User_ID))
                    {
                        Console.WriteLine("\n\nUser Deleted Successfuly\n\n");
                    }
                    else
                    {
                        Console.WriteLine("\n\nFailed To delete user\n\n");
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            Print_user_list_as_table();

            Console.ReadKey();
        }
    }
}
