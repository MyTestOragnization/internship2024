#include <iostream>
#include <string>
#include <cmath>
#include <cctype>

using namespace std;

// Function to convert a single hexadecimal digit to its decimal value
int hexDigitToDecimal(char hexDigit)
{
    if (hexDigit >= '0' && hexDigit <= '9')
    {
        return hexDigit - '0';
    }
    else if (hexDigit >= 'A' && hexDigit <= 'F')
    {
        return hexDigit - 'A' + 10;
    }
    else if (hexDigit >= 'a' && hexDigit <= 'f')
    {
        return hexDigit - 'a' + 10;
    }
    else
    {
        throw invalid_argument("Invalid hexadecimal digit");
    }
}

// Function to convert hexadecimal number to decimal
int hexToDecimal(const string hexNumber)
{
    int decimalNumber = 0;
    int length = hexNumber.length();

    for (int i = 0; i < length; ++i)
    {
        char hexDigit = hexNumber[length - i - 1];
        int decimalValue = hexDigitToDecimal(hexDigit);
        decimalNumber += decimalValue * pow(16, i);
    }

    return decimalNumber;
}

int main()
{
    string hexNumber;

    cout.clear();

    // Ask user for a hexadecimal number
    cout << endl
         << endl
         << "Enter a hexadecimal number: ";
    cin >> hexNumber;

    try
    {
        // Convert hexadecimal number to decimal
        int decimalNumber = hexToDecimal(hexNumber);

        // Output the decimal number
        cout << "The decimal equivalent is: " << decimalNumber << endl;
    }
    catch (const invalid_argument &e)
    {
        cerr << e.what() << endl;
    }

    return 0;
}
