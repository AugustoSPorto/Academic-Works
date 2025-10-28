/*Aluno: Augusto Soares Porto
Matrícula: 12121ECP016
Ex.básico 2:
De um determinado intervalo entre a e b (ambos incluídos), imprima todos os números
ímpares dentro desse intervalo. Tenha o cuidado de informar ao usuário que a < b deve
ser verdadeiro. O programa deve imprimir os números separados por vírgulas.
*/

#include <stdio.h>

int imparesEntre();

int main(){
    int menor, maior;
    printf("Informe o valor de a e b, sendo a menor que b:\n");
    scanf("%d %d", &menor, &maior);
    imparesEntre(menor,maior);
    return 0;
}

int imparesEntre(int a, int b){
    int i;
    for(i=a; i<=b; i++) {
        if (i%2 == 1) {
            if ((i != b) && (i != b-1)){
                printf("%d, ", i);
            }
            else {
                printf("%d\n", i);
            }
        }
    }
    return 0;
}


