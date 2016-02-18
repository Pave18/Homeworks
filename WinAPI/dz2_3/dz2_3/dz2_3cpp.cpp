#include<Windows.h>
#include<tchar.h>

LRESULT CALLBACK WindowProc(HWND, UINT, WPARAM, LPARAM);

TCHAR szClassWindow[] = TEXT("Dz2_3");

INT WINAPI WinMain(HINSTANCE hInst, HINSTANCE hPrevInst, LPSTR lpszCmdLine, int nCmdShow)
{
	HWND hWnd;
	MSG lpMsg;
	WNDCLASSEX wcl;
	wcl.cbSize = sizeof(wcl);
	wcl.style = CS_HREDRAW | CS_VREDRAW;
	wcl.lpfnWndProc = WindowProc;
	wcl.cbClsExtra = 0;
	wcl.cbWndExtra = 0;
	wcl.hInstance = hInst;
	wcl.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wcl.hCursor = LoadCursor(NULL, IDC_ARROW);
	wcl.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);
	wcl.lpszMenuName = NULL;
	wcl.lpszClassName = szClassWindow;
	wcl.hIconSm = NULL;

	if (!RegisterClassEx(&wcl))
	{
		return 0;
	}

	hWnd = CreateWindowEx(0, szClassWindow, szClassWindow,
		WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, CW_USEDEFAULT, 200,
		200, NULL, NULL, hInst, NULL);

	ShowWindow(hWnd, nCmdShow);
	UpdateWindow(hWnd);

	while (GetMessage(&lpMsg, NULL, 0, 0))
	{
		TranslateMessage(&lpMsg);
		DispatchMessage(&lpMsg);
	}
	return lpMsg.wParam;
}

LRESULT CALLBACK WindowProc(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam)
{
	switch (uMessage)
	{
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_LBUTTONDOWN:
	{

		TCHAR szSearchÑlass[] = TEXT("SciCalc");
		TCHAR szSearchTitle[] = TEXT("Êàëüêóëÿòîð Ïëþñ");

		TCHAR szNewTitle[] = TEXT("iCalc");

		HWND Calc = FindWindow(szSearchÑlass, szSearchTitle);
		if (!Calc) {
			MessageBox(hWnd, TEXT("It is necessary to open the Calculator!"), NULL, MB_OK | MB_ICONERROR);
		}
		else {
			SetWindowText(Calc, szNewTitle);
		}
	}
	break;
	case WM_RBUTTONDOWN:
	{
		HWND start = FindWindow(TEXT("Start"), TEXT("Ïóñê"));
		SetWindowText(start, TEXT("NO"));

		SetWindowPos(start, HWND_TOPMOST, 0, 200, 50, 20, SWP_SHOWWINDOW);

	}
	break;
	default:
		return DefWindowProc(hWnd, uMessage, wParam, lParam);
	}
	return 0;
}