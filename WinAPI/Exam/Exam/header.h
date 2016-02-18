#pragma once
#include <Windows.h>
#include <windowsx.h>
#include <tchar.h>
#include "resource.h"

class Notepad
{
public:
	Notepad(void);
	static BOOL CALLBACK DlgProc(HWND hWnd, UINT mes, WPARAM wp, LPARAM lp);
	BOOL Cls_OnInitDialog(HWND hwnd, HWND hwndFocus, LPARAM lParam);
	void Cls_OnCommand(HWND hwnd, int id, HWND hwndCtl, UINT codeNotify);
	void Cls_OnClose(HWND hwnd);
	static void SaveAs(TCHAR* path);
	static void Open(TCHAR* path);

	static Notepad* ptr;
	HWND hNote, hDialog;
	bool is_safed = false;
};