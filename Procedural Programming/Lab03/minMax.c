/*  Nome: Augusto Soares Porto
    Matrícula: 12121ECP016
    Ex.básico1: Peça ao usuário a quantidade de elementos do tipo inteiro (N) que deseja trabalhar.
    Depois peça elemento a elemento (ai) quais os números desejados. Imprima os números
    informados, mas, logo após o menor deles, imprima o caractere < e, logo após o menor
    deles, imprima o caractere > 6 3 1 2 42 25 12*/

#include <stdio.h>

int verifMaior(int posIn, int *vetor, int n), verifMenor(int posIn, int *vetor, int n), saida(int *vetor, int n);

int main(void) {
    int n;
    printf("Informe o número de elementos:\n");
    scanf("%d", &n);
    int vetor[n];
    for(int i = 0; i < n; printf("Informe um número:\n"), scanf("%d", &vetor[i]), i++);
    saida(vetor, n);
}

int verifMaior(int posIn, int *vetor, int n) {
    int maior = posIn;
    for (int i = 0; i < n; i++) {
        if (vetor[i] > maior)
            maior = vetor[i];
    }
    return maior;
}

int verifMenor(int posIn, int *vetor, int n) {
    int menor = posIn;
    for (int i = 0; i < n; i++) {
        if (vetor[i] < menor)
            menor = vetor[i];
    }
    return menor;
}

int saida(int *vetor, int n) {
    int numMaior, numMenor;
    numMaior = verifMaior(vetor[0], vetor, n);
    numMenor = verifMenor(vetor[0], vetor, n);

    for (int i = 0; i < n; i++) {
        if (vetor[i] == numMaior)
            printf("%d> ", vetor[i]);
        else if (vetor[i] == numMenor)
            printf("%d< ", numMenor);
        else
            printf("%d ", vetor[i]);
    }
}