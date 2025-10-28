/* Nome: Augusto Soares Porto
Matrícula: 12121ECP016
Ex.básico4: Peça ao usuário a quantidade de elementos do tipo ponto flutante (N) que deseja trabalhar. Depois peça elemento a elemento (ai) quais os números desejados. Imprima os
elementos informados separados pelo sinal de multiplicação (∗) seguidos pelo sinal de igual (=) e terminando com o produtório dos elementos.*/

#include <stdio.h>

int main(void) {
    int n;
    printf("Informe o número de elementos e, em seguida, os elementos:\n");
    scanf("%d", &n);
    float vetor[n], res = 1.0;
    for(int i = 0; i < n; scanf("%f", &vetor[i]), i++);
    for(int i=0; i<n; i++) {
        res *= vetor[i];
        if (i < (n-1))
            printf("%g * ", vetor[i]);
        else
            printf("%g = %g", vetor[i],res);
    }
}
