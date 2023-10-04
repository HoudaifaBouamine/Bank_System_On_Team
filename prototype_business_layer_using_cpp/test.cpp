#include <iostream>
#include <string>
#include <map>

using namespace std; // Using the std namespace

class MyClass {
public:
    int age;
    string name;

    MyClass(int a, const string& n) : age(a), name(n) {}
};

// Function to get the value of a property in a class
template<typename T>
T getProperty(const MyClass& obj, const string& propertyName) {
    static map<string, T MyClass::*> memberMap = {
        {"age", &MyClass::age},
        {"name", &MyClass::name}
    };

    auto it = memberMap.find(propertyName);
    if (it != memberMap.end()) {
        return obj.*(it->second);
    } else {
        throw runtime_error("Property not found");
    }
}

int main() {
    MyClass obj(30, "John");

    int age = getProperty<int>(obj, "age");
    string name = getProperty<string>(obj, "name");

    cout << "Age: " << age << endl;
    cout << "Name: " << name << endl;

    return 0;
}
