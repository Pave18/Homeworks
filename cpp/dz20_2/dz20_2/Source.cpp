#include <iostream>
using namespace std;

class Student{
public:
	char* name;
	char* surname;
	char* groupNam;

	Student(){
		name = new char[100];
		surname = new char[100];
		groupNam = new char[100];
	}

	~Student(){
		delete[] name;
		delete[] surname;
		delete[] groupNam;
	}
};

class Group{
public:

	Student * students;
	int SAmount;
	char * GroupName;

	Group(int amount, char * Name){
		students = new Student[amount];
		SAmount = amount;
		GroupName = new char[100];
		strcpy(GroupName, Name);
		cout << "Создана группа " << GroupName << ". В группе " << SAmount << " студентов!" << endl;
	}

	~Group(){
		cout << "Уничтожена группа " << GroupName << "!" << endl;
		delete[] students;
		delete[]GroupName;
	}

};


void main(){
	setlocale(LC_ALL, "rus");

	Group A(35, "1412-Мк");
}