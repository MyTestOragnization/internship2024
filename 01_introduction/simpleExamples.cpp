#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int numWords;
    cout.clear();
    cout << "Enter the number of words you want to input: " << endl;
    cin >> numWords;

    // Create a vector to store the words
    vector<string> words(numWords);

    // Ask the user to input the words
    cout << "Please enter " << numWords << " words:" << endl;
    for (int i = 0; i < numWords; ++i)
    {
        cin >> words[i];
    }

    // Print the words
    cout << "You entered the following words:" << endl;
    for (const string &word : words)
    {
        cout << word << endl;
    }

    return 0;
}
