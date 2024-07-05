#include <iostream>
#include <math.h>
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

int converthex2dec(string inVal)
{ 
    char first = inVal[0];
    int tmp = first;
    int digitval[inVal.length()];
    int result = 0;

    for (int i=0; i < inVal.length(); ++i)
    {
    digitval[i] = hexDigitToDecimal(inVal[i]);
      // cout<<digitval[i]<<endl;
    //    digitval[i] = digitval[i]*pow(16,inVal.length()-i-1);
    //    result = result + digitval[i];


       result = result + digitval[i]*pow(16,inVal.length()-i-1);

    }
 
    return result;
}

int main( ){
    int res;
    string inVal;
    cout << "please enter the number"<<endl;
    cin >> inVal;

    res=converthex2dec(inVal);
    cout<<res<<endl;

    return 0;
}