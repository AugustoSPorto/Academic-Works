#include <stdio.h>
#include <stdlib.h>

int main()
{
/*Solicitar ao operador o sexo, o nome e as notas das provas parciais de um aluno (P1, P2, P3, P4), VERIFICAR durante a entrada, caso tenha alguma inválida, mostrar uma mensagem e finalizar o algoritmo, não processando as demais entradas bem como os demais cálculos e amostragens.
Caso todas as entradas sejam válidas, processar e, considerando a média aritmética:
a) se a média for inferior a 4, apresente como resultado “ALUNO REPROVADO”;

b) se a média for superior ou igual a 6, apresente como resultado “ALUNO APROVADO”;

c) se a média for entre 4 e 5,9, solicite os pontos obtidos na P5 (prova de recuperação), validando-os, reprocesse ((Media Anterior + P5) / 2), processe e mostre:
c.1) se a média for inferior a 4, apresente como resultado “REPROVADO NA P5”;
c.2) se a média for superior ou igual a 6, apresente “APROVADO NA P5”;
c.3) se a média for entre 4 e 5,9, solicite os pontos obtidos na P6 (Prova de Segunda época) reprocesse e mostre:
c.3.1) se a média for inferior a 6, apresente “REPROVADO NA SEG ÉPOCA”;
c.3.2) se a média for superior ou igual a 6, apresente “APROVADO NA SEG ÉPOCA”;

Observações:
A nota não pode ser inferior a zero e não superior a dez.
O sexo deve ser considerado 1. Masculino ou 2. Feminino. */

char nome[100];
float notap1=0.0,notap2=0.0,notap3=0.0,notap4=0.0,notap5=0.0,notap6=0.0,media1=0.0,media2=0.0,media3=0.0;
int sexo=0;

    printf("Informe o nome do aluno: ");
    fflush(stdin);
    gets(nome);

    printf("Selecione o sexo, considerando 1 para Masculino e 2 para Feminino: ");
    scanf("%i",&sexo);

    printf("Informe a nota parcial P1: ");
    scanf("%f",&notap1);

    printf("Informe a nota parcial P2: ");
    scanf("%f",&notap2);

    printf("Informe a nota parcial P3: ");
    scanf("%f",&notap3);

    printf("Informe a nota parcial P4: ");
    scanf("%f",&notap4);

    media1= (notap1+notap2+notap3+notap4) / 4;

    if (sexo!=1 && sexo!=2) {
        printf("SEXO INVALIDO");
        return 0;

    } else if (notap1<0 && notap1>0) {
        printf("VALOR DA P1 INVALIDO");
        return 0;

    } else if (notap2<0 && notap2>0) {
        printf("VALOR DA P2 INVALIDO");
        return 0;

    } else if (notap3<0 && notap3>0) {
        printf("VALOR DA P3 INVALIDO");
        return 0;

    } else if (notap4<0 && notap4>0) {
        printf("VALOR DA P4 INVALIDO");
        return 0;

    } else if (media1<4) {
        printf("ALUNO REPROVADO");
        return 0;

    } else if (media1>6) {
        printf("ALUNO APROVADO");
        return 0;

    } else {
        printf("Informe a nota parcial P5: ");
        scanf("%f",&notap5);
        media2= (notap5 + media1)/2;

        if (notap5<0) {
            printf("VALOR DA P5 INVALIDO");
            return 0;

        } else if (media2<4) {
            printf("REPROVADO NA P5");
            return 0;

        } else if (media2>6) {
            printf("APROVADO NA P5");
            return 0;

        } else {
            printf("Informe a nota parcial P6: ");
            scanf("%f",&notap6);
            media3= (notap6 + media2)/2;

            if (notap6<0) {
                printf("VALOR DA P6 INVALIDO");
                return 0;

            } else if (media3<6) {
                printf("REPROVADO NA SEG EPOCA");
                return 0;

            } else {
                printf("APROVADO NA SEG EPOCA");
            }
        }
    }

    return 0;
}
