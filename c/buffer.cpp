#include <cstdio>
#include <cstring>
#include <iostream>

const char* PASSWORD_FILE = "rictro";
using namespace std;
int main()
{
    char input[8];
    char password[8];

    sscanf(PASSWORD_FILE, "%s", input);

    cout << "Enter password: ";
    cin >> password;

    // Debug prints:
    cout << "Address of input: " << &input << "\n";
    cout << "Address of password: " << &password << "\n";
    cout << "Input: " << input << "\n";
    cout << "Password: " << password << "\n";

    if (strncmp(password, input, 8) == 0)
        cout << "Access granted\n";
    else
        cout << "Access denied\n";

    return 0;
}