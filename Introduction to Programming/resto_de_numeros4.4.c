#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
   /*Elaborar um programa em C que receba um número inteiro via teclado, verificar se é menor que zero, dar uma mensagem e finalizar o programa, caso contrário, processar e mostrar o valor do resto deste número por 2 e por 3. */
//Variaveis
int num=0,resto1=0,resto2=0;

//Entrada
    printf("Escolha um numero: ");
    scanf("%i",&num);

//Processamento
if (num<0){
    return 0;

} else {
    resto1= num%2;
    resto2= num%3;
    printf("O resto de %i, dividido por 2 e %i \n", num,resto1);
    printf("O resto de %i, dividido por 3 e %i", num,resto2);
}
    return 0;
}
