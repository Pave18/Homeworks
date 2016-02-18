#include <iostream>
#include <vector>
#include <stdlib.h>
#include <time.h>
using namespace std;


void Vector(vector<int> &v, int size) {
	v.resize(size);
	for (int i = 0; i < v.size(); ++i) {
		v[i] = rand() % 10;
		cout << (v[i] = v[i] * v[i]) << " ";
	}
	cout << endl;
}


int main() {
	srand(time(NULL));

	vector<int> test;
	Vector(test, 10);

	return 0;
}
