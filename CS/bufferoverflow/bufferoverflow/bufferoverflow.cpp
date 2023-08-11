#include <cstdio>
#include <cstring>
#include <iostream>
void area(float radius);
using namespace std;
int main()
{
    area(12.5F);
    area(22.4F);
    area(12.5F);
    area(22.4F);
    area(12.5F);
    area(22.4F);
    area(12.5F);
    area(22.4F);
    
    return 0;
}

void area(float radius)
{
    static int count = 0;
    count++;
    if (count <= 1)
    {
        float area = 0.0F;
        area = 3.14F * radius * radius;
        cout << area;
    }
   

}