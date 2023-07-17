#include<iostream>
#include<fstream>
using namespace std;
int encryption();
int decryption();

int main()
{
	encryption();
	decryption();
	return 0;
}

int encryption()
{
	ifstream iFile;
	ofstream oFile;
	int key = 3;
	char line[200] = "";
	char cipher[200] = "";
	iFile.open("plaintext.txt", ios_base::in);
	oFile.open("cipher.txt", ios_base::app);

	if (!iFile.is_open() || !oFile.is_open())
	{
		cout << "Input FileIO error!, exiting...." << endl;
		exit(0);
	}
	while (iFile.getline(line, 200))
	{
		puts(line);
		int i = 0;
		for (i = 0; line[i] != '\0' && i < 200; i++)
		{
			cipher[i] = line[i] + key;
		}
		cipher[i++] = '\n';
		cipher[i] = '\0';
		oFile.write(cipher, 200);
		puts(cipher);
		for (int j = 0; j < 200; j++)
		{
			cipher[j] = '\0';
			line[j] = '\0';
		}
		
	}
	iFile.close();
	oFile.close();




	return 0;
}

int decryption()
{
	ifstream iFile;
	ofstream oFile;
	int key = 3;
	char line[200] = "";
	char cipher[200] = "";
	iFile.open("cipher.txt", ios_base::in);
	oFile.open("original.txt", ios_base::out);

	if (!iFile.is_open() || !oFile.is_open())
	{
		cout << "Input FileIO error!, exiting...." << endl;
		exit(0);
	}
	while (iFile.getline(line, 200))
	{
		puts(line);
		for (int i = 0; line[i] != '\0' && i < 200; i++)
		{
			cipher[i] = line[i] - key;
		}
		oFile.write(cipher, 200);
		puts(cipher);
	}
	iFile.close();
	oFile.close();




	return 0;
}