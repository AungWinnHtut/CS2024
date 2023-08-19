#include<iostream>
using namespace std;
int main()
{
    int Level = 20;
    bool Motor = false;
    bool Yellow = false;
    bool Green = false;
    bool Red = false;

    if (Level <= 30 || Level >= 90) { //Level 30 နဲ့ 90 ကြား အလုပ်လုပ်မယ်
        Motor = true;    //မော်တာလည်မယ်
        Yellow = false;
        Green = false;
        if (Level >= 90) { //တစ်ခါ ဒီမှာ Level 90 ကျော်မကျော် စစ်ပြီး 
            Red = false;
            Green = true;
            Motor = false; //မော်တာ ပြန်ပိတ်လိုက်ပြန်တယ် ကုဒ်က သိပ်အဓိပ္ပါယ်မရှိဘူး
        }
        else {
            Red = true;
        }
    }
    else {
        if (!Motor) { //ဒါက မော်တာ မလည်နေရင်
            Motor = (Level < 30); //ဒီကုဒ်က အဓိပ္ပါယ်မရှိဘူး။ မော်တာက ture and false ပဲဆိုရင် 
        }
        Red = false;
        Yellow = true;
        Green = false;


	return 0;
}