#include<stdio.h>
void addi(int* ii); //int i = 44;
float area(float a, float b);
void printArray(int arr[], int count);
void printArray2(int* arr, int count);
int main()
{
	int i = 0;
	int* iptr = &i; //star with datatype => pointer creation	
	*iptr = 44;

	int ia[5] = { 1,2,3,4,5 };
	int* iaptr = ia; //ia = &ia[0];
	for (int i = 0; i < 5; i++)
	{
		printf("before adding i = %d and its address is %p \n", *(iaptr + i), iaptr+i);
		printf("before adding i = %d and its address is %p \n", ia[i],&ia[i]);
	}

	printArray2(ia, 5);


	 float g = area(12.5, 22.6);

	return 0;
}

void addi(int *k) //int * k = &i;
{
	*k = *k + 22;
}

float area(float a, float b)
{
	float area = a * b;
	return area;
}

void printArray(int arr[], int count)
{
	for (int i = 0; i < count; i++)
	{
		printf("values of array index %d is %d\n", i, arr[i]);
	}
}
void printArray2(int* arr, int count)
{
	for (int i = 0; i < count; i++)
	{
		printf("values of array index %d is %d\n", i, *(arr+i));
	}
}