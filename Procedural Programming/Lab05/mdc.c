// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. basico1:
#include <stdio.h>

int mdc(int a, int b);

int main(){
    int a=0, b=0;
    printf("Informe os valores de a e b: ");
    scanf("%d %d", &a, &b);
    printf("%d", mdc(a,b));
}

int mdc(int a, int b){
    if (b == 0){
        return a;
    }
    else{
        return mdc(b,a%b);
    }
}
