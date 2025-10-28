/*Aluno: Augusto Soares Porto
Matrícula: 12121ECP016
Ex.difícil 1:.
*/

#include <stdio.h>
#include <math.h>

int verificarFeliz(int num), primar(int num), confereFeliz(double num), saida (int val);
double quantDigi(double num), somaQuadrados(double digitos, double num);

int main() {
    double i, digitos, num, res = 0;
    int numi, saida=0, j;
    printf("Informe o numero:\n");
    scanf("%d", &numi);
    num =  numi*1.0;
    //printf("%d %lf", numi,num);

    digitos = quantDigi(num);
    //printf("%lf\n", digitos);
    //printf("%lf\n", somaQuadrados(digitos,num));
    //printf("%d\n", confereFeliz(7));

    for (j=numi; j>1; j--) {
        if (primar(j) && confereFeliz(j)) {
            printf("%d", j);
            saida = 1;
            break;
        }
    }
    if (saida == 0)
        printf("0***");
}

double quantDigi(double num) {
    double i=0, soma=0;
    for (i=0; num>= 1; i++) {
        num = num/10;
        soma += 1;
    }
    return soma;
}

double somaQuadrados(double digitos, double num) {
    double soma = 0, val = 0, i;
    for (i = digitos-1; i >= 0; i--) {
        val = trunc(num/(pow(10,i)));
        soma += (pow(val,2));
        num -= val*(pow(10,i));
    }
    return soma;
}

int confereFeliz(double num) {
    double i;
    for (i=num; num != 0 || num!=4; i) {
        i = somaQuadrados(quantDigi(i),i);
        if (i == 1)
            return 1;
        else if (i == 4)
            return 0;
    }
}


int primar(int num) {
    int i;
    for (i=2; i<num; i++) {
        if (num%i == 0) {
            return 0;
        }
    }
    return 1;
}