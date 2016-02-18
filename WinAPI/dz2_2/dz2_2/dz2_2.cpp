#define UNICOD

#include<Windows.h>
#include<tchar.h>

// размеры таковы так как подгон¤л под Windows 10
#define RIGHTwindow (640+16)
#define BOTTOMwindow (480+39)
#define BORDER 10

LRESULT CALLBACK WindowProc(HWND, UINT, WPARAM, LPARAM);

TCHAR szClassWindow[] = TEXT("dz2_2");

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

	hWnd = CreateWindowEx(NULL, szClassWindow, szClassWindow,
		WS_VISIBLE | WS_SYSMENU | WS_MINIMIZEBOX,
		CW_USEDEFAULT, CW_USEDEFAULT, RIGHTwindow, BOTTOMwindow,
		NULL, NULL, hInst, NULL);

	ShowWindow(hWnd, nCmdShow);
	UpdateWindow(hWnd);

	while (GetMessage(&lpMsg, NULL, 0, 0))
	{
		TranslateMessage(&lpMsg);
		DispatchMessage(&lpMsg);
	}
	return lpMsg.wParam;
}

TCHAR* mouse(const RECT& r, const int& x, const int& y) {

	if (x > r.left + BORDER && x < r.right - BORDER && y > r.top + BORDER && y < r.bottom - BORDER)
		return TEXT("Inside the border");

	else if (x == r.left + BORDER || x == r.right - BORDER || y == r.top + BORDER || y == r.bottom - BORDER)
		return TEXT("On border");

	else
		return TEXT("Outside the border");
}


LRESULT CALLBACK WindowProc(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam)
{
	HDC hdc;
	PAINTSTRUCT ps;
	RECT r;
	TCHAR str[128];

	switch (uMessage)
	{
	case WM_PAINT:
		hdc = BeginPaint(hWnd, &ps);

		r.top = BORDER;
		r.left = BORDER;
		r.right = RIGHTwindow - (16 + BORDER);
		r.bottom = BOTTOMwindow - (39 + BORDER);
		FillRect(hdc, &r, HBRUSH(CreateSolidBrush(RGB(0, 25, 255))));

		ValidateRect(hWnd, NULL);
		EndPaint(hWnd, &ps);
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_LBUTTONDOWN:
	{
		GetClientRect(hWnd, &r);
		int x = LOWORD(lParam);
		int y = HIWORD(lParam);

		SetWindowText(hWnd, mouse(r, x, y));

	}
	break;
	case WM_RBUTTONDOWN:
	{
		GetClientRect(hWnd, &r);
		int x = r.right;
		int y = r.bottom;
		wsprintf(str, TEXT("Bottom: %d Right: %d"), x, y);
	}
	SetWindowText(hWnd, str);
	break;
	default:
		return DefWindowProc(hWnd, uMessage, wParam, lParam);
	}
	return 0;
}