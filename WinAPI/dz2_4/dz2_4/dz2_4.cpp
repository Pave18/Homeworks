#define UNICODE

#include<Windows.h>
#include<tchar.h>

LRESULT CALLBACK WindowProc(HWND, UINT, WPARAM, LPARAM);

TCHAR szClassWindow[] = TEXT("Dz2_4");

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
	wcl.hbrBackground = (HBRUSH)GetStockObject(BLACK_BRUSH);
	wcl.lpszMenuName = NULL;
	wcl.lpszClassName = szClassWindow;
	wcl.hIconSm = NULL;

	if (!RegisterClassEx(&wcl))
	{
		return 0;
	}

	hWnd = CreateWindowEx(0, szClassWindow, szClassWindow,
		WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, CW_USEDEFAULT, CW_USEDEFAULT,
		CW_USEDEFAULT, NULL, NULL, hInst, NULL);

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
	static int X = 0, Y = 0;

	switch (uMessage)
	{
	case WM_KEYDOWN:
		if (wParam == VK_RETURN) 
			MoveWindow(hWnd, X = 0, Y = 0, 300, 300, 1);

		if (wParam == VK_DOWN)
			MoveWindow(hWnd, X, Y += 10, 300, 300, 1);

		if (wParam == VK_UP)
			MoveWindow(hWnd, X, Y -= 10, 300, 300, 1);

		if (wParam == VK_RIGHT)
			MoveWindow(hWnd, X += 10, Y, 300, 300, 1);

		if (wParam == VK_LEFT)
			MoveWindow(hWnd, X -= 10, Y, 300, 300, 1);

		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	default:
		return DefWindowProc(hWnd, uMessage, wParam, lParam);
	}
	return 0;
}