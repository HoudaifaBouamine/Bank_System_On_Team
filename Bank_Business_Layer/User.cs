using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank_Data_Layer;
using System.Security.Policy;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Bank_Business_Layer
{
    public class clsUser : clsPerson
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="clsUser"/> class based on a DataRow from the database.
        /// </summary>
        /// <param name="row">The DataRow containing user information.</param>
                
        public clsUser(DataRow row)
        {

            User_ID = Convert.ToInt32(row["User_ID"]); 
            UserName = row["UserName"].ToString();
            Email = row["Email"].ToString();
            Password = row["Password"].ToString();
            Phone = row["Phone"].ToString();
            Permission = Convert.ToInt32(row["Permission"]);
            Person_ID = Convert.ToInt32(row["Person_ID"]); 
            FirstName = row["FirstName"].ToString();
            LastName = row["LastName"].ToString();
            Country = row["Country"].ToString();
            City = row["City"].ToString();
            Street = row["Street"].ToString();

        }

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
                int user_ID, int person_ID,string userName, string firstName,
                string lastName, string country, string city, 
                string street, string email, string password,
                string phone, int permission
            )
            : base(person_ID, firstName, lastName, country, city, street)
        {
            User_ID = user_ID;
            UserName = userName;
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
            User_ID = -1;
            UserName = "";
            Email = "";
            Password = "";
            Phone = "";
            Permission = 0;
            Mode = enMode.eAddNew;
        }

        /// <summary>
        /// Retrieves a user by their unique User_ID.
        /// </summary>
        /// <param name="User_ID">The unique identifier of the user.</param>
        /// <returns>The user object if found; otherwise, null.</returns>
        static public clsUser Find(int User_ID)
        {

            int Person_ID = -1, Permission = 0;
            string FirstName = "", LastName = "", Country = "", City = "", Street = "",
                Email = "", Password = "", Phone = "", UserName="";

            clsUser user = null;

            if (clsDataAccessLayer.Find_User_By_ID(
                User_ID, ref  Person_ID,ref UserName, ref FirstName, 
                ref  LastName,ref  Country,ref  City,ref  Street,
                ref  Email,ref  Password,ref  Phone,ref  Permission
                ))
           
            {

                user = new clsUser(User_ID, Person_ID,UserName, FirstName, LastName, Country, City, Street, Email, Password, Phone, Permission);
            
            }
            else
            {
                user = null ; 
            }

            return user;

        }

        static public clsUser Find(string Email)
        {

            int User_ID = -1,Person_ID = -1, Permission = 0;
            string FirstName = "", LastName = "", Country = "", City = "", Street = "",
                 Password = "", Phone = "", UserName = "";

            clsUser user = null;

            if (clsDataAccessLayer.Find_User_By_Email(
                Email,ref User_ID, ref Person_ID, ref UserName, ref FirstName,
                ref LastName, ref Country, ref City, ref Street,
                 ref Password, ref Phone, ref Permission
                ))

            {
                
                user = new clsUser(User_ID, Person_ID, UserName, FirstName, LastName, Country, City, Street, Email, Password, Phone, Permission);

            }
            else
            {
                user = null;
            }

            return user;

        }

        static public clsUser Find_UserName(string UserName)
        {

            int Person_ID = -1, Permission = 0,User_ID = -1;
            string FirstName = "", LastName = "", Country = "", City = "", Street = "",
                Email = "", Password = "", Phone = "";

            clsUser user = null;

            if (clsDataAccessLayer.Find_User_By_UserName(
                UserName,ref User_ID, ref Person_ID, ref FirstName,
                ref LastName, ref Country, ref City, ref Street,
                ref Email, ref Password, ref Phone, ref Permission
                ))

            {

                user = new clsUser(User_ID, Person_ID, UserName, FirstName, LastName, Country, City, Street, Email, Password, Phone, Permission);

            }
            else
            {
                user = null;
            }

            return user;

        }

        /// <summary>
        /// Retrieves a list of all users in the system.
        /// </summary>
        /// <returns>A DataTable containing the list of users.</returns>
        static public DataTable list()
        {
            return clsDataAccessLayer.Get_Users_List();
        }



        /// <summary>
        /// Saves the user's information to the database.
        /// </summary>
        /// <returns>True if the save operation is successful; otherwise, false.</returns>
        /// <remarks>
        /// If the user object is created using the <see cref="clsUser.Find(int)"/> method,
        /// this function will update the user's information in the database. If the user object
        /// is created using the default constructor <see cref="clsUser()"/>, it will add a new user
        /// to the database. Subsequent calls will update the existing user's information.
        /// </remarks>
        public bool Save()
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


            bool _Add_New()
            {
                int tmp_user_id = -1, tmp_person_id = -1;

                if (
                    clsDataAccessLayer.Add_New_User_By_User_ID
                    (
                        ref tmp_user_id, ref tmp_person_id, UserName, FirstName, LastName,
                        Country, City, Street, Email, Password, Phone, Permission
                    )
                   )

                {
                    User_ID = tmp_user_id;
                    Person_ID = tmp_person_id;
                    Mode = enMode.eUpdate; // IF we do not change the mode the next update of the same object (User) will be added as new user to the database
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool _Update()
            {
                return clsDataAccessLayer.Update_User_By_ID
                             (
                                 User_ID, Person_ID, UserName, FirstName, LastName,
                                 Country, City, Street, Email, Password, Phone, Permission
                             );
            }
        }

        /// <summary>
        /// Deletes a user by their User_ID.
        /// </summary>
        /// <param name="User_ID">The unique identifier of the user to delete.</param>
        /// <returns>True if the user is deleted successfully; otherwise, false.</returns>
        static public bool Delete(int User_ID)
        {
            bool isDeleted = false;

            isDeleted = clsDataAccessLayer.Delete_User_By_ID(User_ID);

            return isDeleted;
        }

        public int User_ID { get; private set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int Permission { get; set; }

        private enMode Mode;

        private enum enMode { eAddNew,eUpdate}
    }
}
