#include<iostream>
using namespace std;
int main()
{

	string msg = "i am aungk";
	int len = msg.length();
	int mod = len % 4;
	if (mod != 0)
	{
		int count = 4 - mod;
		for (int i = 0; i < count; i++)
		{
			msg.append("*");
		}
	}
	cout << msg << endl;


	return 0;
}