#include <iostream>

// Function to check if three sides can form a triangle
bool isValidTriangle(double a, double b, double c)
{
    return (a + b > c) && (a + c > b) && (b + c > a);
}

int main()
{
    double a, b, c;

    // Input the lengths of the three sides
    std::cout << "Enter the lengths of the three sides: ";
    std::cin >> a >> b >> c;

    // Check if the sides form a valid triangle
    if (isValidTriangle(a, b, c))
    {
        std::cout << "The lengths can form a triangle." << std::endl;
    }
    else
    {
        std::cout << "The lengths cannot form a triangle." << std::endl;
    }

    return 0;
}
