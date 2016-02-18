#include <iostream>
using namespace std;

class Data
{
public:
	Data(int day_, int month_, int year_)
	{
		Data2();
		day = day_ - day2;
		month = month_ - month2;
		year = year_ - year2;

		show_dif();
	}

	Data(int day_, int month_, int year_, int n)
	{
		day = day_;
		month = month_;
		year = year_;

		day =day+ n;
		show_data();
	}

	int Data2()
	{
		cout << "Enter data 2:" << endl;
		cout << "Day = ";
		cin >> day2;
		cout << "Month = ";
		cin >> month2;
		cout << "Year = ";
		cin >> year2;
		return day2, month2, year2;
	}

	void show_dif()
	{
		dif_day = (year * 360) + (month * 30) + day;
		cout << "Difference = " << dif_day << " days" << endl;
	}
	void show_data()
	{
		while (day > 30){
			day = day -30;
			++month;
		}
		while (month > 12){
			month = month - 12;
			++year;
		}
		cout << "+n days.  Data = " << day << "\\" << month << "\\" << year << endl;
	}
private:
	int day; int month;	int year;
	int day2; int month2; int year2;
	int dif_day;
};

void main()
{
	Data A(10, 12, 2015, 30);
	Data B(10, 12, 2015);
}

