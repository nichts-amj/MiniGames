#include <iostream>
#include <stdlib.h>
#include <time.h>
using namespace std;
void bintang(int jml)
{
	for(int i = 0; i < jml; i++)
	{
		cout << "**";
	}
	cout << endl;
}
int main(int argc, char** argv) 
{
	int nyawa = 3;
	int nilai = 0;
	bintang(15);
	while(nyawa != 0)
	{
		int random1 = rand() % 10 + 0;
		int random2 = rand() % 10 + 0;
		cout << "HP : " << nyawa << "           Nilai : " << nilai << endl;
		cout << endl;
		int hasil = random1 + random2;
		cout << "Berapa hasil dari " << random1 <<" + " << random2 <<" ? ";
		int jawaban;
		cin >> jawaban;
		cout << endl;
		if(jawaban == hasil)
		{
			cout << "Benar" << endl;
			nilai++;
		}
		else
		{
			cout << "Salah" << endl;
			nyawa--;
		}
		cout << endl;
		bintang(15);
		cout << endl;
	}
	cout << "Game Over" << endl;
	cout << endl;
	cout << "Nilai : "<< nilai << endl;
	return 0;
}