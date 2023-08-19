#include<iostream>
#include<array>
#include "test.h"
using namespace std;

class Student {
private:
	int age;
public:
	int id;
	void setAge(int Iage)
	{
		age = Iage;
	}
	int getAge()
	{
		return age;
	}
};

int marks = 0;
void funA(int& k);
int main()
{
	Student ayeaye;
	ayeaye.id = 22;
	
	ayeaye.setAge(12);
	cout << ayeaye.getAge();
	return 0;
}

void funA(int& k)
{
	k = 44;
}