// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. basico4:
#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <math.h>

bool somaVetores(int * v1, int N1, int * v2, int N2, int * resultado); 
void impares(int * sequenciaI, int n); void multiplosDe4(int * sequenciaM4, int n);

int main() {
    int nI=0, nM4=0;
    printf("Informe o numero de elementos impares, comecando em 1:\n");
    scanf("%d%*c", &nI);
    int * sequenciaI;
    sequenciaI = (int *) malloc(sizeof(int)*nI);

    printf("Informe o numero elementos multiplos de 4, comecando em 0:\n");
    scanf("%d%*c", &nM4);
    int * sequenciaM4;
    sequenciaM4 = (int *) malloc(sizeof(int)*nM4);

    int * resultado;
    resultado = (int *) malloc(sizeof(int)*nI);
    if (!somaVetores(sequenciaI, nI, sequenciaM4, nM4, resultado))
        printf("Soma de vetores impossivel, visto que vetores apresentam numeros de elementos diferentes");
}

bool somaVetores(int * v1, int N1, int * v2, int N2, int * resultado) {
    if (N1 != N2)
        return false;
    else
        impares(v1,N1);
        multiplosDe4(v2,N2);
        for (int i=0; i!=N1; i++) {
            resultado[i] = v1[i]+v2[i];
            if (i==N1-1)
                printf("%d", resultado[i]);
            else
                printf("%d, ", resultado[i]);
        }
        return true;
}

void impares(int * sequenciaI, int n) {
    for(int i=0; i!=n; i++) {
        sequenciaI[i]= 1 + 2*i;
        //printf("%d ", sequenciaI[i]);
    }
}

void multiplosDe4(int * sequenciaM4, int n){
    for(int i=0; i!=n; i++) {
        sequenciaM4[i]= 0 + 4*i;
        //printf("%d ", sequenciaM4[i]);
    }
}



