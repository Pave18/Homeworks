#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

class Matrix
{
	int ** matrix;
	int sizeA, sizeB;
public:
	Matrix(int A, int B) : sizeA(A), sizeB(B)
	{
		matrix = new int*[sizeA];
		for (int i = 0; i < sizeA; ++i) {
			matrix[i] = new int[sizeB];
		}
	}
	Matrix(const Matrix &obj)
	{
		sizeA = obj.sizeA;
		sizeB = obj.sizeB;
		matrix = new int*[sizeA];
		for (int i = 0; i < sizeA; ++i) {
			matrix[i] = new int[sizeB];
		}
		for (int i = 0; i < sizeA; i++) {
			for (int j = 0; j < sizeB; j++) {
				matrix[i][j] = obj.matrix[i][j];
			}
		}
	}
	Matrix operator +(const Matrix &obj)
	{
		Matrix NewMatrix(sizeA, sizeB);

		if (sizeA == obj.sizeA && sizeB == obj.sizeB){
			for (int i = 0; i < sizeA; ++i) {
				for (int j = 0; j < sizeB; ++j) {
					NewMatrix.matrix[i][j] = matrix[i][j] + obj.matrix[i][j];
				}
			}
			return NewMatrix;
		}
		else
			cout << "Size error  matrix" << endl;
	}
	Matrix operator *(const Matrix &obj)
	{
		if (sizeA == obj.sizeB){
			Matrix NewMatrix(obj.sizeA, sizeB);

			for (int i = 0; i < obj.sizeA; ++i) {
				for (int j = 0; j < sizeB; ++j) {
					for (int inner = 0; inner < sizeA; ++inner) {
						if (inner == 0)
							NewMatrix.matrix[i][j] = matrix[inner][j] * obj.matrix[i][inner];
						else
							NewMatrix.matrix[i][j] += matrix[inner][j] * obj.matrix[i][inner];
					}
				}
			}
			return NewMatrix;
		}
		else{
			cout << endl << "Error Size" << endl;
			return *this;
		}
	}
	void transpose(){
		Matrix newMatrix(sizeB, sizeA);
		for (int i = 0; i < sizeA; ++i) {
			for (int j = 0; j < sizeB; ++j) {
				newMatrix.matrix[j][i] = matrix[i][j];
			}
		}
		newMatrix.show();
	}
	void operator =(const Matrix &obj)
	{
		if (sizeA == obj.sizeA && sizeB == obj.sizeB){
			for (int i = 0; i < sizeA; ++i) {
				for (int j = 0; j < sizeB; ++j) {
					matrix[i][j] = obj.matrix[i][j];
				}
			}
		}
	}
	void instElement()
	{
		int i = rand() % sizeA;
		int j = rand() % sizeB;
		matrix[i][j] = rand() % 10;
		cout << endl << "matrix [" << i+1 << "][" << j+1 << "] = " << matrix[i][j] << endl;

	}
	void receElement()
	{
		int Element;
		int i = rand() % sizeA;
		int j = rand() % sizeB;
		Element = matrix[i][j];
		cout << endl << "matrix [" << i+1 << "][" << j+1 << "] = " << Element << endl;
	}

	void fill()
	{
		for (int i = 0; i < sizeA; ++i) {
			for (int j = 0; j < sizeB; ++j) {
				matrix[i][j] = rand() % 10;
			}
		}
	}
	void show()
	{
		for (int i = 0; i < sizeA; ++i) {
			for (int j = 0; j < sizeB; ++j) {
				cout << matrix[i][j] << " ";
			}
			cout << endl;
		}
		cout << endl;
	}
	~Matrix()
	{
		if (sizeA) {
			for (int i = 0; i < sizeA; ++i) {
				delete[]matrix[i];
			}
			delete[]matrix;
		}
	}
};

void main()
{
	srand(time(NULL));
	Matrix A(3,5);
	A.fill();
	A.show();
	A.instElement();
	A.show();
}