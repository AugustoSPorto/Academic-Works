/*Nome: Augusto Soares Porto
Matrícula: 12121ECP016
Ex.médio2: O usuário deve entrar com a quantidade de elementos desejados para um vetor e depois
alimentar cada um deles entre inteiros positivos e negativos. Escreva um programa que remova todos 
os números negativos, deixando apenas os positivos e zeros. Imprima o vetor se contiver algum elemento.
Se todos os números forem negativos, avise ao usuário que o vetor está vazio. */

#include <stdio.h>

int main(void) {
    int n, add, i, verif=0;
        printf("Informe o número de elementos e os elementos logo em seguidas:\n");
        scanf("%d", &n);
        int vetor[n];
    for(int i=0; i < n; i++) {
        add = 0;
        scanf("%d", &add);
        if (add>0) 
            printf("%d ", add);
        else
            verif += 1;
    }
    if (verif == n)
        printf("vazio");
}