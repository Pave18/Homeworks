#define UNICODE

#include <windows.h>
#include "resource.h"

HWND hRest, hB1;
HBITMAP hX, hO; 

BOOL CALLBACK DlgProc(HWND, UINT, WPARAM, LPARAM);

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpszCmdLine, int nCmdShow)
{
	return DialogBox(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, DlgProc);
}

BOOL CALLBACK DlgProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	switch (message)
	{
	case WM_CLOSE:
		EndDialog(hWnd, 0);
		return TRUE;
	case WM_INITDIALOG:
		hRest = GetDlgItem(hWnd, ID_START);
		hX = LoadBitmap(GetModuleHandle(0), MAKEINTRESOURCE(IDC_Pl_1));
		hO = LoadBitmap(GetModuleHandle(0), MAKEINTRESOURCE(IDC_Pl_2));

		hB1= GetDlgItem(hWnd, IDC_BUTTON1);

		return TRUE;
	case WM_COMMAND:
		if (wParam == IDC_BUTTON1){
			SendMessage(hB1, STM_SETIMAGE, WPARAM(IMAGE_BITMAP), LPARAM(hX));
		}
			

		return TRUE;
	}
	return FALSE;
}