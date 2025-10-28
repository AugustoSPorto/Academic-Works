// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. medio2:

#include <stdio.h>
#include <stdlib.h> 

void criarListaAleatoria(int n, int *listaAleat);
double media(int * vetor, int n) ;
int minValor(int * vetor, int n); int maxValor(int * vetor, int n);

int main(void) {
    int n=0;
    int * listaAleat;
    listaAleat = (int *) malloc(sizeof(long long)*n);

    printf("Informe o valor de n:\n");
    scanf("%d", &n);

    criarListaAleatoria(n,listaAleat);
    printf("O valor minimo da lista e: %d\n", minValor(listaAleat,n));
    printf("O valor maximo da lista e: %d\n", maxValor(listaAleat,n));
    printf("A media dos valores da lista e: %lg\n", media(listaAleat,n));
}

void criarListaAleatoria(int n, int *listaAleat) {
    int aleatorio=0;
    srand(n);

    for (int i=0; i!=n; i++) {
        aleatorio = rand() % n;
        listaAleat[i] = aleatorio;
    } 
//    for(int i=0; i!=n; i++) {
//        printf("%d ", listaAleat[i]);
//    }
}

double media(int * vetor, int n) {
    double soma = 0;
    for (int i=0; i!=n; i++) {
        soma += vetor[i];
    }
    return soma/n;
}

int maxValor(int * vetor, int n) {
    int maximo = vetor[0];
    for (int i=0; i!=n; i++) {
        if (maximo < vetor[i])
            maximo = vetor[i];
    }
    return maximo;
}

int minValor(int * vetor, int n) {
    int minimo = vetor[0];
    for (int i=0; i!=n; i++) {
        if (minimo > vetor[i])
            minimo = vetor[i];
    }
    return minimo;
}