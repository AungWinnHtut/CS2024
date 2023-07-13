#include<stdio.h>
#include<string.h>
#include<conio.h>

int strlen_k(const char* str);
int strlen_t(const char* start);
char* gets_k(char* str, int buffer_size, int echo = 0);





int main()
{
	char arr[] = { '1','a','z','\0'};
	char name[] = "aungwinhtut";
	char uname[100];
	printf("username: ");
	//fgets(uname,100,stdin);	
	gets_k(uname, 100,1);
	puts("This is you typed: ");
	puts(uname);
	
	


	return 0;
}

int strlen_k(const char* str)
{
	int count = 0;
	while (str[count] != '\0')
	{
		count++;
	}
	return count;
}

int strlen_t(const char* start)
{
	const char* end = start;
	while (*end != '\0')
	{
		end++;
	}
	return end - start;
}

char* gets_k(char* str, int buffer_size,int echo)
{
	char ch;
	int i = 0;
	while (((ch = _getch()) != '\r') && i<buffer_size )
	{
		if (echo == 1)
		{
			putchar(ch);
		}
		str[i] = ch;
		i++;
	}
	str[i] = '\0';
	return str;
}

/*
* 
#include <iostream>
#include <windows.h>
using namespace std;

	TCHAR getch() {
	DWORD mode, cc;
	HANDLE h = GetStdHandle(STD_INPUT_HANDLE);
	if (h == NULL) {
		return 0; // console not found
	}
	GetConsoleMode(h, &mode);
	SetConsoleMode(h, mode & ~(ENABLE_LINE_INPUT | ENABLE_ECHO_INPUT));
	TCHAR c = 0;
	ReadConsole(h, &c, 1, &cc, NULL);
	SetConsoleMode(h, mode);
	return c;
}

int main2() {
	TCHAR k;
	while ((k = getch()) != '\r') {
		cout << "Key: " << k << " = " << (int)k << endl;
	}
	return 0;
}
*/
