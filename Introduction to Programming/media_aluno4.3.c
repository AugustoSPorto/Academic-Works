#include <stdio.h>
#include <stdlib.h>

int main()
{
//Variaveis
float nota1=0.0, nota2=0.0, nota3=0.0;

//Entrada
printf("Informe a primeira nota: ");
scanf("%f",&nota1);

printf("Informe a segunda nota: ");
scanf("%f",&nota2);

printf("Informe a terceira nota: ");
scanf("%f",&nota3);

//Processamento
if (nota1,nota2,nota3<0 || nota1,nota2,nota3>10) {
    printf("Alguma das notas e invalida");

} else {
    printf("A media do aluno e: %.1f", (nota1+nota2+nota3)/3);
}


    return 0;
}
