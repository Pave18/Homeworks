#include <iostream>
using namespace std;

template< typename T >
class complex{
	T x;
	T y;

public:

	complex(T x, T y) : x(x), y(y)
	{}

	complex(T x) : x(x), y(0)
	{}

	complex(const complex &obj)
	{
		x = obj.x;
		y = obj.y;
	}

	complex& operator = (const complex &obj)
	{
		if (this != &obj) {
			x = obj.x;
			y = obj.y;
		}

		return *this;
	}

	complex operator + (const complex &obj)
	{
		complex newComplex(x, y);
		newComplex.x = x + obj.x;
		newComplex.y = y + obj.y;

		return newComplex;
	}

	complex& operator += (T a)
	{
		x += a;

		return *this;
	}

	complex operator - (const complex &obj)
	{
		complex newComplex(x, y);
		newComplex.x = x - obj.x;
		newComplex.y = y - obj.y;

		return newComplex;
	}

	complex& operator -= (T a)
	{
		x -= a;

		return *this;
	}

	complex operator * (const complex &obj)
	{
		complex newComplex(x, y);
		newComplex.x = x * obj.x - y * obj.y;
		newComplex.y = x * obj.y + y * obj.x;

		return newComplex;
	}

	complex& operator *= (T a)
	{
		x *= a;
		y *= a;

		return *this;
	}

	complex operator / (const complex &obj)
	{
		complex newComplex(x, y);
		newComplex.x = (x * obj.x + y * obj.y) / (obj.x * obj.x + obj.y * obj.y);
		newComplex.y = (y * obj.x - x * obj.y) / (obj.x * obj.x + obj.y * obj.y);

		return newComplex;
	}

	complex& operator /= (T a)
	{
		x /= a;
		y /= a;

		return *this;
	}

	void show()
	{
		cout << x;
		if (y >= 0){
			cout << " + i * " << y;
		}
		else{
			cout << " - i * " << y*(-1);
		}
		cout << endl;
	}

};

int main() {
	complex<double> a(5.69, -3.66);
	a.show();
	
	return 0;
}