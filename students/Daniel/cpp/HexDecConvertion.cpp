#include <iostream>
#include<cmath>
#include<map>
#include <bits/stdc++.h>
using namespace std;

void HexToDec(string hexNumber, map<int,int> hexMap){

        int power = 0;
        int sum = 0;
        for(int s=hexNumber.size()-1; s>=0; s--){
            cout << hexMap.find(int(hexNumber[s]))->second << endl;
            sum+=pow(16,power)* hexMap.find(int(hexNumber[s]))->second;
            power+=1;
        }
        cout << sum;
    }

void DecToHex(int decNumber,map<int, string> decMap){
    string hexNum;
    int nextnum=decNumber;
    while(nextnum>0){
        int remainder = nextnum%16;
        nextnum=(nextnum-remainder)/16;
        if(remainder>9){
            hexNum += decMap.find(remainder)->second;
        }
        else{
            hexNum += to_string(remainder);
        }

    }
    reverse(hexNum.begin(),hexNum.end());
    cout << hexNum;
}
int main() {


    map<int, int> hexMap;
    hexMap.insert(make_pair(48,0));
    hexMap.insert(make_pair(49,1));
    hexMap.insert(make_pair(50,2));
    hexMap.insert(make_pair(51,3));
    hexMap.insert(make_pair(52,4));
    hexMap.insert(make_pair(53,5));
    hexMap.insert(make_pair(54,6));
    hexMap.insert(make_pair(55,7));
    hexMap.insert(make_pair(56,8));
    hexMap.insert(make_pair(57,9));
    hexMap.insert(make_pair(65,10));
    hexMap.insert(make_pair(66,11));
    hexMap.insert(make_pair(67,12));
    hexMap.insert(make_pair(68,13));
    hexMap.insert(make_pair(69,14));
    hexMap.insert(make_pair(70,15));

    map<int,string> decMap;
    decMap.insert(make_pair(10,"A"));
    decMap.insert(make_pair(11,"B"));
    decMap.insert(make_pair(12,"C"));
    decMap.insert(make_pair(13,"D"));
    decMap.insert(make_pair(14,"E"));
    decMap.insert(make_pair(15,"F"));

    int numberDec;
    cin>>numberDec;
    DecToHex(numberDec, decMap);
    
    // string numberHex;
    // cin>>numberHex;
    // HexToDec(number, hexMap);
    string exit;
    cin >> exit;
}