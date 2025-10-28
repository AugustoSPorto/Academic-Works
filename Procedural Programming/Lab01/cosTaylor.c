/* 
Aluno: Augusto Soares Porto 
Matrícula: 12121ECP016
Data: 03/11/2022
Exerc.7: Peça ao usuário os números int n e double x. O último deve ser considerado como um fator 
para π, ou seja, a entrada deve ser considerada como x π. Calcule a série de Taylor truncada para 
cos(x π)
*/

#include <stdio.h>
#include <math.h>
#ifdef M_PI
  #undef M_PI
#endif
#define M_PI 3.141592653589793115997963468544185161590576171875

int fat();
double potencia();

int main(){
    int numn=0;
    double numx=0.0, soma=0.0;

    printf("Informe n: ");
    scanf("%d", &numn);

    printf("Informe x: ");
    scanf("%lf", &numx);

    for (int i=0; i <= numn; i++){
        soma = soma + potencia(-1.0, i) * potencia(numx*M_PI, 2*i) / fat(2*i);
    }
    printf("%.5lf\n", soma);
    
}

int fat(int numn) {
    if (numn==0) {
        return 1; 
    }
    else {
        return numn*(fat(numn-1)); 
    }
}

double potencia(double num, int ind) {
    if (ind == 0) {
        return 1;
    }
    else {
        double numx;
        numx = num;
        for (int j=1; j<ind; j++) {
            num = num * numx;
        }
        return num;
    }
}



