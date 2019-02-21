// ordonarea crescatoare prin metoda selectiei
// Programul cere nr_max numere, le ordoneaza crescator dupa metoda selectiei, dupa care le afiseaza
#include "stdafx.h"
#include < iostream >
#include < string >

using namespace std;

int main(void)
{
	const int nr_max=5;
	int i,j;
	double n[nr_max+1],temp, sel;
	cout << "\n\tProgramul cere " << nr_max << " numere dupa care le ordoneaza si le afiseaza \n\n";
// introducere numere

	for (i=1;i < nr_max+1;i++){
		cout <<"\tIntroduceti numarul [" << i << "] : ";
		cin >> n[i];
	}
// afisarea numerelor

	cout << "\n\n\tNumerele introduse sunt";
	for (i=1;i < nr_max+1;i++){
		cout << " : " << n[i] ;
	}
// ordonarea crescatoare a numerelor
	i=1;
	j=1;
	sel=n[1];
	while (j < nr_max){
	 for (i=j; i < nr_max; i++) {
		 	if (sel>n[i+1]){
				temp=sel;
				sel=n[i+1];
				n[i+1]=temp;
 			}
 	 }
 	n[j]=sel; 	
	j++	;
	sel=n[j];
	}
// afisarea numerelor ordonate crescator

	cout << "\n\n\tNumerele ordonate sunt";
	for (i=1;i < nr_max+1;i++){
		cout << " : " << n[i] ;
	}
	cin.ignore();
	cin.get();
	return 0;
}