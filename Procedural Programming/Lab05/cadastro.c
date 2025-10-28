// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. dificil1:

#include <stdio.h>
#include <stdlib.h>

typedef struct Data {
    int dia, mes, ano;
} Data;

typedef struct Altura {
    int metros, centimetros;
} Altura;

typedef struct Peso {
    float kilos;
} Peso;

typedef struct Usuario {
    char nome[13];
    Data data;
    Altura altura;
    Peso peso;
} Usuario;

int converte_cm(int cm); char converte_mes(int num);

int main() {
    int n=0;
    char c;
    printf("Informe o numero de pessoas a serem cadastradas:\n");
    scanf("%d", &n);
    struct Usuario listaU[n];

    for(int i=0; i!=n; i++) {
        Usuario pessoa;

        printf("Informe o nome da pessoa %d:\n", i+1);
        for(int i=0; i!=12; i++) {
            c = getchar();
            pessoa.nome[i] = c;
            pessoa.nome[12] = *"\0";
        }

        printf("Informe a data de cadastro da pessoa %d:\n", i+1);
        scanf("%d/%d/%d", &pessoa.data.dia, &pessoa.data.mes, &pessoa.data.ano);

        printf("Informe a altura da pessoa %d:\n", i+1);
        scanf("%d.%d", &pessoa.altura.metros, &pessoa.altura.centimetros);

        printf("Informe o peso da pessoa %d:\n" ,i+1);
        scanf("%f", &pessoa.peso.kilos);

        listaU[i] = pessoa;
    }

    for(int i=0; i!=n; i++) {
        printf("%s; ", listaU[i].nome);
        printf("%02d/", listaU[i].data.dia);
        converte_mes(listaU[i].data.mes);
        printf("/%04d; ", listaU[i].data.ano);
        printf("%dm%02dcm; ", listaU[i].altura.metros, converte_cm(listaU[i].altura.centimetros));
        printf("%.1fkg\n", listaU[i].peso.kilos);
    }
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

int converte_cm(int cm) {
    if(cm > 99) 
        return converte_cm(cm/10);
    return cm;
}

