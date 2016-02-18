#include <iostream>
using namespace std;

class Schet{
public:
	int min;
	int max;
	int znach;
	int plus();
	Schet(){
		cout << "Введите минимальное значение счетчика" << endl;
		cin >> min;
		cout << "Введите максимальное значение счетчика" << endl;
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
		cout << "1. Увеличить счетчик на 1" << endl;
		cout << "2. Вернуть текущее значение счетчика" << endl;
		cout << "3. Выйти" << endl;

		cin >> a;

		switch (a){
		case 1:{
				   if (znach < max){
					   znach++;
					   cout << endl << "\t Увеличено на 1" << endl << endl;
				   }
				   else{
					   znach = 0;
					   cout << endl << "\tТекушие значение: " << znach << "\n\tсчетчик сброшен" << endl << endl << endl;
					   system("pause");
				   }
				   break;
		}
		case 2:{
				   cout << endl << "\tТекушие значение: " << znach << endl << endl;
				   return znach;
				   break;
		}
		case 3:{
				   EXIT_SUCCESS;
				   break;
		}
		default:{
					cout << "НЕПРАВИЛЬНЫЙ ВВОД" << endl;
		}
		}
	}
}


void main(){
	setlocale(LC_ALL, "rus");


	{Schet Schet;
	Schet.plus(); }

}