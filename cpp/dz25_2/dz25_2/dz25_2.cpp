#include <iostream>
#include <stdlib.h>
#include <time.h>
using namespace std;

#define J 11
#define Q 12
#define K 13
#define A 14

#define WinPl 1
#define WinDea 2
#define DRAW 3

class BlackJack
{
	char dealerArr[26];
	int dealer = 0;
	char playerArr[26];
	int player = 0;
	int koloda[52] = { 2, 2, 2, 2,
		3, 3, 3, 3,
		4, 4, 4, 4,
		5, 5, 5, 5,
		6, 6, 6, 6,
		7, 7, 7, 7,
		8, 8, 8, 8,
		9, 9, 9, 9,
		10, 10, 10, 10,
		J, J, J, J,
		Q, Q, Q, Q,
		K, K, K, K,
		A, A, A, A };
	int movesCointPlayer = 0;
	int movesCointDialer = 0;
public:
	void Game()
	{
		cout << "To begin the game of BLACK JACK!" << endl;

		movesPlayer();
		movesPlayer();

		while (dealer < 18)
		{
			movesDealer();
		}

		party();

		cout << endl << "\tGAME OVER" << endl;
	}

	void party()
	{
		system("cls");

		cout << "Your card: ";
		for (int i = 0; i < movesCointPlayer; ++i)
		{
			cout << playerArr[i] << " ";
		}
		cout << "Your score: " << player << endl;
		cout << endl << "1 - Take another card. \n2 - Open account." << endl << endl;

		int vibor;
		cin >> vibor;
		cin.get();
		switch (vibor)
		{
		case 1:
			movesPlayer();
			break;
		case 2:
			int a;
			a = check();
			Winer(a);
			showDealer();
			cout << endl;
			system("Pause");
			return;
		default:
			cout << "\tError";
			system("Pause");
			break;
		}
		party();
	}

	void movesDealer()
	{
		int rend = rand() % 53;
		if (koloda[rend] == J || koloda[rend] == Q || koloda[rend] == K || koloda[rend] == A)
		{
			if (koloda[rend] == A)
			{
				dealerArr[movesCointDialer] = 'A';
				if (dealer > 20)
					dealer += 1;
				else
					dealer += 11;
			}
			else
			{
				if (koloda[rend] == J)
					dealerArr[movesCointDialer] = 'J';
				if (koloda[rend] == Q)
					dealerArr[movesCointDialer] = 'Q';
				if (koloda[rend] == K)
					dealerArr[movesCointDialer] = 'K';
				if (koloda[rend] == A)
					dealerArr[movesCointDialer] = 'A';
				dealer += 10;
			}
		}
		else if (koloda[rend] >= 2 || koloda[rend] <= 10)
		{
			if (koloda[rend] == 2)
				playerArr[movesCointDialer] = '2';
			if (koloda[rend] == 3)
				playerArr[movesCointDialer] = '3';
			if (koloda[rend] == 4)
				playerArr[movesCointDialer] = '4';
			if (koloda[rend] == 5)
				playerArr[movesCointDialer] = '5';
			if (koloda[rend] == 6)
				playerArr[movesCointDialer] = '6';
			if (koloda[rend] == 7)
				playerArr[movesCointDialer] = '7';
			if (koloda[rend] == 8)
				playerArr[movesCointDialer] = '8';
			if (koloda[rend] == 9)
				playerArr[movesCointDialer] = '9';
			if (koloda[rend] == 10)
				playerArr[movesCointDialer] = '0';
			dealer += koloda[rend];
		}
		else if (koloda[rend] == '-')
		{
			movesDealer();
		}
		koloda[rend] = '-';
		++movesCointDialer;
	}

	void movesPlayer()
	{
		int rend = rand() % 53;
		if (koloda[rend] == J || koloda[rend] == Q || koloda[rend] == K || koloda[rend] == A)
		{
			if (koloda[rend] == A)
			{
				playerArr[movesCointPlayer] = 'A';
				if (player >= 20)
					player += 1;
				else
					player += 11;
			}
			else
			{
				if (koloda[rend] == J)
					playerArr[movesCointPlayer] = 'J';
				if (koloda[rend] == Q)
					playerArr[movesCointPlayer] = 'Q';
				if (koloda[rend] == K)
					playerArr[movesCointPlayer] = 'K';
				player += 10;
			}
		}
		else if (koloda[rend] >= 2 || koloda[rend] <= 10)
		{
			if (koloda[rend] == 2)
				playerArr[movesCointPlayer] = '2';
			if (koloda[rend] == 3)
				playerArr[movesCointPlayer] = '3';
			if (koloda[rend] == 4)
				playerArr[movesCointPlayer] = '4';
			if (koloda[rend] == 5)
				playerArr[movesCointPlayer] = '5';
			if (koloda[rend] == 6)
				playerArr[movesCointPlayer] = '6';
			if (koloda[rend] == 7)
				playerArr[movesCointPlayer] = '7';
			if (koloda[rend] == 8)
				playerArr[movesCointPlayer] = '8';
			if (koloda[rend] == 9)
				playerArr[movesCointPlayer] = '9';
			if (koloda[rend] == 10)
				playerArr[movesCointPlayer] = '0';
			player += koloda[rend];
		}
		else if (koloda[rend] == '-')
		{
			movesPlayer();
		}
		koloda[rend] = '-';
		++movesCointPlayer;
	}

	int check()
	{
		if (dealer == player)
			return DRAW;
		if (dealer < player)
		{
			if (player > 21) {
				if (dealer <= 21)
					return WinDea;
				else
					return WinPl;
			}
		}
		if (dealer > player)
		{
			if (dealer > 21) {
				if (player <= 21)
					return WinPl;
				else
					return WinDea;
			}
		}
	}

	void Winer(int a)
	{
		if (a == WinPl)
			cout << endl << "\tWin Player" << endl;
		if (a == WinDea)
			cout << endl << "\tWin Dealer" << endl;
		if (a == DRAW)
			cout << endl << "\tDRAW" << endl;
	}

	void showDealer()
	{
		cout << "Dealer card: ";
		for (int i = 0; i < movesCointDialer; ++i)
		{
			cout << dealerArr[i] << " ";
		}
		cout << "Dealer score: " << dealer << endl;
	}
};

int main()
{
	srand(time(NULL));
	BlackJack a;
	a.Game();
	return 0;
}