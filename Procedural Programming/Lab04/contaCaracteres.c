
#include <stdio.h>
#define N 1024

void getstr(char * str, char * res, int nchar);

int main() {
    char inPalavra[N],res[3];
    printf("Informe a string:\n");
    getstr(inPalavra, res, N);
    printf("letras: %d digitos: %d outros: %d",res[0],res[1],res[2]);
}


long long int len(char * str) {
    long long int l = 0;
    while(str[l]) l++;
    return l;
}

void getstr(char * str, char * res, int nchar) {
    char c;  int i;
    int numl=0,numd=0,numo=0;
    for(i = 0; i < nchar; i++) {
        c = getchar();
        if(c != '\n') {
            str[i] = c;
            if (((c >= 'a') && (c <= 'z')) || ((c >= 'A') && (c <= 'Z'))) {
                numl++;
                res[0] = numl;
            }
            else if (c >= '0' && c <= '9') {
                numd++;
                res[1] = numd;
            }
            else {
                numo++;
                res[2] = numo;
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
}