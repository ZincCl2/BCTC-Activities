// Recursion.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include <iostream>
#include <iomanip>
using namespace std;
int L(int n) {

    if (n < 3) {
        return n;
    }
    return L(n - 1) + (2 * L(n - 2));
}
int main()
{
    int N ;
    cout << "Enter your lucky number: ";
    cin >> N;
    cout << "Your lucky number is " << L(N);
}