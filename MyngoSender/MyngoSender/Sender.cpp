#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS //To supress warnings about strcat.
#endif

#ifndef WIN32_LEAN_AND_MEAN
#define WIN32_LEAN_AND_MEAN //Needed for WinSock2
#endif

#include <windows.h> 
#include <winsock2.h>
#include <ws2tcpip.h>
#include <iphlpapi.h>
#include <stdio.h>
#include <string>
#include <iostream>
#include <fstream>
#include <sstream>

using namespace std;

#pragma comment(lib, "Ws2_32.lib") 

const int MAX_STR_SIZE = 256; //--Dummy value for now --AB
const int SERVER_PORT = 5150; //--Dummy value for now --AB
const string HOME_ADDRESS = "127.0.0.1"; //--The Home IP. --AB

void main() {
	string fileName;

	/*cout << "Enter name of text file:" << endl;  //prompt the user to input the text file      //AB COMMENT: I've broken this intentionally for testing purposes.
	getline(cin, fileName);*/						//read textFile that user has selected
	ifstream fin;
	fin.open("test.txt");
	fin.seekg(0);
	string textLine = ""; 
	//consider writing to a textfile?
	/*for (int j = 0; j < 10; j++) { //--This is reading and discarding. Reccomenmd making this a loop below the Winsock initialization so that the program can just spit continuously. --AB

		fin >> textLine;
		cout << textLine << endl;
	}*/

	if (fin.fail())
	{
		cout << "ERROR: File not found\n";
		return;
	}

	/*string destAddress;
	cout << "enter destination address: " << endl;  //AB: Useful later but stalls testing.
	getline(cin, destAddress);*/


	WSADATA wsaData; // --This block is Adrian, Winsock

	int iResult; //Used for most of the transmissions

				 // Initialize Winsock
	iResult = WSAStartup(MAKEWORD(2, 2), &wsaData);
	if (iResult != 0) {
		printf("WSAStartup failed: %d\n", iResult);
		return; //Removed the 1 because main VOID -Mikey
	}
	struct addrinfo *result = NULL,
		*ptr = NULL,
		hints;

	string addr = HOME_ADDRESS; //turn the address into character array -AB
	char *argv = new char[addr.length() + 1];
	strcpy(argv, addr.c_str());

	char buf[MAX_STR_SIZE] = "";
	sprintf_s(buf, "%d", SERVER_PORT); //Turn the port into a character array --AB


	ZeroMemory(&hints, sizeof(hints));
	hints.ai_family = AF_UNSPEC;
	hints.ai_socktype = SOCK_STREAM;
	hints.ai_protocol = IPPROTO_TCP;
	iResult = getaddrinfo(argv, buf, &hints, &result); //verify socket --AB
	if (iResult != 0) {
		printf("getaddrinfo failed: %d\n", iResult);
		WSACleanup();
		return;
	}
	SOCKET ConnectSocket = INVALID_SOCKET;
	// Attempt to connect to the first address returned by
	// the call to getaddrinfo
	ptr = result;

	// Create a SOCKET for connecting to server
	ConnectSocket = socket(ptr->ai_family, ptr->ai_socktype,
		ptr->ai_protocol);


	if (ConnectSocket == INVALID_SOCKET) {
		printf("Error at socket(): %ld\n", WSAGetLastError());
		freeaddrinfo(result);
		WSACleanup();
		return;
	}

	// Connect to server.
	iResult = connect(ConnectSocket, ptr->ai_addr, (int)ptr->ai_addrlen);
	if (iResult == SOCKET_ERROR) {
		closesocket(ConnectSocket);
		ConnectSocket = INVALID_SOCKET;
	}

	freeaddrinfo(result);

	if (ConnectSocket == INVALID_SOCKET) {
		printf("Unable to connect to server!\n");
		WSACleanup();
		return;
	}

	// If all went well, this is the main body.
	char sendBuff1[MAX_STR_SIZE];
	cout << "[CLIENT] Socket created, sending file contents." << endl;
	while (!fin.eof()) //This is where you put your work --AB
	{
		//Reccomendation, work with strings and then use strcpy_s to convert the string to char * array.
		fin.read(sendBuff1, MAX_STR_SIZE);
		cout << "[CLIENT] Sending packet..." << endl;
		iResult = send(ConnectSocket, sendBuff1, (int)strlen(sendBuff1), 0); // -- THIS IS THE SEND FUNCTION, contained within commends. When you know what you want to send, replace sendBuff1 with you char *, replace (int)strlen(sendBuff1) with the length of the string (can use the same function in the example.) --AB
		if (iResult == SOCKET_ERROR) {
			printf("send failed: %d\n", WSAGetLastError());
			closesocket(ConnectSocket);
			WSACleanup();
			return;
		}
		
	    cout << sendBuff1 << endl;

		//When you're done, this will close the socket. You can only do this at the end and it will clean everything up for you.--AB 
	}

	iResult = shutdown(ConnectSocket, SD_SEND);
	if (iResult == SOCKET_ERROR) {
		printf("shutdown failed: %d\n", WSAGetLastError());
		closesocket(ConnectSocket);
		WSACleanup();
		return;
	}

	closesocket(ConnectSocket);
	WSACleanup();
	cout << "[SESSION END] Connection with reciever terminated." << endl;
	fin.close();
	return;
}