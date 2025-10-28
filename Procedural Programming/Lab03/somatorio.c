/* Nome: Augusto Soares Porto
Matrícula: 12121ECP016
Ex.básico3: Peça ao usuário o número de elementos do tipo ponto flutante (N) que deseja trabalhar.
Depois peça elemento a elemento (ai) quais os números desejados. Imprima os elementos
informados separados pelo sinal de soma (+) seguidos pelo sinal de igual (=) e terminando
com o somatório dos elementos.*/

#include <stdio.h>

int main(void) {
    int n;
    printf("Informe o número de elementos e, em seguida, os elementos:\n");
    scanf("%d", &n);
    float vetor[n], soma = 0.0;
    for(int i = 0; i < n; scanf("%f", &vetor[i]), i++);
    for(int i=0; i<n; i++) {
        soma += vetor[i];
        if (i < (n-1))
            printf("%g + ", vetor[i]);
        else
            printf("%g = %g", vetor[i],soma);
    }
}