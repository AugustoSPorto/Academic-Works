/* 
Aluno: Augusto Soares Porto 
Matrícula: 12121ECP016
Data: 03/11/2022
Exerc.3: Peça um número inteiro para o usuário que seja maior do que 1. Calcule o fatorial desse
número
*/

#include <stdio.h>
#include <stdint.h>

int main() {
    int64_t resultado=1;
    int num=0, i=0;
    
    printf("Informe o num: ");
    scanf("%d", &num);

    for (i=1; i<=num; i++){
        resultado = resultado*i;
    }

    printf("%d! = %li\n", num, resultado);

    return 0;
}