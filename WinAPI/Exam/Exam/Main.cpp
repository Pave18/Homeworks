#include "header.h"

int WINAPI WinMain(HINSTANCE hInst, HINSTANCE hPrev, LPSTR lpszCmdLine, int nCmdShow)
{
	Notepad dlg;
	MSG msg;
	HWND hDialog = CreateDialog(hInst, MAKEINTRESOURCE(IDD_NOTEPAD), NULL, Notepad::DlgProc);
	HACCEL hAccel = LoadAccelerators(hInst, MAKEINTRESOURCE(IDR_ACCELERATOR1));
	ShowWindow(hDialog, nCmdShow);
	while (GetMessage(&msg, 0, 0, 0))
	{
		if (!TranslateAccelerator(hDialog, hAccel, &msg))
		{
			TranslateMessage(&msg);
			DispatchMessage(&msg);
		}
	}
	return msg.wParam;
}