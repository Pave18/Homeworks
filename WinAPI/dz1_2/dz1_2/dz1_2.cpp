#define UNICODE

#include <windows.h>
#include<tchar.h>

int guess()
{
	TCHAR szTitle[] = TEXT("Guessing numbers");
	TCHAR szMessage[128];
	int counter = 1, num = 50;

	while (true) {

		wsprintf(szMessage, TEXT("Unknown number: %i\n YES - more.\n NO - less.\n CANCEL - Yes, it is the hidden numbers!"), num);
		int YesNoCancel = (MessageBox(0, szMessage, szTitle, MB_YESNOCANCEL));

		switch (YesNoCancel)
		{
		case IDYES:
			num += 1;
			if (num > 100) {
				MessageBox(0, TEXT("Error: Going beyond. "), NULL, MB_OK);
				return 0;
			}
			++counter;
			break;
		case IDNO:
			num -= 1;
			if (num < 1) {
				MessageBox(0, TEXT("Error: Going beyond. "), NULL, MB_OK);
				return 0;
			}
			++counter;
			break;
		case IDCANCEL:
			return counter;
		default:
			break;
		}
	}
}

INT WINAPI WinMain(HINSTANCE hlnst, HINSTANCE hPrevInst, LPSTR lpszCmdLine, int nCmdShow)
{

	TCHAR szTitle[] = TEXT("Guessing numbers");

	if (MessageBox(0, TEXT("Think of a number between 1 and 100.\n\n\tStart the game?"), szTitle, MB_YESNO | MB_ICONQUESTION) == IDNO) {
		return 0;
	}

	while (true) {
		int move = 0;
		move = guess();
		if (move == 0)
			return 0;
		else {
			TCHAR szPlayAgain[64];
			wsprintf(szPlayAgain, TEXT("I guess for %i moves\nPlay again?"), move);

			if ((MessageBox(0, szPlayAgain, szTitle, MB_YESNO)) == IDNO)
				break;

		}
	}

	return 0;
}