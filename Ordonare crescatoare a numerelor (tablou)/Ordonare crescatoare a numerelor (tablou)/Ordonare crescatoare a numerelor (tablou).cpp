// Ordonare crescatoare a numerelor (tablou).cpp : main project file.

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{ 
	int i,j;
	double n[11],temp;
	cout<<"Programul cere 10 numere si le afiseaza in ordine creascatoare.\n\n";

	//introducere numere
	cout<<"Introduceti numerele:\n";
	for(i=1;i<11;i++)
	{
		cout<<"Numarul["<<i<<"]=";
		cin>>n[i];
	}

	//afisare numere
	cout<<"Numerele introduse sunt";
	for (i=1;i<11;i++)
	{
		cout<<" : "<<n[i];
	}

	//ordonare numere
	j=1;
	while (j<11){
		i=1;
		while (i<11){
			if (n[i]>n[i+1]){
				temp=n[i];
				n[i]=n[i+1];
				n[i+1]=temp;
			}
			i++;
	}
	j++;

	}
// afisarea numerelor ordonate crescator

	cout << "\n\n\tNumerele ordonate sunt: \n\n";
	for (i=1;i<11;i++){
		cout << " : " << n[i] ;
	}
	cin.ignore();
	cin.get();
    return 0;
}
