#include <iostream>
using namespace std;

class Schet{
public:
	int min;
	int max;
	int znach;
	int plus();
	Schet(){
		cout << "������� ����������� �������� ��������" << endl;
		cin >> min;
		cout << "������� ������������ �������� ��������" << endl;
		cin >> max;
	}
	~Schet(){};
};

int Schet::plus(){
	
	cout << endl << endl;
	znach = min;
	int a = 0;
	while (a != 3){
		system("cls");
		cout << "1. ��������� ������� �� 1" << endl;
		cout << "2. ������� ������� �������� ��������" << endl;
		cout << "3. �����" << endl;

		cin >> a;

		switch (a){
		case 1:{
				   if (znach < max){
					   znach++;
					   cout << endl << "\t ��������� �� 1" << endl << endl;
				   }
				   else{
					   znach = 0;
					   cout << endl << "\t������� ��������: " << znach << "\n\t������� �������" << endl << endl << endl;
					   system("pause");
				   }
				   break;
		}
		case 2:{
				   cout << endl << "\t������� ��������: " << znach << endl << endl;
				   return znach;
				   break;
		}
		case 3:{
				   EXIT_SUCCESS;
				   break;
		}
		default:{
					cout << "������������ ����" << endl;
		}
		}
	}
}


void main(){
	setlocale(LC_ALL, "rus");


	{Schet Schet;
	Schet.plus(); }

}