#define UNICODE

#include <windows.h>
#include <windowsX.h>
#include <commctrl.h>
#include "resource.h"
#pragma comment(lib,"comctl32")
#define MAX 255
#define MIN 0

class ChangeColor
{
	static ChangeColor* ptr;
	HWND hDialog, hProgress;
	HWND hSlider[3];
	enum { RED, GREEN, BLUE };
public:
	ChangeColor(void);
	static BOOL CALLBACK DlgProc(HWND hWnd, UINT mes, WPARAM wp, LPARAM lp);
	BOOL Cls_OnInitDialog(HWND hwnd, HWND hwndFocus, LPARAM lParam);
	void Cls_OnHScroll(HWND hwnd, HWND hwndCtl, UINT code, int pos);
	void Cls_OnClose(HWND hwnd);
};

int WINAPI WinMain(HINSTANCE hInst, HINSTANCE hPrev, LPSTR lpszCmdLine, int nCmdShow)
{
	INITCOMMONCONTROLSEX icc = { sizeof(INITCOMMONCONTROLSEX) };
	icc.dwICC = ICC_WIN95_CLASSES;
	InitCommonControlsEx(&icc);
	ChangeColor dlg;
	return DialogBox(hInst, MAKEINTRESOURCE(IDD_DIALOG1), NULL, ChangeColor::DlgProc);
}

ChangeColor* ChangeColor::ptr = NULL;

ChangeColor::ChangeColor(void)
{
	ptr = this;
}

void ChangeColor::Cls_OnClose(HWND hwnd)
{
	EndDialog(hwnd, 0);
}

BOOL ChangeColor::Cls_OnInitDialog(HWND hwnd, HWND hwndFocus, LPARAM lParam)
{
	hDialog = hwnd;
	hProgress = GetDlgItem(hDialog, IDC_PROGRESS1);
	for (int i = RED; i <= BLUE; ++i)
	{
		hSlider[i] = GetDlgItem(hDialog, IDC_SLIDER1 + i);
		SendMessage(hSlider[i], TBM_SETRANGE, TRUE, MAKELPARAM(MIN, MAX));
	}
	SendMessage(hProgress, PBM_SETBKCOLOR, 0, LPARAM(RGB(0, 0, 0)));

	return TRUE;
}

void ChangeColor::Cls_OnHScroll(HWND hwnd, HWND hwndCtl, UINT code, int pos)
{
	TCHAR text[64];
	int colors_pos[3];

	for (int i = RED; i <= BLUE; ++i)
		colors_pos[i] = SendMessage(hSlider[i], TBM_GETPOS, TRUE, MAKELPARAM(MIN, MAX));

	wsprintf(text, TEXT("RED: %d   GREEN: %d   BLUE: %d"), colors_pos[RED], colors_pos[GREEN], colors_pos[BLUE]);
	SetWindowText(hwnd, text);
	SendMessage(hProgress, PBM_SETBKCOLOR, 0, LPARAM(RGB(colors_pos[RED], colors_pos[GREEN], colors_pos[BLUE])));
}

BOOL CALLBACK ChangeColor::DlgProc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	switch (message)
	{
		HANDLE_MSG(hwnd, WM_CLOSE, ptr->Cls_OnClose);
		HANDLE_MSG(hwnd, WM_INITDIALOG, ptr->Cls_OnInitDialog);
		HANDLE_MSG(hwnd, WM_HSCROLL, ptr->Cls_OnHScroll);
	}
	return FALSE;
}

