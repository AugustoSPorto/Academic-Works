/* 
Aluno: Augusto Soares Porto 
Matrícula: 12121ECP016
Data: 03/11/2022
Exerc.5: Dado um inteiro positivo informado pelo usuário, calcule a soma dos divisores positivos σ1(·) desse número:
*/

#include <stdio.h>

int main(){    
    int i=0, num=0, soma=0;

    printf("Informe num: ");
    scanf("%d", &num);

    for (i=1; i<=num; i++) {
        if ((num%i)==0){
            soma = soma + i;
        }
    }  
    printf("%d\n",soma);  
}