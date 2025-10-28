#include <stdio.h>
#include <stdlib.h>

int main()
{
/* Fazer um programa em "C" que solicite 2 números e informe:

      a) A soma dos números;

      b) O produto do primeiro número pelo quadrado do segundo;

      c) O quadrado do primeiro número;

      d) A raiz quadrada da soma dos quadrados;
      sqrt (pow(n1,2) + pow(n2,2))

      e) O seno da diferença do primeiro número pelo segundo;

      f) O módulo do primeiro número. */

//Variaveis
float n1=0.0, n2=0.0, opera=0.0, operb=0.0, operc=0.0, operd=0.0, opere=0.0, operf=0.0;

//Entrada
    printf("Escolha um numero: ");
    scanf("%f", & n1);
    printf("Escolha outro numero: ");
    scanf("%f", & n2);

//Processamento
opera= n1 + n2;
operb= n1 * pow(n2,2);
operc= pow(n1,2);
operd= sqrt (pow(n1,2) + pow(n2,2));
opere= sin(n1-n2);

if (n1>0){
operf= n1;

}else {

operf= n1 * (-1);
}


//Saida
printf("A soma dos numeros e %.2f \n", opera);
printf("O produto do primeiro numero pelo quadrado do segundo e %.2f \n", operb);
printf("O quadrado do primeiro numero e %.2f \n", operc);
printf("A raiz quadrada da soma dos quadrados e %.2f \n", operd);
printf("O seno da diferença do primeiro numero pelo segundo e %.2f \n", opere);
printf("O modulo do primeiro numero e %.2f \n", operf);

    return 0;
}
