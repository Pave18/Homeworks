#include <iostream>
using namespace std;


class FahrenheitSensor
{
	float t = 41;
public:

	FahrenheitSensor()
	{
		cout << "Fahrenheit temperature = " << t << endl;
	}

	float getFahrenheitTemp() {
		
		return t;
	}
};

class Sensor
{
public:
	virtual float getTemperature() = 0;
};

class Adapter : public Sensor
{
	FahrenheitSensor* p_fsensor;
public:
	Adapter();
	Adapter(FahrenheitSensor* p) : p_fsensor(p)
	{}

	~Adapter()
	{
		delete p_fsensor;
	}

	float getTemperature()
	{
		return (p_fsensor->getFahrenheitTemp() - 32.0)*5.0 / 9.0;
	}

};

class CelsiusSensor
{
public:
	Sensor* p = new Adapter(new FahrenheitSensor);

	CelsiusSensor()
	{
		float Cels = p->getTemperature();
		cout << "Celsius temperature = " << Cels << endl;
	}
		~CelsiusSensor()
	{
		delete p;
	}
};


int main()
{

	CelsiusSensor A;

	return 0;
}