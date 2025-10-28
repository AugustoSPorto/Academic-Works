#include <stdio.h>
#include <stdlib.h>

int main()
{
    /*
    Escreva um programa na linguagem C para calcular o consumo médio de um automóvel (medido em km), dado que são conhecidos a distância percorrida e o volume de combustível consumido para percorrê-la
    (medido em litros).
    */

//Variaveis
    float distancia, volume, taxa_consumo;
    distancia = 0.0;
    volume = 0.0;
    taxa_consumo = 0.0;

//Entrada
    printf("Informe qual a distancia percorrida em kilometros: ");
    scanf("%f", & distancia);

    printf("Informe o volume de combustivel gasto em litros: ");
    scanf("%f", & volume);

//Processamento
    taxa_consumo = distancia / volume;

//Saída
    printf("O consumo médio foi de %.2f Km/L", taxa_consumo);

    return 0;
}
