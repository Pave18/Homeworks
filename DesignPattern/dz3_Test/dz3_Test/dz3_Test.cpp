#include <iostream>
#include <vector>
#include <string>

#define QUESTIONnam 3
using namespace std;

class TestConnect
{
	friend class TestProcess;
	class TestProcess *Test;
public:
	TestConnect();
};

class TestProcess
{
	vector<int> answers;
public:
	void StartTest()
	{
		vector<string> QustNam;
		//Database questions
		QustNam.push_back("On planet Earth, there is life?");
		QustNam.push_back("Planet Earth was flat?");
		QustNam.push_back("It is true that the 4^4 = 256?");

		int counter = 0;
		for (int i = 0; i < QUESTIONnam; ++i) {
			cout << "QUESTION #" << counter + 1 << endl
				<< QustNam[counter] << endl
				<< "1. Yes 2. No" << endl;

			int YesOrNo;
			cin >> YesOrNo;
			switch (YesOrNo)
			{
			case 1:
				answers.push_back(1);
				break;
			case 2:
				answers.push_back(2);
				break;
			default:
				break;
			}

			++counter;
		}

	}
	int CheckTest()
	{
		int NumCorrAns = 0;
		for (int i = 0; i < QUESTIONnam; ++i) {
			if (answers[0] == 1 || answers[1] == 2 || answers[2] == 1)
				++NumCorrAns;
			else
				NumCorrAns = NumCorrAns;
		}
		return NumCorrAns;
	}

};

class TestIntroduction :public TestProcess
{
public:

};

class Testing :public TestProcess
{
public:

};

class Result :public TestProcess
{
public:

};


TestConnect::TestConnect()
{

}

int main()
{


	return 0;
}