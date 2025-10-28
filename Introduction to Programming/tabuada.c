#include <stdio.h>
#include <stdlib.h>

int main()
{
  /* Elabore um algoritmo que leia (receba) um número inteiro positivo (desprezar qualquer tipo de verificação/validação).
Calcule e mostre no vídeo a tabuada de multiplicação de 1 a 10 deste número com o respectivo resultado.*/

//Variaveis
int nentry = 0, n1=0, n2=0, n3=0, n4=0, n5=0, n6=0, n7=0, n8=0, n9=0, n10=0;

//Entrada
    printf("Qual o numero que deseja ver a tabuada? \n");
    scanf ("%i", & nentry);

//Processamento
n1 = nentry * 1;
n2 = nentry * 2;
n3 = nentry * 3;
n4 = nentry * 4;
n5 = nentry * 5;
n6 = nentry * 6;
n7 = nentry * 7;
n8 = nentry * 8;
n9 = nentry * 9;
n10 = nentry * 10;

//Saída
    printf("A tabuada de %i e: %i, %i, %i, %i, %i, %i, %i, %i, %i, %i", nentry, n1, n2, n3, n4, n5, n6, n7, n7, n8, n9, n10);

    return 0;
}
