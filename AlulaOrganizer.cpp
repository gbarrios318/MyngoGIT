#include <iostream>
#include <fstream>
#include <string>

using namespace std; 

/*
This program will run inside the raspberry pi. 

It will read in the .txt file from the Input App, determine important flight data, 
and write this data to be sent to the Output App

The Output App will recognize this information, sort it, and display it on screen
*/

void main()
{
	//1: Read text file from Input App into array
	//2: Sort important info into a 2nd array, keep all information in order for final data dump
	//3: Export 2nd array to Output App in real time 
	
	//1
	string word[20000];
	ifstream fin("algae.txt"); //enter custom text file here
	for (int i = 0; i < 20000; i++)
	{
		if (!fin.fail())
			getline(fin, word[i]);
		else
			fin.close();
	}

	//2
	//identify "important" flight data that must be displayed, fill output array
	string output[200];



	//3
	//create new text file
	ofstream fout("output.txt");
	for (int i = 0; i < 200; i++)
	{
		if (!fout.fail())
			fout << output[i] << endl;
		else
			fout.close();
	}

	//send to Output App

}