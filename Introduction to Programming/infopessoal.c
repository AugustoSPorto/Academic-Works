#include <stdio.h>
#include <stdlib.h>

int main()
{
/*Elabore um algoritmo que solicite ao operador as seguintes informações de uma pessoa: nome, idade, sexo, altura, profissão, rua, bairro, cidade, sigla do estado, CEP.
Mostre no vídeo todos os dados em forma de texto conforme o exemplo abaixo:

                            ==========================================

                            Fulano da Silva, Voce tem 20 anos, sexo masculino

                            com altura de 1.85 mts

                            Sua profissão eh Gerente

                            Mora na Rua: da Saudade, 955

                            Bairro Santa Marta

                            CEP: 38.100-000 - Uberaba (MG)

                            ========================================== */
//Variaveis
char nome[10], sexo[10], rua[10], bairro[10], cidade[10], estado[10], cep[10], profissao[10];
float altura=0.0;
int idade=0, ncasa=0;

//Entrada
printf("Informe qual e seu nome \n");
scanf ("%s", & nome);

printf("Informe qual e sua idade \n");
scanf ("%i", & idade);

printf("Informe qual e seu sexo \n");
scanf ("%s", & sexo);

printf("Informe qual e sua altura \n");
scanf("%f", & altura);

printf("Informe qual e sua profissao \n");
scanf ("%s", & profissao);

printf("Informe qual e sua rua \n");
scanf ("%s", & rua);

printf("Informe qual e o numero de sua casa \n");
scanf("%i", & ncasa);

printf("Informe qual e seu bairro \n");
scanf ("%s", & bairro);

printf("Informe qual e sua cidade \n");
scanf ("%s", & cidade);

printf("Informe qual e seu estado \n");
scanf ("%s", & estado);

printf("Informe qual e seu CEP \n");
scanf ("%s", & cep);

//Saida
printf("========================================== \n");
printf("%s, de %i anos, do sexo %s \n", nome, idade, sexo);
printf("Altura: %.2fm \n", altura);
printf("Profissao: %s \n", profissao);
printf("Endereço: Rua %s, %i, no bairro %s \n", rua, ncasa, bairro);
printf("CEP: %s - %s, %s \n", cep, cidade, estado);
printf("========================================== ");

    return 0;
}
