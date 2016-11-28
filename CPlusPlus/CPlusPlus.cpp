// CPlusPlus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
using namespace std;


int main()
{
	//The statement declares numbers as a vector of 10 ints. 
	std::vector<int> data(10);

	for (int i = 0; i < 10; i++) {
		data[i] = i;
	}

	// Add two more integers to vector
	data.push_back(25);
	data.push_back(13);

	for (int n : data)
		std::cout << n << '\n';

	return 0;
}

