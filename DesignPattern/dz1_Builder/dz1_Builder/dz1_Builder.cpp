#include <iostream>
#include <memory>
#include <string>

// Product
class Car
{
	std::string carcase;
	int doors;
	std::string motor;

public:

	void SetCarcase(const std::string& c) { carcase = c; }
	void SetDoors(const int& d) { doors = d; }
	void SetMotor(const std::string& m) { motor = m; }

	void ShowCar()
	{
		std::cout << " _Car built_" << std::endl
			<< "Carcase: " << carcase << std::endl
			<< "Doors: " << doors << std::endl
			<< "Motor: " << motor << std::endl;
	}
};

// Abstract Builder
class CarBuilder
{
protected:
	std::shared_ptr<Car> car;
public:
	CarBuilder() {}
	virtual ~CarBuilder() {}

	std::shared_ptr<Car> GetCar() { return car; }

	void createNewCarProduct() { car.reset(new Car); }

	virtual void buildCarcase() = 0;
	virtual void buildDoors() = 0;
	virtual void buildMotor() = 0;

};

// ConcreteBuilder
class SedanCarBuilder : public CarBuilder
{
public:
	SedanCarBuilder() : CarBuilder() {}
	~SedanCarBuilder() {}

	void buildCarcase() { car->SetCarcase("Sedan"); }
	void buildDoors() { car->SetDoors(5); }
	void buildMotor() { car->SetMotor("M50 500hp"); }
};

// ConcreteBuilder
class CoupeCarBuilder : public CarBuilder
{
public:
	CoupeCarBuilder() : CarBuilder() {}
	~CoupeCarBuilder() {}

	void buildCarcase() { car->SetCarcase("Coupe"); }
	void buildDoors() { car->SetDoors(3); }
	void buildMotor() { car->SetMotor("M54 800hp"); }
};

// Director
class Factory
{
	CarBuilder* carBuilder;
public:
	Factory() : carBuilder(NULL) {}
	~Factory() { }

	void SetCarBuilder(CarBuilder* b) { carBuilder = b; }
	std::shared_ptr<Car> GetCar() { return carBuilder->GetCar(); }
	void ConstructCar()
	{
		carBuilder->createNewCarProduct();
		carBuilder->buildCarcase();
		carBuilder->buildDoors();
		carBuilder->buildMotor();
	}
};

int main()
{
	Factory factory;

	SedanCarBuilder sedanCarBuilder;
	factory.SetCarBuilder(&sedanCarBuilder);
	factory.ConstructCar();
	std::shared_ptr<Car> Car = factory.GetCar();
	Car->ShowCar();

	std::cout << std::endl;

	CoupeCarBuilder coupeCarBuilder;
	factory.SetCarBuilder(&coupeCarBuilder);
	factory.ConstructCar();
	Car = factory.GetCar();
	Car->ShowCar();

	return 0;
}