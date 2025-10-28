// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. basico2:

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int mediaImpares(int n, int inicial); double media(long long int * vetor, int n);

int main() {
    int n=0, inicial=0;
    printf("Informe o numero N de inteiros:\n");
    scanf("%d%*c", &n);
    printf("Informe o numero inicial da sequenciaImpares:\n");
    scanf("%d%*c", &inicial);
    if (inicial%2==0)
        inicial++;
    mediaImpares(n,inicial);
}

int mediaImpares(int n, int inicial) {
    long long int * sequenciaImpares;

    sequenciaImpares = (long long int *) malloc(sizeof(long long int)*n);

    for(int i=0; i!=n; i++) {
        sequenciaImpares[i]= inicial + 2*i;
        //printf("%d ", sequenciaImpares[i]);
    }

    printf("Penultimo elemento: %d\n", sequenciaImpares[n-2]);
    printf("Media dos elementos: %lg", media(sequenciaImpares,n));
}

double media(long long int * vetor, int n) {
    long long int soma = 0;
    for (int i=0; i!=n; i++) {
        soma += vetor[i];
    }
    return soma/n;
}