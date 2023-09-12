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
		string Street;

		stFullAdress()
		{
			this->Country	= "";
			this->City		= "";
			this->Street	= "";
		}
		stFullAdress(string Country, string City, string Street)
		{
			this->Country = Country;
			this->City = City;
			this->Street = Street;
		}
	};
	
	string FirstName, LastName;
	stFullAdress Adress;

	string FullName() { return FirstName + " " + LastName; };


protected:

	clsPerson(string FirstName,string LastName,stFullAdress Adress)
	{
		this->FirstName = FirstName;
		this->LastName = LastName;
		this->Adress = Adress;
	}

};
