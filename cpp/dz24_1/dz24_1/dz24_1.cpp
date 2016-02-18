#include <iostream>
using namespace std;

class Time
{
	int hour = 0, min = 0;
public:
	Time()
	{
		cout << "Enter the time:" << endl << "Hour = ";
		cin >> this->hour;
		cout << "Min =";
		cin >> this->min;
		checkTime();
	}
	Time(int hour, int min)
	{
		this->hour = hour;
		this->min = min;
		checkTime();
	}
	Time operator + (const Time &obj)
	{
		Time newTime(0, 0);
		newTime.hour = this->hour + obj.hour;
		newTime.min = this->min + obj.min;
		newTime.checkTime();
		return newTime;
	}
	Time operator - (const Time &obj)
	{
		Time newTime(0, 0);
		newTime.hour = this->hour - obj.hour;
		newTime.min = this->min - obj.min;
		newTime.checkTime();
		return newTime;
	}
	void operator == (const Time &obj)
	{
		if (this->hour > obj.hour){
			show();
			cout << " > " << obj.hour << ":" << obj.min << endl;
		}
		if (this->hour < obj.hour){
			show();
			cout << " < " << obj.hour << ":" << obj.min << endl;
		}
		if (this->hour == obj.hour){
			if (this->min > obj.min){
				show();
				cout << " > " << obj.hour << ":" << obj.min << endl;
			}
			if (this->min < obj.min){
				show();
				cout << " < " << obj.hour << ":" << obj.min << endl;
			}
		}
	}

	void convertor(char D)
	{
		if (hour <= 12){
			if (D == 'A' || D == 'a')
			{
				cout << "AM ";
				show();
				cout << " = ";
				show();
			}
			if (D == 'p' || D == 'P')
			{
				cout << "PM ";
				show();
				cout << " = ";
				if (hour = 12)
					hour = 0;
				else
					hour += 12;
				show();
			}
		}
		else
			cout << "error";
	}

	void checkTime()
	{
		while (min > 60){
			min -= 60;
			hour += 1;
		}

		while (hour >= 24){
			hour -= 24;
		}

	}
	void show()
	{
		if (hour < 0 || min < 0)
			cout << endl << "error" << endl;
		else{
			if (hour < 10)
				cout << "0" << hour;
			else
				cout << hour;
			cout << ":";
			if (min < 10)
				cout << "0" << min;
			else
				cout << min;
		}
	}

};

void main()
{
	Time A(24, 0);
	A.show();
	cout << endl;
	Time B(33, 5);
	B.show();
	cout << endl;

	Time s(1, 1);
	s.show();
	cout << endl;

	s = A + B;
	s.show();
	cout << endl;

	s = A - B;
	s.show();
	cout << endl;

	Time D(12, 30);
	D.convertor('p');
	cout << endl;

	A == B;
	Time F;

}