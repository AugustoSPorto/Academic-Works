// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. basico4:

#include <stdio.h>

typedef struct Data {
    int dia, mes, ano;
} Data;

int saida(int dia,int mes,int ano); char converte_mes(int num);

int main() {
    Data data;
    printf("Informe a data no estilo DD/MM/AAAA: ");
    scanf("%d/%d/%d", &data.dia, &data.mes, &data.ano);
    saida(data.dia,data.mes,data.ano);
}

char converte_mes(int num) {
    if (num == 1)
        printf("JAN");
    else if (num==2)
        printf("FEV");
    else if (num==3)
        printf("MAR");
    else if (num==4)
        printf("ABR");
    else if (num==5)
        printf("MAI");
    else if (num==6)
        printf("JUN");
    else if (num==7)
        printf("JUL");
    else if (num==8)
        printf("AGO");
    else if (num==9)
        printf("SET");
    else if (num==10)
        printf("OUT");
    else if (num==11)
        printf("NOV");
    else if (num==12)
        printf("DEZ");
    else
        return 0;
}

int saida(int dia,int mes,int ano) {
    printf("%02d.%02d.%04d ", dia, mes, ano);
    printf("%02d-%02d-%04d ", dia, mes, ano);
    printf("%02d/%02d/%02d ", dia, mes, ano%100);
    printf("%02d", dia);
    converte_mes(mes);
    printf("%04d\n", ano);
}