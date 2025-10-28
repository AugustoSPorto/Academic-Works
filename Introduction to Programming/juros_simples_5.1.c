#include <stdio.h>
#include <stdlib.h>

int main()
{
    /* Elaborar um algoritmo que possibilite solicitar ao operador:
    o valor do capital;
    um número (real) que represente a taxa de juros mensal;
    o tempo a ser aplicado em dias.

VERIFICAR cada entrada de dados, e caso tenha alguma inválida, mostrar uma mensagem e finalizar o algoritmo. Só processar os cálculos se todas a entradas forem válidas
Caso todas as entradas sejam válidas, processar e apresentar o valor dos juros simples proporcional a quantidade de dias aplicado*/

float cinicial=0.0, jmensal=0.0, jfinal=0.0;
int tempo=0;

    printf("Informe o valor do capital inicial: ");
    scanf("%f",&cinicial);

    printf("Informe o valor do juros mensal (em porcentagem): ");
    scanf("%f",&jmensal);

    printf("Informe o tempo que sera aplicado, em dias: ");
    scanf("%d",&tempo);

    jfinal = cinicial*(jmensal/100)*(tempo/30);

    if(cinicial<0) {
        printf("Valor de capital inicial invalido");

    } else if (jmensal<0) {
        printf("Valor de juros invalido");

    } else if (tempo<0) {
        printf("Numero de dias invalido");

    } else {
        printf("O valor dos juros, apos %d dias sera de R$%.2f, resultando em um montante de R$%.2f", tempo,jfinal,cinicial+jfinal);
    }

    return 0;
}
