#include "TFibonacci.h"
#include <iostream>
#include <string>
#include <stdio.h>
#include <new>


using namespace std;

int TFibonacci::Get() {
	int nextTerm;


	nextTerm = f1 + f2;
	f1 = f2;
	f2 = nextTerm;



	return nextTerm;
}

int TFibonacci::Set(int num) {
	int nextTerm;



	for (size_t i = 0; i < num; i++)
	{
		nextTerm = f1 + f2;
		f1 = f2;
		f2 = nextTerm;
		if (nextTerm > num)
		{
			break;
		}

	}



	if (nextTerm + f1 > num)
	{
		return nextTerm + f1;
	}

}