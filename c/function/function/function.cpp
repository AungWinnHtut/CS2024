#include<stdio.h>
void greet(void); //declaration fo a function
float area(float a, float b);
float volume(float area, float height);
int main()
{
	float a1=0.0;
	float a2=0.0;
	float a3=0.0;
	a1 = area(12.5,3.8);
	a2 = area(2.9, 11.0);
	a3 = area(1090.34, 12.66);
	float v1 = volume(a1, 3.5);
	float v2 = volume(area(12.5, 6.7), 44.5);
	printf("area 1 = %f , area 2 = %f and area 3 = %f and volume 1 = %f\n", a1, a2, a3, v1);

	return 0;
}

void greet(void) //define a fun
{
	printf("Hello\n");
	printf("I am Dr. Aung Win Htut\n");
}


float area(float a,  float b)
{	
	float area = a * b;
	return area;
}

float volume(float area, float height)
{
	float v = area * height;
	return v;
}

