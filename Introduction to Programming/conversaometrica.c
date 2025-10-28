#include <stdio.h>
#include <stdlib.h>

int main()
{
/* Fazer um programa em C que pergunta um valor em metros e imprime o correspondente em decímetros, centímetros e milímetros.*/

//Variaveis
float metro=0.0, deci=0.0, centi=0.0, mili=0.0;

//Entrada
    printf("Informe o a valor em metros que deseja converter: ");
    scanf("%f", & metro);

//Processamento
deci = metro * 10;
centi = metro * 100;
mili = metro * 1000;

//Saida
    printf("%fm corresponde a %.2fdm %.2fcm %.2fmm", metro, deci, centi, mili);
    return 0;
}
