#include<iostream>
using namespace std;
void area(float l, float w, float* a);
void changei(int* p);
int* area(int r[], int count);
int main()
{
	char name[20] = "aung win  htut";
	char name2[5] = { 'a','u','n','g','\0' };
	int r[5] = { 1,2,3,4,5 };
	int* a1;
	a1 = area(r, 5);

	for (int i = 0; i < 5; i++)
	{
		cout << *(a1 + i) << endl;
		cout << a1[i] << endl;
	}

}

int* area(int r[], int count)
{
	int a[5] = { 0 };
	for (int i = 0; i < count; i++)
	{
		a[i] = r[i] * 10;
	}
	return a;
}

void changei(int* p)
{
	int k = 10;
	*p = *p*k;
}

void area(float l, float w, float* a)
{
	*a = l * w;
}
