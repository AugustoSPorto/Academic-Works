// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. basico4: Peça ao usuário que entre com um número binário (sequência de 0’s e 1’s) de no máximo 64 bits; 
// ignore qualquer outro caractere e mais de 64 caracteres válidos (0 ou 1). Converta esse número binário em sua representação decimal.

#include <stdio.h>

unsigned long long int binPraDeci(int * lista, int ncasas);

int main() {
    char c;
    int numBin[64], ncasas=0;
    printf("Informe um numero binario de 64 bits no maximo, para passar para decimal:\n");

    for (int i=0; ncasas<65; i++) {
        c = getchar();
        if (c == 48) {
            numBin[i] = 0;
            ncasas++; 
        }
        else if (c == 49) {
            numBin[i] = 1;
            ncasas++; 
        }
        else if (c == '\n') {
            break;
        }
        else {
            i--;
        }
    }
    binPraDeci(numBin, ncasas);
}

unsigned long long int binPraDeci(int * lista, int ncasas) {
    unsigned long long int soma=0;
    int i =0;
    for(int i=0; i<ncasas; i++) {
        if (lista[i] == 1)
            soma += (1 << (ncasas-i-1));
    }
    printf("%llu", soma);
}

