#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <cstdlib>
#include <ctime>
using namespace std;

class Student
{
private:
	string f_name;
	string l_name;
	int course;
public:
	Student()
	{
		cout << "Enter the first name: ";
		getline(cin, f_name);
		cout << "Enter the last name: ";
		getline(cin, l_name);
		cout << "Enter the course: ";
		cin >> course;
		cin.get();
	}

	Student(string f_name, string l_name, int course) : f_name(f_name), l_name(l_name), course(course)
	{}

	friend std::ostream& operator << (ostream& out, Student& student);

	const string& getF_name() const 
	{ 
		return f_name; 
	}
	const string& getL_name() const 
	{ 
		return l_name; 
	}
	int getCourse() const 
	{ 
		return course; 
	}
};

ostream& operator << (ostream& out, Student& student)
{
	out << "First name:\t" << student.f_name << endl;
	out << "Last name:\t" << student.l_name << endl;
	out << "Course:\t\t" << student.course << endl;
	return out;
}

void fillVector(vector<Student>& vect, int size)
{
	for (int i = 0; i < size; ++i) {
		Student newStudent;
		vect.push_back(newStudent);
		cout << endl;
	}
}

void fill_rand_Vector(vector<Student>& vect, int size)
{
	for (int i = 0; i < size; ++i) {
		int random = rand() % 6;

		if(random==1){
			Student newStudent1("Ivan", "Lolov", 1);
			vect.push_back(newStudent1);
		}
		if (random == 2) {
			Student newStudent2("Marina", "Vlasova", 2);
			vect.push_back(newStudent2);
		}
		if (random == 3) {
			Student newStudent3("Ekaterina", "Kovgan", 3);
			vect.push_back(newStudent3);
		}
		if (random == 4) {
			Student newStudent4("Den", "Rynec", 4);
			vect.push_back(newStudent4);
		}
		if (random == 5) {
			Student newStudent5("Kaban", "Nikola", 5);
			vect.push_back(newStudent5);
		}

		
		cout << endl;
	}
}

void showVector(vector<Student>& vect)
{
	for (size_t i = 0, size = vect.size(); i < size; ++i) {
		cout << vect.at(i) << endl;
	}
}

//sortirovka
bool Sortf_name(const Student& s1, const Student& s2) 
{ 
	return s1.getF_name() < s2.getF_name(); 
}
bool Sortl_name(const Student& s1, const Student& s2) 
{ 
	return s1.getL_name() < s2.getL_name(); 
}
bool Sortcourse(const Student& s1, const Student& s2) 
{ 
	return s1.getCourse() < s2.getCourse(); 
}

int main()
{
	srand(time(NULL));

	vector<Student> a;
	fill_rand_Vector(a, 5);
	showVector(a);

	cout << "___________________"<<endl;
	sort(a.begin(), a.end(), Sortf_name);
	showVector(a);

	cout << "___________________" << endl;
	sort(a.begin(), a.end(), Sortl_name);
	showVector(a);

	cout << "___________________" << endl;
	sort(a.begin(), a.end(), Sortcourse);
	showVector(a);

	return 0;
}