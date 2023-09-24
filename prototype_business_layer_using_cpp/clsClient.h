#include <iostream>
#include <string>
#include <vector>
#include <clsPerson.h>


using namespace std;

clsClient ArrayOfClients[]; 

/*class clsClient : clsPerson
{
	int ID;
	float Balance;
	Email,Password,Phone;
}*/

class clsClient : public clsPerson
{

private:
		
		

    clsClient (int id, string FirstName, string LastName, stFullAdress Adress, string email, string password, string phone):clsPerson(id, FirstName, LastName, Adress)
	{
		this->Balance=0;
		this->Email=email;
		this->Phone=phone;
	}


public:
	int Id;
	float Balance;
	string Password, Phone, Email;
	static int ClientsLen;

	static clsClient* find_client(string FirstName, string LastName){
		int i=0;
		while (i<ClientsLen and (ArrayOfClients[i].FirstName!=FirstName or ArrayOfClients[i].LastName!=LastName)){
			i++;
		}
		if (i<ClientsLen){
			return &ArrayOfClients[i];
		} 
		else {
			return NULL;
		}
	}

	static clsClient* find_client(string email){
		int i=0;
		while (i<ClientsLen and ArrayOfClients[i].Email!=email){
			i++;
		}
		if (i<ClientsLen){
			return &ArrayOfClients[i];
		} 
		else {
			return NULL;
		}
	}

	static clsClient* find_client(string phone){
		int i=0;
		while (i<ClientsLen and ArrayOfClients[i].Phone!=phone){
			i++;
		}
		if (i<ClientsLen){
			return &ArrayOfClients[i];
		} 
		else {
			return NULL;
		}
	}

	static void Read(int id){
		cout << "Customer Information for Client " << id + 1 << ":" << endl;
        cout << "Full Name: " << ArrayOfClients[id].FullName() << endl;
        cout << "Account Balance: " << ArrayOfClients[id].Balance << endl;
        cout << "Phone Number: " << ArrayOfClients[id].Phone << endl;
        cout << "Address: " << ArrayOfClients[id].FullAdress() << endl;
        cout << "Password: " << ArrayOfClients[id].Password << endl;
	}

	void Read(){
		cout << "Customer Information:" << endl;
		cout << "Full Name: " << FullName() << endl;
		cout << "Customer ID: " << Id << endl;
		cout << "Account Balance: " << Balance << endl;
		cout << "Phone Number: " << Phone << endl;
		cout << "Address: " << FullAdress() << endl;
		cout << "Password: " << Password << endl;
	}

	void Delete(){
		this->Balance=0;
		this->Adress=stFullAdress();
		this->Email="";
		this->Password="";
		this->FirstName="";
		this->LastName="";
	}

	static bool Delete(int id){
		try{
			ArrayOfClients[id].id=-1;
			ArrayOfClients[id].FirstName="";
			ArrayOfClients[id].LastName="";
			ArrayOfClients[id].Adress=stFullAdress();
			ArrayOfClients[id].Balance=0;
			ArrayOfClients[id].Email="";
			ArrayOfClients[id].phone="";
			return true;
		}
		catch (...){
			return false;
		}
	}

	static bool Delete(clsClient* client){
		try{
			(*client).Id=-1;
			(*client).FirstName="";
			(*client).LastName="";
			(*client).Adress=stFullAdress();
			(*client).Balance=0;
			(*client).Email="";
			(*client).Phone="";
			
			return true;
		}
		catch (...){
			return false;
		}
	}

};
