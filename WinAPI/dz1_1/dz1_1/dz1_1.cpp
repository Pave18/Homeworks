#define UNICODE

#include <windows.h>
#include<tchar.h>

#define NamWin 5

INT WINAPI WinMain(HINSTANCE hlnst, HINSTANCE hPrevInst, LPSTR lpszCmdLine, int nCmdShow)
{
	TCHAR szSummary[] = TEXT("View summary?");
	if ((MessageBox(0, szSummary, TEXT("Summary"), MB_YESNO)) == IDNO) {
		return 0;
	}

	TCHAR szName[] = TEXT("My name is Egor Pavlenko.");
	MessageBox(0, szName, TEXT("Name"), MB_OK);

	TCHAR szAge[] = TEXT("Birthday 30.04.96. I'm 19.");
	MessageBox(0, szAge, TEXT("Age"), MB_OK);

	TCHAR szCity[] = TEXT("I live in Minsk.");
	MessageBox(0, szCity, TEXT("City"), MB_OK);

	TCHAR szEnd[128] ;
	wsprintf(szEnd, TEXT("Look at the title. This average number of characters of %i windows."), NamWin);

	UINT nSize = (lstrlen(szSummary) + lstrlen(szName) + lstrlen(szAge) + lstrlen(szCity) + lstrlen(szEnd)) / NamWin;
	TCHAR buffer[4];
	wsprintf(buffer, TEXT("%i"), nSize);

	MessageBox(0, szEnd, buffer, MB_OK | MB_ICONINFORMATION);

	return 0;
}