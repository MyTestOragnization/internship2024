#include <iostream>
#include <string>

using namespace std;

// Function to convert decimal number to hexadecimal
string decimalToHex(int decimalNumber)
{
    if (decimalNumber == 0)
    {
        return "0";
    }

    string hexDigits = "0123456789ABCDEF";
    string hexNumber = "";

    while (decimalNumber > 0)
    {
        int remainder = decimalNumber % 16;
        hexNumber = hexDigits[remainder] + hexNumber;
        decimalNumber /= 16;
    }

    return hexNumber;
}

int main()
{
    int decimalNumber;

    cout.clear();
    // Ask user for a decimal number
    cout << "Enter a decimal number: ";
    cin >> decimalNumber;

    // Convert decimal number to hexadecimal
    string hexNumber = decimalToHex(decimalNumber);

    // Output the hexadecimal number
    cout << "The hexadecimal equivalent is: " << hexNumber << endl;

    return 0;
}
