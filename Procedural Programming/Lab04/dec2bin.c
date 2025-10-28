// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. basico3: Peça ao usuário que entre com um número decimal de no máximo 64 bits (use o modificador unsigned).
// Converta esse número decimal em sua representação binária.

#include <stdio.h>

int saida(int * lista, int ncasas); int deciPraBin(unsigned long long int num,int * bin);

int main(){
    unsigned long long int num;
    int bin[64], ncasas = 0;
    printf("Informe o numero decimal positivo que deseja passar para binario, com 64 bits no maximo:\n");
    scanf("%llu", &num);
    ncasas = deciPraBin(num,bin);
    saida(bin,ncasas);
}

int deciPraBin(unsigned long long int num,int * bin){
    int ncasas = 0;
    for (int i=0; num >=1; i++){
        if (num%2 == 0) 
            bin[i] = 0;
        else
            bin[i] = 1;
        num /= 2;
        ncasas++;
    }
    return ncasas-1;
}

int saida(int * lista, int ncasas) {
    for (int i=ncasas; i >= 0; i--){
        printf("%d", lista[i]);
    }
}

