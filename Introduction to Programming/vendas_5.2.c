#include <stdio.h>
#include <stdlib.h>

int main()
{
    /*Dado um valor de vendas, computar e apresentar:
    a) o lucro líquido;
    b) a comissão; e o
    c) lucro bruto.

    Considerando que:
    a) o valor de vendas será fornecido pelo operador (usuário) e não pode ser inferior a R$ 2.000,00
    b) o valor da comissão corresponde a 10% do valor de vendas acrescido de R$ 100,00;
    c) o valor do lucro bruto corresponde a 80% da diferença entre o valor das vendas e o valor da comissão;
    d) o valor do lucro líquido corresponde a 95% do lucro bruto reduzindo-se deste resultado R$ 75,00

obs.: VERIFICAR cada entrada de dados e finalizar o algoritmo caso tenha algum valor inválido, não processando as próximas entradas e demais cálculos. */

float lliquido=0.0, comissao=0.0, lbruto=0.0, vendas=0.0;

    printf("Informe o valor de vendas: ");
    scanf("%f",&vendas);

    if (vendas<2000) {
        printf("Valor invalido");

    } else {
        comissao= 0.1*vendas + 100;
        lbruto= 0.8*(vendas - comissao);
        lliquido= 0.95*lbruto - 75;

        printf("Lucro liquido: R$%.2f \nComissao: R$%.2f \nLucro bruto: R$%.2f",lliquido,comissao,lbruto);
    }


    return 0;
}
