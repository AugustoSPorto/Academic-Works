// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. medio1:

#include <stdio.h>
#include <math.h>

long double tende_pi(int n);

int main() {
    int n=0;
    printf("Informe o valor de n: ");
    scanf("%d", &n);
    printf("%Lf", tende_pi(n));
}

long double tende_pi(int n) {
    long double res=0;
    if (n==0)
        return 4.0;
    else {
        if (n%2==0) {
            res = (long double) 4.0;
            res /= (long double) ((2*n) + 1);
        }
        else  {
            res = (long double) -4.0;
            res /= (long double) ((2*n) + 1);
        }
        res += tende_pi(n-1);
        return res;
    }
}
