// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. medio1:

#include <stdio.h>
#include <math.h>

int raizes(float a, float b, float c, float * x1, float * x2); 
int saida(float a, float b, float c, float * x1, float * x2);

int main() {
    float x1[1], x2[1], a=0.0,b=0.0,c=0.0;
    printf("Informe os valores de a, b e c, da funcao de 2 grau:\n");
    scanf("%f %f %f%*c", &a, &b, &c);
    //printf("%f %f %f\n", a, b, c);
    x1[0] = 0;
    x2[0] = 0;
    saida(a,b,c,x1,x2);
}

int raizes(float a, float b, float c, float * x1, float * x2) {
    float raiz1,raiz2;
    double delta;
    delta = (b*b) - (4.0*a*c);
    //printf("%lg\n", delta);

    if (a==0.0 || delta<0) {
        return 0;      
    }
    else {
        raiz1 = (-b + (sqrt(delta)))/(2.0*a);
        //printf("%lg\n", raiz1);
        raiz2 = (-b - (sqrt(delta)))/(2.0*a);

        if (raiz1<raiz2) {
            x1[0] = raiz1;
            x2[0] = raiz2;
        }
        else {
            x1[0] = raiz2;
            x2[0] = raiz1;
        }
        
    if (delta==0) {
        return 1;
    }
    else if (delta>0) {
        return 2;
    }
    }
}

int saida(float a, float b, float c, float * x1, float * x2) {
    int res = raizes(a,b,c,x1,x2);
    if (res==0)
        printf("Nao ha raizes reais");
    else if (res==1)
        printf("Numero de raizes: 1\nAs raizes sao: %lg", x1[0]);
    else if (res==2)
        printf("Numero de raizes: 2\nAs raizes sao: %lg e %lg", x1[0], x2[0]);
}