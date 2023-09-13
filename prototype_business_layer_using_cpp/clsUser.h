#include "clsPerson.h" 
clsUser ArrayOfUsers[]; 
    
class clsUser :public clsPerson
{
private:
    int IDUser ; 
    clsUser(string FirstName,string LastName,stFullAdress Adress , int Permetion ,string Email, string Password,string Phone , int IDUser):clsPerson(FirstName, LastName, Adress){
        this->Permition = Permition ; 
        this->Email = Email ; 
        this->Password = Password ; 
        this->Phone = Phone ; 
        this->IDUser = IDUser ; 
    } 

public :
    int Permition ; 
    static string Email,Password,Phone;
    static int ArrayLength ; 
    

    bool UserPermition(int IsHasPermition ){
        return (Permition&IsHasPermition == IsHasPermition) ? true : false ; 
    }

    clsUser* Find_UserWithEmail(int ArrayLenght ,string Password , string Email){
        for(int i = 0 ; i< ArrayLenght; i++){
            if (ArrayOfUsers[i].Password ==  Password && ArrayOfUsers[i].Email ==  Email) {
                return & ArrayOfUsers[i]; 
            }
            return NULL ;

        }
    } 

    clsUser* Find_UserWithID(int ArrayLenght ,string Password , string ID){
        for(int i = 0 ; i< ArrayLenght; i++) {
            if (ArrayOfUsers[i].Password ==  Password && ArrayOfUsers[i].ID ==  ID) {
                return & ArrayOfUsers[i] ; 
                 
            }
            return NULL ; 
        }
    } 
    clsUser* Find_UserWithID(int ArrayLenght ,string Email){
        for(int i = 0 ; i< ArrayLenght; i++) {
            if (ArrayOfUsers[i].Email == Email ) {
                return & ArrayOfUsers[i] ; 
                 
            }
            return NULL ; 
        }
    } 

    void Delete(int ArrayLenght ,string Password , string Email ,string ID){
        for(int i = 0 ; i< ArrayLenght; i++  ) {
            if (ArrayOfUsers[i].Password ==  Password && ((ArrayOfUsers[i].ID ==  ID )|| (ArrayOfUsers[i].Email ==  Email) )) {
                ArrayOfUsers[i].Password = "";
                ArrayOfUsers[i].ID =  "" ;  
                ArrayOfUsers[i].FirstName =  "" ; 
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

    void Create_User(int ArrayLenght , clsUser NewUser){
        ArrayOfUsers[ArrayLenght] = NewUser;
    }

} ; 