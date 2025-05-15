// LuckyRecursion.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <iomanip>
using namespace std;
int luckyNumber(int n) {

    if (n < 3) {
        return 0;
    }
    return luckyNumber(n - 1) + 2 * luckyNumber(n - 2);
}
int main()
{
    int N = 0;
    cout << "Enter your lucky number: ";
    cin >> N;
    cout << "Your lucky number is " << luckyNumber(N);
}




