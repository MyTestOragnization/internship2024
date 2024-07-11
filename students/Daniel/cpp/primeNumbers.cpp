#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

// array of numbers 2...30
auto getNumbers(){
   vector<int> numbers {2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};
   return numbers;
}


vector<int> findPrimeNumbers(vector<int> numbers){
    vector<int>newnumbers=numbers;
    bool end = false;
    int maxsize,divider=2,curitem;
    vector<int>temparray;
    while(!end){

        maxsize=newnumbers.size();
        for (int i = 0; i < maxsize; i++){
            curitem=newnumbers.at(i);
     
            if(curitem%divider!=0 || curitem/divider==1){temparray.push_back(curitem);}
        }

        
        for(int y:temparray){
            newnumbers.push_back(temparray.at(y));
        }
        if(divider*divider>maxsize){
            end=true;
        }
        divider++;
    }

    return numbers;
}



int main(){
    
    cout << endl;
    for(int i : findPrimeNumbers(getNumbers())){
        cout << i << " ";
    }

    
}
/* 
 // array for prime numbers
    vector<int>primes{2};
    int maxvector;
    // current divider
    int p=2;
    // check if p in array of prime numbers
    vector<int>::iterator pInPrimes=std::find(numbers.begin(), numbers.end(), maxvector);
    
    while(pInPrimes!=numbers.end()){
        maxvector = numbers.size();
        pInPrimes= std::find(numbers.begin(), numbers.end(), maxvector);
        for(int i=maxvector;i>0;i--){

            if(pInPrimes!=numbers.end()){
                vector<int>::iterator InPrimes=std::find(numbers.begin(), numbers.end(), i);
                if(i/p==1){}
                else{
                    if(i%p==0){numbers.erase(InPrimes);}
                }
            }
        }
        p++;
    }
 */