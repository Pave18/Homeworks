#include "header.h"
DWORD g_BytesTransferred = 0;
VOID CALLBACK FileIOCompletionRoutine(__in  DWORD dwErrorCode, __in  DWORD dwNumberOfBytesTransfered, __in  LPOVERLAPPED lpOverlapped);

Notepad* Notepad::ptr = nullptr;

Notepad::Notepad(void)
{
	ptr = this;
}

void Notepad::Cls_OnClose(HWND hwnd)
{
	if (!is_safed)
	{
		int result = MessageBox(hwnd, TEXT("Save?"), TEXT("INFO"), MB_OKCANCEL| MB_ICONQUESTION);

		if (result == IDOK)
		{
			TCHAR FullPath[MAX_PATH] = { 0 };
			OPENFILENAME open = { sizeof(OPENFILENAME) };
			open.hwndOwner = hwnd;
			open.lpstrFilter = TEXT("Text Files(*.txt)\0*.txt\0");
			open.lpstrFile = FullPath;
			open.nMaxFile = MAX_PATH;
			open.Flags = OFN_OVERWRITEPROMPT | OFN_PATHMUSTEXIST;
			open.lpstrDefExt = TEXT("txt");
			if (!GetSaveFileName(&open))
			{
				MessageBox(hwnd, TEXT("OpenFile_For_Save"), TEXT("ERROR!"), MB_OK | MB_ICONERROR);
				return;
			}
			SaveAs(FullPath);
		}
	}
	DestroyWindow(hwnd);
	PostQuitMessage(0);
}

BOOL Notepad::Cls_OnInitDialog(HWND hwnd, HWND hwndFocus, LPARAM lParam)
{
	hNote = GetDlgItem(hwnd, IDC_NOTE);
	hDialog = GetDlgItem(hwnd, IDD_NOTEPAD);

	return TRUE;
}

void Notepad::Cls_OnCommand(HWND hwnd, int id, HWND hwndCtl, UINT codeNotify)
{
	if (id == ID_SAVEAS)
	{
		TCHAR FullPath[MAX_PATH] = { 0 };
		OPENFILENAME open = { sizeof(OPENFILENAME) };
		open.hwndOwner = hwnd;
		open.lpstrFilter = TEXT("Text Files(*.txt)\0*.txt\0");
		open.lpstrFile = FullPath;
		open.nMaxFile = MAX_PATH;
		open.Flags = OFN_OVERWRITEPROMPT | OFN_PATHMUSTEXIST;
		open.lpstrDefExt = TEXT("txt");
		if (!GetSaveFileName(&open))
		{
			MessageBox(hwnd, TEXT("OpenFile_For_Save"), TEXT("ERROR!"), MB_OK | MB_ICONERROR);
			return;
		}
		SaveAs(FullPath);
	}
	if (id == ID_OPEN) {
		TCHAR FullPath[MAX_PATH] = { 0 };
		OPENFILENAME open = { sizeof(OPENFILENAME) };
		open.hwndOwner = hwnd;
		open.lpstrFilter = TEXT("Text Files(*.txt)\0*.txt\0All Files(*.*)\0*.*\0");
		open.lpstrFile = FullPath;
		open.nMaxFile = MAX_PATH;
		open.lpstrInitialDir = TEXT("C:\\");
		open.Flags = OFN_CREATEPROMPT | OFN_PATHMUSTEXIST | OFN_HIDEREADONLY;
		if (!GetOpenFileName(&open))
		{
			MessageBox(hwnd, TEXT("OpenFile_1st"), TEXT("ERROR!"), MB_OK | MB_ICONERROR);
			return;
		}
		Open(FullPath);
	}
	if (id == ID_EXIT)
	{
		Notepad::Cls_OnClose(hwnd);
	}
	if (id == ID_ABOUT)
	{
		MessageBox(hwnd, TEXT("This program is an examination work. by Pavlenko"), TEXT("ABOUT"), MB_OK | MB_ICONINFORMATION);
	}

}

