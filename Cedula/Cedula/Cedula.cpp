// Cedula.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string.h>
#include <conio.h>
#include <stdio.h>


struct cedula {
    char numero[10];
    char codigoProvincia[2];
};

cedula persona1;

int main() {
    strcpy(persona1.numero, "012345678");

    printf("Numero: %s", persona1.numero);

    return 0;
}

