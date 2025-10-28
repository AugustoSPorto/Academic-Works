/* 
Aluno: Augusto Soares Porto 
Matrícula: 12121ECP016
Data: 03/11/2022
Exerc.2: Peça um número inteiro n para o usuário que seja maior do que 1. Calcule a soma de
Gauss desse número, ou seja, a soma da sequência de números de 1 a n.
*/

#include <stdio.h>

int main() {
    int soma=0, aux=0, num=0, i=0;
    
    printf("Informe o num: ");
    scanf("%d", &num);

    for (i=0; i<=num; i++){
        aux = soma + i;
        soma = aux;
    }

    printf("%d", soma);

    return 0;
}