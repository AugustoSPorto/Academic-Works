/*Aluno: Augusto Soares Porto
Matrícula: 12121ECP016
Ex.médio 2:
Peça ao usuário um número inteiro positivo inicial. Considere a sequência de Hailstone.
A sequência deve ser interrompida quando atingir o valor 1. Calcule a soma de todos os números da 
sequência.*/

#include <stdio.h>

int main(){
    int xn, xo, soma;
    printf("Informe o Xo:\n");
    scanf("%d", &xo);
    soma = xo;
    for (xn = xo; xn != 1; xn = xn) {
        if (xn%2 == 0) {
            xn = xn/2;
        }
        else {
            xn = xn*3+1;
        }
        soma += xn;    
    }
    printf("%d", soma);
}