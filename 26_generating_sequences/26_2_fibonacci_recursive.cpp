#include <iostream>

int fibonacciRecursive(int n)
{
    if (n <= 1)
        return n;
    return fibonacciRecursive(n - 1) + fibonacciRecursive(n - 2);
}

int main()
{
    int n;
    std::cout << "Enter the term number: ";
    std::cin >> n;

    std::cout << "Fibonacci term " << n << " is " << fibonacciRecursive(n) << std::endl;
    return 0;
}
