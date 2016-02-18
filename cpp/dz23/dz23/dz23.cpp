#include <iostream>
#include <stdlib.h>
using namespace std;

class Array
{
public:
	Array(int size)
	{
		this->size = size;
		if (size > 0){
			arr = new int[size];
		}
	}
	~Array()
	{
		if (size){
			delete[]arr;
		}
	}
	void fillArray() {
		for (int i = 0; i < this->size; ++i) {
			this->arr[i] = rand() % 10;
		}
	}
	int & operator [] (int index) {
		if (index >= 0 && index < size) {
			return arr[index];
		}
		else
			cout << "error";
	}
	Array & operator = (const Array &obj) {
		if (this != &obj) {
			size = obj.size;
			arr = new int[obj.size];
			for (int i = 0; i < size; ++i) {
				arr[i] = obj.arr[i];
			}
		}
		return *this;
	}
	Array & operator + (const Array &obj)
	{
		int NewSize = this->size + obj.size;
		Array NewArr(NewSize);
		int i;
		for (i = 0; i < this->size; ++i){
			NewArr.arr[i] = this->arr[i];
		}
		for (int j = 0; i < NewSize; ++i, ++j){
			NewArr.arr[i] = obj.arr[j];
		}
		return NewArr;
	}
	Array & operator ++ (int)
	{
		int NewSize = this->size + 1;
		Array NewArr(NewSize);
		for (int i = 0; i < NewSize; ++i){
			NewArr.arr[i] = this->arr[i];
		}
		NewArr[NewSize] = rand() % 10;
		return NewArr;
	}
	Array & operator -- (int)
	{
		int NewSize = this->size - 1;
		Array NewArr(NewSize);
		for (int i = 0; i < NewSize - 1; ++i){
			NewArr[i] = this->arr[i];
		}
		return NewArr;
	}

	void show()
	{
		if (size){
			for (int i = 0; i < size; ++i){
				cout << arr[i] << " ";
			}
			cout << endl;
		}
		else{
			cout << "The array is empty.\n";
		}
	}
private:
	int * arr;
	int size;
};


void main()
{

	Array a(10);
	a.fillArray();
	a.show();
	a[5] = 155;
	a.show();
	cout << endl;
	Array b(12);
	b.fillArray();
	b.show();
	cout << endl;
	Array c(5);
	c = b;
	c.show();
	cout << endl;

	Array s(12);
	s.fillArray();
	s.show();
	
	s.show();
	cout << endl;

}