BOOL CALLBACK Notepad::DlgProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	switch (message)
	{
		HANDLE_MSG(hWnd, WM_COMMAND, ptr->Cls_OnCommand);
		HANDLE_MSG(hWnd, WM_CLOSE, ptr->Cls_OnClose);
		HANDLE_MSG(hWnd, WM_INITDIALOG, ptr->Cls_OnInitDialog);
	}

	return FALSE;
}

VOID CALLBACK FileIOCompletionRoutine(__in  DWORD dwErrorCode, __in  DWORD dwNumberOfBytesTransfered, __in  LPOVERLAPPED lpOverlapped)
{
	g_BytesTransferred = dwNumberOfBytesTransfered;
}

void Notepad::SaveAs(TCHAR* path)
{
	HANDLE hFile;
	int SIZE = SendMessage(ptr->hNote, WM_GETTEXTLENGTH, 0, 0);
	TCHAR* DataBuffer = new TCHAR[SIZE];
	GetWindowText(ptr->hNote, DataBuffer, SIZE);
	DWORD dwBytesToWrite = 2 * (DWORD)lstrlen(DataBuffer);
	DWORD dwBytesWritten = 0;
	BOOL bErrorFlag = FALSE;
	hFile = CreateFile(path, GENERIC_WRITE, 0, NULL, CREATE_NEW, FILE_ATTRIBUTE_NORMAL, NULL);
	if (hFile == INVALID_HANDLE_VALUE)
	{
		MessageBox(ptr->hDialog, TEXT("CreateFile"), TEXT("ERROR!"), MB_OK | MB_ICONERROR);
		delete[] DataBuffer;
		return;
	}
	bErrorFlag = WriteFile(hFile, DataBuffer, dwBytesToWrite, &dwBytesWritten, NULL);
	if (FALSE == bErrorFlag)
	{
		MessageBox(ptr->hDialog, TEXT("WriteFile"), TEXT("ERROR!"), MB_OK | MB_ICONERROR);
		delete[] DataBuffer;
		CloseHandle(hFile);
		return;
	}
	else {
		if (dwBytesWritten != dwBytesToWrite)
			MessageBox(ptr->hDialog, TEXT("dwBytesWritten != dwBytesToWrite"), TEXT("ERROR!"), MB_OK | MB_ICONERROR);
		else
			MessageBox(ptr->hDialog, TEXT("DONE!"), TEXT("SUCCSESS!"), MB_OK);
	}

	delete[] DataBuffer;
	CloseHandle(hFile);
	ptr->is_safed = true;
}

void Notepad::Open(TCHAR* path)
{
	HANDLE hFile;
	hFile = CreateFile(path, GENERIC_READ, FILE_SHARE_READ, NULL, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL | FILE_FLAG_OVERLAPPED, NULL);
	if (hFile == INVALID_HANDLE_VALUE)
	{
		MessageBox(ptr->hDialog, TEXT("OpenFile_2nd"), TEXT("ERROR!"), MB_OK | MB_ICONERROR);
		return;
	}
	DWORD SIZE = GetFileSize(hFile, NULL);
	TCHAR* ReadBuffer = new TCHAR[SIZE];
	OVERLAPPED ol = { 0 };

	if (FALSE == ReadFileEx(hFile, ReadBuffer, SIZE, &ol, FileIOCompletionRoutine))
	{
		MessageBox(ptr->hDialog, TEXT("ReadFile"), TEXT("ERROR!"), MB_OK | MB_ICONERROR);
		CloseHandle(hFile);
		return;
	}
	ReadBuffer[SIZE - 1] = '\0';
	SetWindowText(ptr->hNote, LPTSTR(ReadBuffer));

	delete[] ReadBuffer;
	CloseHandle(hFile);
	ptr->is_safed = false;
}