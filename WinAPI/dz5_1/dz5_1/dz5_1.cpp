#define UNICODE

#include <random>
#include <windows.h>
#include <windowsX.h>
#include "resource.h"

class UsingListboxDlg
{	
	HWND hDialog, hList, hButton, hEdit, hRadio1, hRadio2, hRadio3;
	static UsingListboxDlg* ptr;
	int sum = 0;
	double mult = 1;
	double avg;
public:
	UsingListboxDlg(void);
	static BOOL CALLBACK DlgProc(HWND hWnd, UINT mes, WPARAM wp, LPARAM lp);
	BOOL Cls_OnInitDialog(HWND hwnd, HWND hwndFocus, LPARAM lParam);
	void Cls_OnCommand(HWND hwnd, int id, HWND hwndCtl, UINT codeNotify);
	void Cls_OnClose(HWND hwnd);
};

int WINAPI WinMain(HINSTANCE hInst, HINSTANCE hPrev, LPSTR lpszCmdLine, int nCmdShow)
{
	UsingListboxDlg dlg;
	return DialogBox(hInst, MAKEINTRESOURCE(IDD_DIALOG1), NULL, UsingListboxDlg::DlgProc);
}

UsingListboxDlg* UsingListboxDlg::ptr = NULL;

UsingListboxDlg::UsingListboxDlg(void)
{
	ptr = this;
}

void UsingListboxDlg::Cls_OnClose(HWND hwnd)
{
	EndDialog(hwnd, 0);
}

BOOL UsingListboxDlg::Cls_OnInitDialog(HWND hwnd, HWND hwndFocus, LPARAM lParam)
{
	hList = GetDlgItem(hwnd, IDC_LIST1);
	hButton = GetDlgItem(hwnd, IDC_BUTTON1);
	hEdit = GetDlgItem(hwnd, IDC_EDIT1);
	hRadio1 = GetDlgItem(hwnd, IDC_RADIO1);
	hRadio2 = GetDlgItem(hwnd, IDC_RADIO2);
	hRadio3 = GetDlgItem(hwnd, IDC_RADIO3);
	SendMessage(hRadio1, BM_SETCHECK, BST_CHECKED, 0);

	return TRUE;
}

void UsingListboxDlg::Cls_OnCommand(HWND hwnd, int id, HWND hwndCtl, UINT codeNotify)
{
	if (id == IDC_BUTTON1)
	{
		SendMessage(hList, LB_RESETCONTENT, 0, 0);
		TCHAR result[32];
		std::random_device rd;
		int count = rd() % 11 + 10;
		for (int i = 0; i < count; ++i)
		{
			int next_number = rd() % 21 - 10;
			if (next_number)
			{
				sum += next_number;
				mult *= next_number;
				wsprintf(result, TEXT("%d"), next_number);
				SendMessage(hList, LB_ADDSTRING, 0, LPARAM(result));
			}
			else
				--i;
		}
		avg = double(sum) / count;

		if (IsDlgButtonChecked(hwnd, IDC_RADIO1))
			_swprintf(result, TEXT("%ld"), sum);
		if (IsDlgButtonChecked(hwnd, IDC_RADIO2))
			_swprintf(result, TEXT("%.0lf"), mult);
		if (IsDlgButtonChecked(hwnd, IDC_RADIO3))
			_swprintf(result, TEXT("%lf"), avg);

		SetWindowText(hEdit, result);
	}
}

BOOL CALLBACK UsingListboxDlg::DlgProc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	switch (message)
	{
		HANDLE_MSG(hwnd, WM_CLOSE, ptr->Cls_OnClose);
		HANDLE_MSG(hwnd, WM_INITDIALOG, ptr->Cls_OnInitDialog);
		HANDLE_MSG(hwnd, WM_COMMAND, ptr->Cls_OnCommand);
	}
	return FALSE;
}