#include <stdio.h>
#include <stdlib.h>

int main()
{
    /* Escreva um programa na linguagem C que receba via teclado quatro números inteiros, calcule a média entre eles e mostre o resultado no final. */

 //Variaveis
 int n1, n2, n3, n4, media;
 n1 = 0;
 n2 = 0;
 n3 = 0;
 n4 = 0;
 media = 0;

 //Entrada
 printf("Escolha um numero inteiro: ");
scanf("%d", & n1);

 printf("Escolha um segundo numero inteiro: ");
 scanf("%d", & n2);

 printf("Escolha um terceiro numero inteiro: ");
 scanf("%d", & n3);

 printf("Escolha um quarto numero inteiro: ");
 scanf("%d", & n4);

 //Processamneto
 media = (n1 + n2 + n3 + n4) / 4;

 //Saída
 printf("A media dos 4 numeros inteiros e: %d", media);

    return 0;
}
