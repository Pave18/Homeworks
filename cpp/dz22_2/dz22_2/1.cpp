#include <iostream>
#include <string.h>
using namespace std;

class String {
public:
	String(){
		str = new char[size];
	}
	String(int size){
		str = new char[size];
	}
	String(char*text){
		str = new char[strlen(text)+1];
		strcpy(str, text);
	}
	String operator* (const String &b)
	{
		String result(size+1);
		int k = 0;
		for (int i = 0; i < size; ++i){
			for (int j = 0; j < b.size; ++j){
				if (str[i] == b.str[j]){
					result.str[k] = str[i];
					++k;
				}
			}
		}
		result.str[k] = '\0';
		return result;
	}
	void show(){
		cout << str << endl;
	}
	~String(){ delete[] str; }
private:
	char * str;
	int size = 100;
};


int main()
{
	String A("sufug"); 
	A.show();

	String  B("kdsgs");
	B.show();

	String C=A * B;

	C.show();
	return 0;
}