#include<iostream>
#include<fstream>
#include<string>
using namespace std;
int readfile();
int savefile();

int main()
{
	ofstream saveFile ("E:\\CS2024\\sandbox\\save.txt",ios::app );
	if (!saveFile.is_open())
	{
		cout << "file io error" << endl;
		exit(0);
	}
	float r = 13.8;
	float a = 3.14 * r * r;
	saveFile << a << endl;
	saveFile.close();
	readfile();
	return 0;
}


int savefile()
{
	ofstream saveFile;
	saveFile.open("E:\\CS2024\\sandbox\\save.txt", ios::app);
	saveFile << "appending data" << endl;
	saveFile.close();

	return 0;
}


int readfile()
{
	char data[100];
	ifstream ifile;
	ifile.open("E:\\CS2024\\sandbox\\save.txt");
	while (ifile.getline(data, 100,'\n'))
	{		
		float area = stof(data);
		area = area / 2;
		cout << area << endl;
	}
	ifile.close();	
	return 0;
}