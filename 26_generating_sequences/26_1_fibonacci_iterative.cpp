#include <iostream>
#include <vector>

// Function to generate Fibonacci sequence up to n terms and find the nth term
int fibonacciIterative(int n)
{
    if (n <= 1)
        return n;

    int a = 0, b = 1, c;
    for (int i = 2; i <= n; ++i)
    {
        c = a + b;
        a = b;
        b = c;
    }
    return b;
}

int main()
{
    int n;
    std::cout << "Enter the term number: ";
    std::cin >> n;

    std::cout << "Fibonacci term " << n << " is " << fibonacciIterative(n) << std::endl;
    return 0;
}
