// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. basico2:

#include <stdio.h>

int fibonacci(int num);

int main(){
    int num=0, res=0;
    printf("Informe o valor de n: ");
    scanf("%d", &num);
    printf("%d", fibonacci(num));
}

int fibonacci(int num) {
    if (num == 0){
        return 0;
    }
    else if (num == 1){
        return 1;
    }
    else {
        return (fibonacci(num-1) + fibonacci(num-2));
    }
}
