#include <iostream>
#include <stack>
using namespace std;

string convertdechex(int dec)
{ 
    char arr[]={'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
    int remainder=0;
    char reminderCh;
    stack<char> stack;
    string result = "";

    while(dec>0){
        remainder=dec%16;
        reminderCh = arr[remainder];
        dec=dec/16;
//        cout<<reminderCh<<endl;
        stack.push(reminderCh);     
    }
     
    while(!stack.empty()){
        result += stack.top();
        stack.pop();
    }

    return result;
}

int main( ){
string res;
int dec;
cout<<"please enter the number"<<endl;
cin>>dec;

res=convertdechex(dec);
cout<<res<<endl;

    return 0;
}