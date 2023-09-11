#include <iostream>
#include <string>
#include <vector>
using namespace std;

class clsPerson
{

public:

	struct stFullAdress
	{
		string Country;
		string City;
		string street;
	};
	
	int ID;
	string FirstName, LastName;
	stFullAdress Adress;

	string FullName() { return FirstName + " " + LastName; };


protected :

	clsPerson(int ID,string FirstName,string LastName,stFullAdress Adress)
	{
		this->ID = ID;
		this->FirstName = FirstName;
		this->LastName = LastName;
		this->Adress = Adress;
	}

};