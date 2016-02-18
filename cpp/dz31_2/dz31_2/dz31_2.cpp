#include <string>
#include <iostream>
using namespace std;

class Passport
{
protected:
	string serialNam;
	string name;
	string surname;
	string country;
	bool sex;
public:
	Passport(string name, string surname, char sex, string serialNam, string country) : name(name), surname(surname), serialNam(serialNam), country(country)
	{
		while (true)
		{
			if (sex == 'm' || sex == 'M'){
				this->sex = true;
				return;
			}
			else{
				if (sex == 'w' || sex == 'W'){
					this->sex = false;
					return;
				}
				else
					cout << endl << "Error" << endl;
			}
		}

	}
	Passport()
	{
		cout << endl << "Enter the sirial namber - ";
		cin >> serialNam;
		cout << endl << "Enter the serial country - ";
		cin >> country;
		cout << endl << "Enter the name - ";
		cin >> name;
		cout << endl << "Enter the surname - ";
		cin >> surname;

		while (true)
		{
			char sex;
			cout << endl << "Enter the sex - ";
			cin >> sex;
			if (sex == 'm' || sex == 'M'){
				this->sex = true;
				return;
			}
			else{
				if (sex == 'w' || sex == 'W'){
					this->sex = false;
					return;
				}
				else
					cout << endl << "Error" << endl;
			}
		}

	}
	void passShow()
	{
		cout << " Name: " << name << endl << " Surname: " << surname << endl;
		if (sex)
			cout << " Sex: man" << endl;
		else
			cout << " Sex: woman" << endl;
		cout <<" Serial namber: " << serialNam << endl << " Country: " << country << endl;
	}
};

class Visa
{
public:
	string VisaSerial;
	string dateCreated;
	string name;
	string lastname;
	Visa(string VisaSerial, string dateCreated, string name, string lastname) : VisaSerial(VisaSerial), dateCreated(dateCreated), name(name), lastname(lastname)
	{}

};


class ForeignPassport : public Passport
{
	string serialForeignPassport;
	Visa * visa[64];
	int counter = 0;
public:
	ForeignPassport(string name, string surname, char sex, string serialNam, string country, string serialForeignPassport) :Passport(name, surname, sex, serialNam, country), serialForeignPassport(serialForeignPassport)
	{
		counter = 0;
	}
	void AddVisa(string VisaSerial, string dateCreated, string name, string lastname)
	{
		visa[counter] = new Visa(VisaSerial, dateCreated, name, lastname);
		++counter;
	}
	void showForeignPassport()
	{
		passShow();
		cout <<" serialForeignPassport: "<< serialForeignPassport << endl;
		if (counter) {
			for (int i = 0; i < counter; ++i) {
				cout << endl << "Visa: " << i + 1 << endl;
				cout << visa[i]->VisaSerial << endl;
				cout << visa[i]->dateCreated << endl;
				cout << visa[i]->name << endl;
				cout << visa[i]->lastname << endl << endl;
			}
		}

	}

	~ForeignPassport()
	{
		if (counter) {
			for (int i = 0; i < counter; ++i) {
				delete visa[i];
			}
		}
	}
};


void main()
{
	ForeignPassport A("Eg", "PA", 'm', "MP15663", "BLR", "8888888");
	A.AddVisa("666", "20-07-2015", "Eg", "PA");
	A.showForeignPassport();

}
