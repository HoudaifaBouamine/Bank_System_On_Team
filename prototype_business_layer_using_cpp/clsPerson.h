#include <iostream>
#include <string>
#include <vector>
using namespace std;

class clsPerson
{

protected:

	struct stFullAdress
	{
		string Country;
		string City;
		string street;
	};
	

public:

	int ID;
	string FirstName, LastName;
	stFullAdress Adress;

};