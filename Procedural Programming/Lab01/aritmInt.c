/* 
Aluno: Augusto Soares Porto 
Matrícula: 12121ECP016
Data: 03/11/2022
Exerc.1: Peça ao usuário por dois números inteiros. Mostre o resultado da soma (+), subtração
(-), multiplicação (*), divisão (/) e módulo (%) entre eles.
*/

#include <stdio.h>

int main() {
    int num1=0;
    int num2=0;

    printf("Informe os numeros a serem usados: ");
    scanf("%d %d", &num1, &num2); 

    printf("%d+%d = %d, ", num1, num2, (num1+num2));
    printf("%d-%d = %d, ", num1, num2, (num1-num2));
    printf("%d*%d = %d, ", num1, num2, (num1*num2));
    printf("%d/%d = %d, ", num1, num2, (num1/num2));
    printf("%d%%%d = %d\n", num1, num2, (num1%num2));

    return 0;
}