#include <iostream>
#include <string>
using namespace std;

class Person
{
public:
	Person(string &&name, int age, bool sex, int phone_nam)
		: p_name(name), p_age(age), p_sex(sex), p_phone_nam(phone_nam){}
	void name(string &&name);
	void age(int age);
	void sex(char sex);
	void phone_nam(int phone_nam);
	void Print();
private:
	string p_name;
	int p_age;
	bool p_sex;
	int p_phone_nam;
};

void Person::name(string &&name)
{
	p_name = name;
}
void Person::age(int age)
{
	p_age = age;
}
void Person::sex(char sex)
{
	p_sex = sex;
}
void Person::phone_nam(int phone_nam)
{
	p_phone_nam = phone_nam;
}
void Person::Print()
{
	cout << "Name: " << p_name << "\n"
		<< "Age: " << p_age << "\n"
		<< "Sex: " << (p_sex ? "M" : "W") << "\n"
		<< "Phone number: " << p_phone_nam << "\n\n";
}

void main()
{
	Person A("Ivan", 21, true, 37529874);
	A.Print();
	Person B("Anastasia", 19, false, 37564668);
	B.Print();
}