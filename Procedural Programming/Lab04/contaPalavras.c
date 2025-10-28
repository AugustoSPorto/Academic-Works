// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. dificil1:

#include <stdio.h>
#define N 1024

int numPalav(char * str, int nchar);

int main() {
    int res;
    char inPalavra[N];
    printf("Informe a string:\n");
    res = numPalav(inPalavra, N);
    printf("%d", res);
}

int numPalav(char * str, int nchar) {
    char c;  int i;
    int res=0;
    for(i = 0; i < nchar; i++) {
        c = getchar();
        if(c != '\n') {
            str[i] = c;
            if (i>0) {
                if (((c >= 'a') && (c <= 'z')) || ((c >= 'A') && (c <= 'Z')) || (c >= '0' && c <= '9') || (c == '-')) {
                    if (((str[i-1] < 'a') || (str[i-1] > 'z')) && ((str[i-1] < 'A') || (str[i-1] > 'Z')) && (c < '0' || c > '9') && (c != '-'))
                        res++;
                }
            }
            else {
                if (((c >= 'a') && (c <= 'z')) || ((c >= 'A') && (c <= 'Z')) || (c >= '0' && c <= '9') || (c == '-'))
                    res = 1;
            }
        } else {
            str[i] = '\0';
            break;
        }
    }
    if(i == nchar) {
        str[nchar-1] = '\0';
        while ((c = getchar()) != '\n' && c != EOF);    // limpar buffer teclado

    } 
    return res;
}