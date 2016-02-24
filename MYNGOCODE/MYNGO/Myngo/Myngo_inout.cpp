#include "library.h"
#include <iostream>
#include <fstream>
using namespace std;



// Adrians magic Code

//
void main()
{	
	
	string cock;
	cout<<"Wtf do you want me to read?"<<endl;

	getline (cin,cock);
	ifstream fin(cock);
	string line;
	for (int j=0; j<12; j++)
	{
	fin>>line;
	cout<<line<<endl;
	}
	
	/*
	User interface so that people can select what text


	What text file you 
	*/
	if (fin.fail())
		cout << "ERROR: Data not collected!\n";
	else if (line != "END")
		cout << line << '\n';
	fin.close();	}
