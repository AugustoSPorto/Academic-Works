// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. medio2:

#include <stdio.h>

typedef struct NumRacionais {
    int num, den;
} NumRacionais;

int saida(int num1, int den1, int num2, int den2); int simplificarRacional(int num, int den);
int mdc(int a, int b); int modulo(int n); int subtracao(int num1, int den1, int num2, int den2);
int adicao(int num1, int den1, int num2, int den2); int divisao(int num1, int den1, int num2, int den2); 
int multiplicacao(int num1, int den1, int num2, int den2);

int main(){
    NumRacionais racional1, racional2;
    printf("Informe o numerador e o denominador de um numero racional:\n");
    scanf("%d %d", &racional1.num, &racional1.den);
    if (racional1.num==0) {
        racional1.den = 1;
    }
    printf("Informe o numerador e o denominador de outro numero racional:\n");
    scanf("%d %d", &racional2.num, &racional2.den);
    if (racional2.num==0) {
        racional2.den = 1;
    }
    saida(racional1.num,racional1.den,racional2.num,racional2.den);
}

int saida(int num1, int den1, int num2, int den2) {
    simplificarRacional(num1,den1);
    simplificarRacional(num2,den2);
    adicao(num1,den1,num2,den2);
    subtracao(num1,den1,num2,den2);
    multiplicacao(num1,den1,num2,den2);
    divisao(num1,den1,num2,den2);
}

int adicao(int num1, int den1, int num2, int den2) {
    int num=0, den=0;
    num = num1*den2 + num2*den1;
    den = den1*den2;
    printf("Adicao: ");
    simplificarRacional(num1,den1);
    printf(" + ");
    simplificarRacional(num2,den2);
    printf(" = ");
    simplificarRacional(num, den);
    printf("\n");
}

int subtracao(int num1, int den1, int num2, int den2) {
    int num=0, den=0;
    num = num1*den2 - num2*den1;
    den = den1*den2;
    printf("Subtracao: ");
    simplificarRacional(num1,den1);
    printf(" - ");
    simplificarRacional(num2,den2);
    printf(" = ");
    simplificarRacional(num, den);
    printf("\n");
}

int multiplicacao(int num1, int den1, int num2, int den2) {
    int num=0, den=0;
    num = num1*num2;
    den = den1*den2;
    printf("Multiplicacao: ");
    simplificarRacional(num1,den1);
    printf(" * ");
    simplificarRacional(num2,den2);
    printf(" = ");
    simplificarRacional(num, den);
    printf("\n");
}

int divisao(int num1, int den1, int num2, int den2) {
    int num=0, den=0;
    num = num1*den2;
    den = den1*num2;
    printf("Divisao: ");
    simplificarRacional(num1,den1);
    printf(" * ");
    simplificarRacional(num2,den2);
    printf(" = ");
    simplificarRacional(num, den);
    printf("\n");
}

int mdc(int a, int b){
    if (b == 0)
        return a;
    else
        return mdc(b,a%b);
}

int modulo(int n) {
    if (n<0) 
        return n*-1;
    return 1;
}

int simplificarRacional(int num, int den) {
    int mdcR = 0;
    mdcR = mdc(num, den);
    //printf("%d\n",mdcR);
    num /= mdcR;
    den /= mdcR;
    if (den<0) {
        den *= -1;
        num *= -1;
    }
    printf("%d/%d", num, den);
}