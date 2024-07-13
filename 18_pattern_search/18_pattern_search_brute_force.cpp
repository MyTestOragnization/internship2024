#include <iostream>
#include <string>

void bruteForceSearch(const std::string &text, const std::string &pattern)
{
    int n = text.length();
    int m = pattern.length();

    for (int i = 0; i <= n - m; i++)
    {
        int j;
        for (j = 0; j < m; j++)
        {
            if (text[i + j] != pattern[j])
            {
                break;
            }
        }
        if (j == m)
        {
            std::cout << "Pattern found at index " << i << std::endl;
        }
    }
}

int main()
{
    std::string text = "ababcabcabababd";
    std::string pattern = "ababd";
    bruteForceSearch(text, pattern);
    return 0;
}
