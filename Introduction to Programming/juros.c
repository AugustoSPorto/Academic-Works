#include <stdio.h>
#include <stdlib.h>

int main()
{
/* Elabore um algoritmo que receba um valor real, processe e mostre:
O valor inicial;
o valor do juros referente a 12% ao mês;
o valor total reajustado em 12%.*/

//Variaveis
 float valori=0, juros=0, valorf=0;

//Entrada
    printf("Qual o valor de entrada? \n");
    scanf ("%f", & valori);

//Processamento
  juros = valori * 0.12;
  valorf = valori + juros;

//Saída
    printf ("Ao somar o juros de %.2f ao valor inicial de %.2f, conclui-se que o valor final sera de %.2f", juros, valori, valorf);

    return 0;
}
