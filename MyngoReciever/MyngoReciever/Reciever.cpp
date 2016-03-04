#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS 
#endif //This definition will supress any warnings to the compiler from using strcat and related functions for string. --AB

#ifndef WIN32_LEAN_AND_MEAN
#define WIN32_LEAN_AND_MEAN 
#endif //This is required for WINSOCK. Excludes rarely used services from using certain windows libraries (Important since we're using several) --AB


#include <windows.h>
#include <winsock2.h>
#include <ws2tcpip.h>
#include <iphlpapi.h>
#include <stdio.h>
#include <string> //Every library call above these are needed for WINSOCK. I've included the others as a convenience. -AB
#include <iostream>  
#include <fstream>
#include <sstream>

using namespace std;

#pragma comment(lib, "Ws2_32.lib") //Also required for WINSOCK. Don't delete this header. --AB

const int MAX_STR_SIZE = 256; //--Dummy value for now. You will set this tho the number of CHARACTERS you are going to recieve per transmission. This NEEDS to be the same as in the other app. --AB
const int SERVER_PORT = 12; //--Dummy value for now. This is (usually) a default port. --AB
const string SERVER_ADDR = "127.0.0.1"; //--The Home IP. This basically will allow us to simulate both programs on one computer for now by sending transmissions to itself. --AB

void main()
{
	ofstream resultFile;
	resultFile.open("testfilerecv.txt"); //This will be whatever file you want to dump to. Feel free to change it as I'm just giving you a bit more example code. --AB

#define DEFAULT_BUFLEN 512
#define DEFAULT_PORT "5150"

	WSADATA wsaData; //This is essentially test code lifted from the Microsoft API. I don't particularly think this'll be a problem but if nessecary I can rewrite it to be "original" code. --AB
	int iResult;

	SOCKET ListenSocket = INVALID_SOCKET;
	SOCKET ClientSocket = INVALID_SOCKET;

	struct addrinfo *result = NULL;
	struct addrinfo hints;

	int iSendResult;
	char recvbuf[DEFAULT_BUFLEN];
	int recvbuflen = DEFAULT_BUFLEN;

	// Initialize Winsock
	iResult = WSAStartup(MAKEWORD(2, 2), &wsaData);
	if (iResult != 0) {
		printf("WSAStartup failed with error: %d\n", iResult);
		return;
	}

	ZeroMemory(&hints, sizeof(hints));
	hints.ai_family = AF_INET;
	hints.ai_socktype = SOCK_STREAM;
	hints.ai_protocol = IPPROTO_TCP;
	hints.ai_flags = AI_PASSIVE;

	// Resolve the server address and port
	iResult = getaddrinfo(NULL, DEFAULT_PORT, &hints, &result);
	if (iResult != 0) {
		printf("getaddrinfo failed with error: %d\n", iResult);
		WSACleanup();
		return;
	}

	// Create a SOCKET for connecting to server
	ListenSocket = socket(result->ai_family, result->ai_socktype, result->ai_protocol);
	if (ListenSocket == INVALID_SOCKET) {
		printf("socket failed with error: %ld\n", WSAGetLastError());
		freeaddrinfo(result);
		WSACleanup();
		return;
	}

	// Setup the TCP listening socket
	iResult = bind(ListenSocket, result->ai_addr, (int)result->ai_addrlen);
	if (iResult == SOCKET_ERROR) {
		printf("bind failed with error: %d\n", WSAGetLastError());
		freeaddrinfo(result);
		closesocket(ListenSocket);
		WSACleanup();
		return;
	}

	freeaddrinfo(result);

	iResult = listen(ListenSocket, SOMAXCONN);
	if (iResult == SOCKET_ERROR) {
		printf("listen failed with error: %d\n", WSAGetLastError());
		closesocket(ListenSocket);
		WSACleanup();
		return;
	}

	// Accept a client socket
	ClientSocket = accept(ListenSocket, NULL, NULL);
	if (ClientSocket == INVALID_SOCKET) {
		printf("accept failed with error: %d\n", WSAGetLastError());
		closesocket(ListenSocket);
		WSACleanup();
		return;
	}

	// No longer need server socket
	closesocket(ListenSocket);

	// Receive until the peer shuts down the connection
	do {

		iResult = recv(ClientSocket, recvbuf, recvbuflen, 0);
		if (iResult > 0) {
			printf("Bytes received: %d\n", iResult);
			cout << recvbuf << endl;

		}
		else if (iResult == 0)
			printf("Connection closing...\n");
		else {
			printf("recv failed with error: %d\n", WSAGetLastError());
			closesocket(ClientSocket);
			WSACleanup();
			return;
		}

	} while (iResult > 0);
		//int recvbuflen = MAX_STR_SIZE; // This pulls the maximum transmitted string length from the const. --AB

		closesocket(ClientSocket); //This closes the entire socket. You can choose to just close the reciver or the transmitter individually if you like, but this is more general. --AB
		WSACleanup(); //Closes out WINSOCK and frees memory that was being used. --AB
		return; //Exit main. --AB
}