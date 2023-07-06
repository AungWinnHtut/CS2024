#include<stdio.h>
#define SIZE 5

void swap(int a, int b);
void realswap(int* a, int* b);

int main()
{
	int i = 10;
	int ia[SIZE] = { 1,2,3,4,5 };
	int* iptr = &ia[0];
	int avg = 0;
	int aaa = 10;
	int bbb = 20;
	realswap(&aaa, &bbb);
	printf("aaa = %d bbb=%d\n", aaa, bbb);
	
	
	
	
	
	return 0;
}
void swap(int a, int b) //int a = aaa; int b = bbb;
{
	int buffer = a;
	a = b;
	b = buffer;
}

void realswap(int *a, int *b) //int a = aaa; int b = bbb;
{
	int b1;
	int *buffer=&b1;
	*buffer = *a;
	*a = *b;
	*b = *buffer;
}