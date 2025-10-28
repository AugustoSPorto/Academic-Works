// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. basico3:

#include <stdio.h>

typedef struct Medida {
        int metros, centimetros;
    } Medida;

int converte_cm(int cm);

int main() {
    Medida altura;
    printf("Entre com uma altura: ");
    scanf("%d.%d", &altura.metros, &altura.centimetros);
    printf("Altura %dm%02d\n", altura.metros, converte_cm(altura.centimetros));
}

int converte_cm(int cm) {
    if(cm > 99) 
        return converte_cm(cm/10);
    return cm;
}