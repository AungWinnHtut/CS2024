#include<stdio.h> //preprocessor directive
#define pi 3.14156

int main()
{
	int a;
	int b = 10;
	int c = 12;
	int arr[5];
	int brr[5] = { 1,2,3,4,5 };
	printf("arr = 0x%x\n", arr);
	printf("&arr[0] = 0x%x\n", &arr[0]);
	printf("&arr[1] = 0x%x\n", &arr[1]);
	printf("&arr[2] = 0x%x\n", &arr[2]);
	printf("&arr[3] = 0x%x\n", &arr[3]);
	printf("&arr[4] = 0x%x\n", &arr[4]);
	
	return 0;
}