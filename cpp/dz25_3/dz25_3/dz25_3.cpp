#include <iostream>
#include <stdarg.h>
using namespace std;

void printf(char* str, ...) {
	va_list arg_ptr;
	va_start(arg_ptr, str);
	while (*str != '\0') {
		if (*str == '%' && *(str + 1) == 'i'){
			cout << va_arg(arg_ptr, int);
			str += 2;
		}
		else if (*str == '%' && *(str + 1) == 'd'){
			cout << va_arg(arg_ptr, double);
			str += 3;
		}
		else if (*str == '%' && *(str + 1) == 's') {
			cout << va_arg(arg_ptr, char*);
			str += 2;
		}
		else {
			cout.put(*str);
			++str;
		}
	}
	va_end(arg_ptr);
}

int main() {

	int A = 866;
	double B = 366.66666666;

	printf("\\n \n %i %d %s", A, B, " str \n");


	return 0;
}

