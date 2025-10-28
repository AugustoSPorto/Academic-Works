/* 
Aluno: Augusto Soares Porto 
Matrícula: 12121ECP016
Data: 03/11/2022
Exerc.6: A sequência de Fibonacci tem aplicações na análise de mercados financeiros, na ciência da
computação e na teoria dos jogos. Também aparece em configurações biológicas, como,por exemplo , na
disposição dos galhos das árvores ou das folhas em uma haste, no arranjo do cone da alcachofra, do 
abacaxi, ou no desenrolar da samambaia. Os números de Fibonacci são, portanto, os números que compõem
a seguinte sequência (sequência A000045 na OEIS): 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 
377, 610, 987, 1597, 2584, ...
    Peça para o usuário entrar com a posição do máximo termo desejado na sequência e imprima a sequência até a posição informada (para efeitos do algoritmo a seguir, considere
‘1’ a posição do termo ‘0’), terminado com “...”. Mas a tarefa aqui não é fazer usando qualquer 
estratégia, o desafio aqui é converter o algoritmo a seguir em um laço do tipo for com uma única 
instrução printf("%d, ", i;) em seu corpo, ou seja, colocar o algoritmo para funcionar dentro dos 
argumentos do comando for.
*/

#include <stdio.h>

int main() {
    int pos=1, num=0, resposta=0, aux1=0;

    printf("Informe num: ");
    scanf("%d", &num);

    for (int i=1; i<=num; aux1 = resposta + pos, resposta = pos, pos = aux1, i++) {
        printf("%d, ", resposta);      
    }
    printf("...");
}

