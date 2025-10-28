/*Nome: Augusto Soares Porto
Matrícula: 12121ECP016
Ex.médio1: Peça ao usuário o número de elementos do tipo ponto flutante (N) que deseja trabalhar.
Depois peça elemento a elemento (ai) quais os números desejados. Calcule e apresente a
média (µ) e o desvio-padrão (σ, assuma a versão com base na população) da coleção de números:*/

#include <stdio.h>
#include <math.h>

float media(int n, float *listaNum), desvP(int n, float *vetor, float media);

int main(void) {
    int n;
    printf("Informe o número de elementos e, em seguida, os elementos:\n");
    scanf("%d", &n);
    float listaNum[n];
    for(int i=0; i<n; scanf("%f", &listaNum[i]), i++);

    printf("Media: %g\n", media(n, listaNum));
    printf("Desvio: %g\n", desvP(n,listaNum,media(n, listaNum)));
}

float media(int n, float *vetor) {
    float res=0.0;
    for (int i=0; i<n; i++) {
        res += vetor[i];
    }
    return (res/n);
}

float desvP(int n, float *vetor, float media) {
    float res=0.0;
    for (int i=0; i<n; i++) {
        res += pow((vetor[i])-media,2);
    }
    res = sqrt(res/n);
    return res;
}