/*Nome: Augusto Soares Porto
Matrícula: 12121ECP016
Ex.difícil1: */
#include <stdio.h>

float verifMaior(float posIn, float *vetor, int n), verifMenor(float posIn, float *vetor, int n), diferenca(float *vetor, int n), diferenca(float *vetor, int n);

int main(void) {
    int n;
    printf("Informe o numero de elementos e os elementos:\n");
    scanf("%d", &n);
    float vetorA[n];
    for(int i = 0; i < n; scanf("%f", &vetorA[i]), i++);
    diferenca(vetorA,n);
}

float verifMaior(float posIn, float *vetor, int n) {
    double maior = posIn;
    for (int i = 1; i < n; i++) {
        if (vetor[i] > maior)
            maior = vetor[i];
    }
    return maior;
}

float verifMenor(float posIn, float *vetor, int n) {
    float menor = posIn;
    for (int i = 1; i < n; i++) {
        if (vetor[i] < menor)
            menor = vetor[i];
    }
    return menor;
}

float diferenca(float *vetorA, int n) {
    float vetorB[n-1];
    for (int i=0; i<n-1; i++) {
        vetorB[i] = vetorA[i+1] - vetorA[i];
    }
    printf("O vetor B e: ");
    for (int i=0; i <n-1; i++) {
        if (i == n-2)
            printf("%g", vetorB[i]);
        else
            printf("%g, ", vetorB[i]);
    }
    printf("\nO minimo e: %g", verifMenor(vetorB[0], vetorB, n-1));
    printf("\nO maximo e: %g", verifMaior(vetorB[0], vetorB, n-1));
}