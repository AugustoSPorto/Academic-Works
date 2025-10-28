/*Aluno: Augusto Soares Porto
Matrícula: 12121ECP016
Ex.básico 4:
Dado um número inteiro positivo pelo usuário, mostre todos os divisores positivos desse
número.*/

#include <stdio.h>

int main() {
    int num, i;
    printf("Informe o numero:\n");
    scanf("%d", &num);

    for(i = 1; i <= num; i++) {
        if (num%i == 0) {
            if (num == i) {
                printf("e %d", i);
            }
            else {
                printf("%d, ", i);
            }
        }
    }
}