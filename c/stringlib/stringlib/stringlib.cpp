#include<stdio.h>
#include<string.h>
#include<conio.h>

int strlen_k(const char* str);
int strlen_t(const char* start);
char* gets_k(char* str, int buffer_size, int echo = 0);
char* strcpy_k(char* dest, const char* source);
int strcmp_k(const char* s1, const char* s2);



int main()
{
	char arr[] = { '1','a','z','\0'};
	char name[] = "aungwinhtut";
	char pass[] = "1234";
	char uname[100]="";
	char password[100] = "";
	printf("Username: ");
	gets_k(uname,100,1);
	printf("\n");
	printf("Password: ");
	gets_k(password, 100, 0);
	int ans_name = strcmp_k(name, uname);
	int ans_pass = strcmp_k(pass, password);
	if (ans_name == 0 && ans_pass == 0)
	{
		printf("Logging in...\n");
	}
	else
	{
		printf("Wrong username or password\n");
	}
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

char * strcpy_k(char* dest, const char* source)
{
	int i = 0;
	while (source[i] != '\0')
	{
		dest[i] = source[i];
		i++;
	}
	dest[i] = '\0';
	return dest;
}

int strcmp_k(const char* s1, const char* s2)
{
	int l1 = strlen_k(s1);
	int l2 = strlen_k(s2);
	int ans = 0;
	if (l1 > l2)
	{
		return 1;
	}
	else if (l1 < l2)
	{
		return -1;
	}
	else
	{
		for (int i = 0; s1[i] != '\0'; i++)
		{		
				if (s1[i] > s2[i])
				{
					ans = 1;
					return ans;
				}
				else if (s1[i] < s2[i])
				{
					ans = -1;
					return ans;
				}
				// pass if equal, and unchange ans = 0
		}
	}
	return ans;
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
