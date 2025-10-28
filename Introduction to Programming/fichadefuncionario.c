#include <stdio.h>
#include <stdlib.h>

int main()
{
/* Receber os seguintes dados de um funcionário: nome, idade, cargo e o seu salário bruto. Considere:
o salário bruto teve um reajuste de 20%;
o salário bruto total (salário bruto + 20%) é descontado 15% para se obter o salário líquido.
Elabore um algoritmo que solicite os dados do funcionário processe e mostre no vídeo:

o nome, a idade e o cargo;
o salário bruto total;
o salário líquido. */

//Variaveis
char nome[10], cargo[10];
int idade=0;
float salariot=0.0, salariob=0.0, salariol=0.0;

//Entrada
    printf ("Informe o nome do funcionario \n");
    scanf ("%s", & nome);

    printf ("Informe a idade do funcionario \n");
    scanf ("%i", & idade);

    printf ("Informe o cargo do funcionario \n");
    scanf ("%s", & cargo);

    printf ("Informe o salario bruto antes do reajuste \n");
    scanf ("%f", & salariob);

//Processamento
salariot = salariob * 1.2;
salariol = salariot * 0.85;

//Saida
    printf("%s, de %i anos \n", nome, idade);
    printf("Cargo: %s \n", cargo);
    printf("Salario bruto reajustado: %.2f \n", salariot);
    printf("Salario liquido reajustado: %.2f \n", salariol);

    return 0;
}
