#include<iostream>
void rec(void);
using namespace std;
static int count1 = 0;
int main()
{

	rec();
	return 0;
}

void rec(void)
{
	int arr[200] = { 0 };
	double test[100][10] = {0.0};
	long size = (count1+1) * (sizeof(test)+sizeof(arr));
	if (size > 800000)
	{
		cout << "Stack size is almost full! we need to stop here! " << endl;
		exit(1);
	}
	cout <<"total count is "<< ++count1<<"Stack Size becomes "<< count1 * (sizeof(test) + sizeof(arr)) <<"bytes" << endl;
	
	rec();
}