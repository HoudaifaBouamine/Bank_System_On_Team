#include "clsPerson.h" 



class clsUser :public clsPerson
{
public :
    struct stUser
    {
        string ID,FirstName , LastName , Email , Password ;
        int Permition ; 
        stFullAdress Address ;  
    };
    int Permition ; 
    string Email,Password,Phone;

    clsUser(int ID,string FirstName,string LastName,stFullAdress Adress , int Permetion ,string Email, string Password,string Phone):clsPerson(ID, FirstName, LastName, Adress){
        this->Permition = Permition ; 
        this->Email = Email ; 
        this->Password = Password ; 
        this->Phone = Phone ; 
    } 

    bool UserPermition(int UserPermition , int IsHasPermition) {
        return (UserPermition&IsHasPermition == IsHasPermition) ? true : false ; 
    }

    bool Find_UserWithEmail(stUser ArrayOfUsers[1000] ,int ArrayLenght ,string Password , string Email){
        for(int i = 0 ; i< ArrayLenght; i++  ) {
            if (ArrayOfUsers[i].Password ==  Password && ArrayOfUsers[i].Email ==  Email) {
                return true ; 
            }
            return false ; 
        }
    } 

    bool Find_UserWithID(stUser ArrayOfUsers[1000] ,int ArrayLenght ,string Password , string ID){
        for(int i = 0 ; i< ArrayLenght; i++  ) {
            if (ArrayOfUsers[i].Password ==  Password && ArrayOfUsers[i].ID ==  ID) {
                return true ; 
            }
            return false ; 
        }
    } 

    void Delete(stUser ArrayOfUsers[1000] ,int ArrayLenght ,string Password , string Email ,string ID){
        for(int i = 0 ; i< ArrayLenght; i++  ) {
            if (ArrayOfUsers[i].Password ==  Password && ((ArrayOfUsers[i].ID ==  ID )|| (ArrayOfUsers[i].Email ==  Email) )) {
                
                ArrayOfUsers[i].Password = "";
                ArrayOfUsers[i].ID =  "" ;  
                ArrayOfUsers[i].FirstName ==  "" ; 
                ArrayOfUsers[i].LastName = "";
                ArrayOfUsers[i].Permition = 0 ;  
                ArrayOfUsers[i].Email =  "" ; 
                ArrayOfUsers[i].Address.City = "" ;
                ArrayOfUsers[i].Address.Country = "" ; 
                ArrayOfUsers[i].Address.Street = "" ;
                cout << "User deleted Successfully " << endl; 
                break ; 
            }
            
        }
        cout << "User Not Found" << endl ; 
    }

    void Create_User(stUser ArrayOfUsers[1000] ,int ArrayLenght , stUser NewUser){
        ArrayOfUsers[ArrayLenght] = NewUser;

    }

} ; 