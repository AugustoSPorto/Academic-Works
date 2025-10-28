#include <stdio.h>

int main()
{
 /*
  Fazer programa um linguagem C que receba via teclado dois valores correspondentes a largura (LADO1) e ao comprimento (LADO2) de um quadrado (desprezar valores diferentes).
  Calcule a �rea deste quadrado, sabendo que a formula e: AREA = LARGURA x COMPRIMENTO, ou seja, lado1 x lado2. Mostrar o resultado.
 */

//Variaveis
    float largura, comprimento, area;
    largura = 0.0;
    comprimento = 0.0;
    area = 0.0;

//Entrada
    printf("Qual a largura do retangulo? \n");
    scanf("%f", &largura);

    printf("Qual o comprimrnto do retangulo? \n");
    scanf("%f", &comprimento);

//Processamento
    area = largura * comprimento;

//Saida
    printf("A area total e: %.2f", area);

return 0;
}
