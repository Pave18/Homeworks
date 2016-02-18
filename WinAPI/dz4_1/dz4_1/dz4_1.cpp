#define UNICODE

#include <windows.h>
#include <tchar.h>
#include "resource.h"

HWND hFirst, hOperation, hSecond, hCalculate, hResult;
double result;

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
		hFirst = GetDlgItem(hWnd, IDC_EDIT1);
		hOperation = GetDlgItem(hWnd, IDC_EDIT2);
		hSecond = GetDlgItem(hWnd, IDC_EDIT3);
		hCalculate = GetDlgItem(hWnd, IDC_BUTTON1);
		hResult = GetDlgItem(hWnd, IDC_STATIC1);
		return TRUE;
	case WM_COMMAND:
		if (LOWORD(wParam) == IDC_BUTTON1)
		{
			TCHAR text[124], first[32], second[32], operation[2];
			GetWindowText(hFirst, first, 20);
			GetWindowText(hSecond, second, 20);
			GetWindowText(hOperation, operation, 2);
			if (lstrlen(first) == 0)
			{
				MessageBox(hWnd, TEXT("Enter the first number!"), NULL, MB_OK);
				return TRUE;
			}
			if (lstrlen(second) == 0)
			{
				MessageBox(hWnd, TEXT("Enter the second number!"), NULL, MB_OK);
				return TRUE;
			}
			if (lstrlen(operation) == 0)
			{
				MessageBox(hWnd, TEXT("Enter the operation!"), NULL, MB_OK);
				return TRUE;
			}
			if (operation[0] != '+' && operation[0] != '-' && operation[0] != '/' && operation[0] != '*')
			{
				MessageBox(hWnd, TEXT("Enter the operation!"), NULL, MB_OK);
				return TRUE;
			}

			{
				long first_number = _wtol(first);
				long second_number = _wtol(second);

				switch (operation[0])
				{
				case '+':
					result = first_number + second_number;
					break;
				case '-':
					result = first_number - second_number;
					break;
				case '/':
					result = double(first_number) / second_number;
					break;
				case '*':
					result = first_number * second_number;
					break;
				}

				swprintf(text, TEXT("= %lf"), result);
			}

			SetWindowText(hResult, text);
			SetWindowText(hFirst, 0);
			SetWindowText(hSecond, 0);
			SetWindowText(hOperation, 0);
			SetFocus(hCalculate);
		}
		return TRUE;
	}
	return FALSE;
}