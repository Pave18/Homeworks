#include <iostream>
#include <string.h>
using namespace std;

class String {
	char * str;

public:
	String(){
		str = new char[80];
	}
	String(int size){
		str = new char[size];
	}
	String(int size, char*text){
		str = new char[size];
		strcpy(str, text);
	}
	void show(){
		cout << str << endl;
	}
	void INPUT(){
		gets(str);
	}
	~String(){ delete[] str; }
};
