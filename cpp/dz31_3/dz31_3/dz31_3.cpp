#include <iostream>
using namespace std;

class circle {
protected:
	int x, y;
	int radius;
public:
	circle(int x, int y, int radius) : x(x), y(y), radius(radius)
	{
	}
};

class square {
protected:
	int x, y;
	int height;
public:
	square(int x, int y, int height ) : x(x), y(y), height(height)
	{
	}
};

class Circle_Inscribed_Square : circle, square{
public:
	Circle_Inscribed_Square(int x, int y, int height, int radius) : square(x, y, height), circle(x, y, radius)
	{
	}
};

