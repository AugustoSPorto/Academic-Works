/*Aluno: Augusto Soares Porto
Matrícula: 12121ECP016
Ex.médio 1:
A partir de um determinado intervalo entre a e b (ambos incluídos), encontre a soma de
todos os números primos dentro desse intervalo. Tenha o cuidado de informar ao usuário
que a < b deve ser verdadeiro.*/

#include <stdio.h>

int primo(int num);
int somaPrimos(int a, int b);

int main() {
    int a, b;
    printf("Informe a e b, referente ao início e fim do intervalo:\n");
    scanf("%d %d", &a, &b);
    somaPrimos(a,b);
    return 0;
}

int primo(int num) {
    int i;
    for (i=2; i<num; i++){
        if (num%i == 0) {
            return 0;
        }
    }
    return 1;
}

int somaPrimos(int a, int b) {
    int i=0, soma=0;
    for (i = a; i <= b; i++){
        if ((i != 1) && primo(i)){
            soma += i;
        }
    }
    printf("%d", soma);
    return 0;
}