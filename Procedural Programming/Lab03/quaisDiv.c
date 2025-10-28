/*  Nome: Augusto Soares Porto
    Matrícula: 12121ECP016
    Ex.básico: Peça ao usuário a quantidade de elementos do tipo inteiro (N) que deseja trabalhar.
    Depois peça elemento a elemento (ai) quais os números desejados. Na sequência, peça o
    inteiro que será a referência (R) para encontrar no vetor quem é seu divisor. Imprima os
    números informados, mas, logo após um divisor de R, imprima o caractere # */

#include <stdio.h>

int main(void) {
    int n, ref;
    printf("Informe o número de elementos:\n");
    scanf("%d", &n);
    int vetor[n];
    for(int i = 0; i < n; printf("Informe um número:\n"), scanf("%d", &vetor[i]), i++);
    printf("Informe o referencial:\n");
    scanf("%d", &ref);
    
    for (int i = 0; i < n; i++) {
        if (ref%(vetor[i]) == 0) 
            printf("%d# ", vetor[i]);
        else
            printf("%d ", vetor[i]);
    }
}