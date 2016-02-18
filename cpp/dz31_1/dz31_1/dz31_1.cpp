#include <string>
#include <iostream>
using namespace std;

class Student
{
protected:
	string name;
	string surname;
	string faculty;
public:
	Student(string name, string surname, string faculty) : name(name), surname(surname), faculty(faculty)
	{}
	Student()
	{
		cout << endl << "Enter the name - ";
		cin >> name;
		cout << endl << "Enter the surname - ";
		cin >> surname;
		cout << endl << "Enter the faculty - ";
		cin >> faculty;
	}
	void StudShow()
	{
		cout << endl << "______" << faculty << "______" << endl;
		cout << " Name: " << name << endl << " Surname: " << surname << endl;
	}
};

class Aspirant : public Student
{
	string theme;
	bool prot = false;
public:
	Aspirant(string theme, bool prot) :theme(theme), prot(prot)
	{}
	void AspirantShow()
	{
		StudShow();
		cout << " Theme: " << theme << endl;
		if (prot)
			cout << " Subject is protected. Post-graduate student." << endl;
		else
			cout << " Subject is not protected." << endl;
	}
};


void main()
{
	
}