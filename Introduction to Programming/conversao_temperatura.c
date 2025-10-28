#include <stdio.h>

int main()
{
//Variaveis a serem usadas
    float temp_fahr, temp_celc;
    temp_fahr = 0.0;
    temp_celc = 0.0;

//Entrada de dados
    printf ("Qual a temperatura em Fahrenheit? \n");
    scanf ("%f", & temp_fahr);

//Processamento
    temp_celc = (temp_fahr - 32) * 5/9;

//Saida de dados
    printf ("A temperatura em celcius e %.2f", temp_celc);

return 0;
}
