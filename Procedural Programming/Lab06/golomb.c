// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. dificil1:

#include <stdio.h>
#include <stdlib.h>

int golomb(int n); 
double media(int * vetor, int inicio, int final);

int main() {
    int a=0,b=0, aux=0;
    int * listaGolomb;

    printf("Informe os valores de a e b:\n");
    scanf("%d %d", &a,&b);
    if(b < a) { aux = a; a = b; b = a; }

    listaGolomb = (int *) malloc(sizeof(int)*(b+1));

    for (int i=0; i!=b+1; i++)
        listaGolomb[i] = golomb(i);
    
//    for(int i=0; i!=b+1; i++) {
//        printf("%d ", listaGolomb[i]);
//    }

    printf("O primeiro elemento e: %d\nO ultimo elemento e: %d\n", listaGolomb[a],listaGolomb[b]);
    printf("A media dos valores dos elementos e: %lg", media(listaGolomb, a, b+1));
}

int golomb(int i) {
    if (i==0)
        return 1;
    else {
        return (1 + golomb(i - golomb(golomb(i-1) - 1)));
    }
}


double media(int * vetor, int inicio, int final) {
    double soma = 0;
    for (int i=inicio; i!=final; i++) {
        soma += vetor[i];
    }
    return soma/(final-inicio);
}