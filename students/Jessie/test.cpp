#include <iostream>
using namespace std;

int cube (int number){
    
    int cubednum = number * number * number;

    return   cubednum; 
}

int main(){

    string name;
    cout << "What's your name?" << endl;
    getline (cin, name);

    cout << "Hey! " << name << endl; 







        int result, number;

            cout << "enter a number "<< endl; 
            cin >> number;
            
            result = cube(number);
            cout << result << endl;







                float num1, num2; 
                float ans = 0;
                char op;

                cout << "please enter the first number ";
                cin >> num1;

                cout << "please select the operator ";
                cin >> op;

                cout << "please enter the second number ";
                cin >> num2;

                if(op == '+'){
                    ans = num1 + num2;                    

                } 
                else if(op == '-') {
                        ans = num1 - num2; 
                    
                }
                    else if(op == '/') {
                        ans = num1 / num2; 
                }

                    else if(op == '*') {
                        ans = num1 * num2; 
                    }

                    else{
                        cout << "invalid operator, try again with a valid operator " << endl;
                    }

            cout << " the asnwer is " << ans <<endl;

              




                cout << "try to guess the secret number" << endl;
                int secNum = 7;
                int guessNum;
                int guess_count = 0;
                cin>> guessNum;
              while(guessNum != secNum && guess_count < 3) {
                cout << "try again! " << endl;
                cin>> guessNum;  
                guess_count++;

                
            }
                if(guess_count>= 3)
                cout << "game over! " << endl;
                else 
                cout << "that's the correct number!!" << endl;





















    return 0;
}