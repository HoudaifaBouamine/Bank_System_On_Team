using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_Data_Layer;
using System.Security.Policy;
using System.Xml.Linq;

namespace Bank_Business_Layer
{
    public class clsUser : clsPerson
    {

        /// <summary>
        /// When you create an object using the constructor,
        /// then use the <c>Save()</c> method,
        /// the information on this object will overriding the information of the user with <c>user_ID</c> (Perform update operation)
        /// </summary>
        /// <param name="user_ID">the unique identifire of the user</param>
        /// <param name="person_ID">the uniqye identifire if the person</param>
        /// <param name="permission">an <c>integer number</c> represent the user permission as <c>flags</c> , every bit on this integer tell if he have the permission to do something (1) or not (0)</param>
        private clsUser
            (
                int user_ID, int person_ID, string firstName,
                string lastName, string country, string city, 
                string street, string email, string password,
                string phone, int permission
            )
            : base(person_ID, firstName, lastName, country, city, street)
        {
            _user_id = user_ID;
            Email = email;
            Password = password;
            Phone = phone;
            Permission = permission;
            Mode = enMode.eUpdate;
        }

        /// <summary>
        /// When you create an object using the constructor,
        /// then use the <c>Save()</c> method,
        /// the information on this object will be stored on new row on the database
        /// </summary>
        public clsUser()
        {
            _user_id = -1;
            Email = "";
            Password = "";
            Phone = "";
            Permission = 0;
            Mode = enMode.eAddNew;
        }

        /// <summary>
        /// find function get the user <c>ID</c> 
        /// if user is found it returns an object full with the user info
        /// else it return <c>null</c>
        /// </summary>
        /// <returns> the full user info when user found,null otherwize</returns>
        /// <param name="User_ID">The unique identifier of the user</param>
        static public clsUser find(int User_ID)
        {

            int Person_ID = -1, Permission = 0;
            string FirstName = "", LastName = "", Country = "", City = "", Street = "",
                Email = "", Password = "", Phone = "";

            clsUser user = null;

            if (clsDataAccessLayer.Find_User_By_ID(
                User_ID, ref  Person_ID, ref FirstName, 
                ref  LastName,ref  Country,ref  City,ref  Street,
                ref  Email,ref  Password,ref  Phone,ref  Permission
                ))
           
            {

                user = new clsUser(User_ID, Person_ID, FirstName, LastName, Country, City, Street, Email, Password, Phone, Permission);
            
            }
            else
            {
                user = null ; 
            }

            return user;

        }

        /// <summary>
        /// list function return all the users on the system as List of clsUser
        /// </summary>
        /// <returns>List of all Users on the system</returns>
        static public List<clsUser> list()
        {

            List<clsUser> users_list = new List<clsUser>();

            List<int> User_ID = new List<int>();
            List<int> Person_ID = new List<int>();
            List<string> FirstName = new List<string>();
            List<string> LastName = new List<string>();
            List<string> Country = new List<string>();
            List<string> City = new List<string>();
            List<string> Street = new List<string>();
            List<string> Email = new List<string>();
            List<string> Password = new List<string>();
            List<string> Phone = new List<string>();
            List<int> Permission = new List<int>();

            clsDataAccessLayer.Get_Users_List
                (
                    ref User_ID, ref Person_ID, ref FirstName, ref LastName, ref Country, ref City, ref Street,
                    ref Email, ref Password, ref Phone, ref Permission
                );


            for (int i = 0; i < User_ID.Count; i++)
            {
                clsUser user = new clsUser(
                    User_ID[i], Person_ID[i], FirstName[i], LastName[i],
                    Country[i], City[i], Street[i],
                    Email[i], Password[i], Phone[i], Permission[i]);

                users_list.Add(user);
            }


            return users_list;
        }


        private bool _Add_New()
        {
            int tmp_user_id = -1, tmp_person_id = -1;

            if (
                clsDataAccessLayer.Add_New_User_By_User_ID
                (
                    ref tmp_user_id, ref tmp_person_id, FirstName, LastName,
                    Country, City, Street, Email, Password, Phone, Permission
                )
               )

            {
                _user_id = tmp_user_id;
                _person_id = tmp_person_id;
                Mode = enMode.eUpdate; // IF we do not change the mode the next update of the same object (User) will be added as new user to the database
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool _Update()
        {
            return clsDataAccessLayer.Update_User_By_ID
                         (
                             User_ID, Person_ID, FirstName, LastName,
                             Country, City, Street, Email, Password, Phone, Permission
                         );
        }

        /// <summary>
        /// this function save the information on the object to the database;<br></br>
        /// if the object created using the return of the <c>clsUser.find(int User_ID)</c> then this function will update the user info on the database;<br></br>
        /// else if the object created using <c>new clsUser()</c> (the constructor) then it will add new user to the database,but when using it again it will update the new user info without creating new one<br></br>
        /// </summary>
        /// <returns>return <c>true</c> if the save complited successfuly, otherwise return <c>false</c></returns>
        public bool save()
        {
            switch (this.Mode)
            {
                case enMode.eAddNew:
                    {
                        return _Add_New();
                    }
                case enMode.eUpdate:
                    {

                        return _Update();
                    }

                default:
                    return false;
            }
        }

        /// <summary>
        /// get <c>User_ID</c>  as parameter and delete the user with this user name<br></br>
        /// </summary>
        /// <returns>return <c>true</c> if deleted successfuly , otherwise return <c>false</c> </returns>
        static public bool delete(int User_ID)
        {
            bool isDeleted = false;

            isDeleted = clsDataAccessLayer.Delete_User_By_ID(User_ID);

            return isDeleted;
        }

        private int _user_id;
        public int User_ID { get { return _user_id; } }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int Permission { get; set; }

        private enMode Mode;

        private enum enMode { eAddNew,eUpdate}
    }
}
