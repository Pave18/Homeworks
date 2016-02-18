#include <iostream>
#include <vector>
using namespace std;

class MultiplicationTable
{
	vector<vector<int>> imatrix;
public:

	MultiplicationTable(int nam)
	{
		const size_t row = nam;
		const size_t col = nam;
		vector<vector<int>> imatrix(row);

		for (size_t i = 0; i < row; ++i){
			imatrix[i].resize(col);
			for (size_t j = 0; j < col; ++j)
				imatrix[i][j] = (j + 1);
		}

		for (size_t i = 0; i < row; ++i){
			for (size_t j = 0; j < col; ++j){
				if (j != 0)
					imatrix[i][j] *= (i + 1);
			}


		}
		this->imatrix = imatrix;

		show();
	}


	void show()
	{

		for (size_t i = 0, size = imatrix.size(); i < size; ++i){
			for (size_t j = 0; j < size; ++j){
				if (j == 0){
					if (i == 0)
						cout << "    ";
					else
					cout << " " << i + 1 << "  ";
				}
				else{
					if (imatrix[i][j] < 10)
						cout << " " << imatrix[i][j] << "  ";
					else
						cout << imatrix[i][j] << "  ";
				}
			}
			cout << endl;
		}
	}

};


int main()
{
	MultiplicationTable a(9);

	return 0;
}

