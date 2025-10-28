// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. basico2: Peça ao usuário para escrever uma mensagem de uma linha (uma palavra, uma frase, algum texto). Reverta a string e apresente-a 
// com letras maiúsculas.

#include <stdio.h>
#define N 1024

char invertText(char * str); void getstr(char * str, int nchar); void upper(char * str); long long int len(char * str);

int main() {
    char inPalavra[N], res;
    printf("Informe a string:\n");
    getstr(inPalavra, N);
    upper(inPalavra);
    invertText(inPalavra);
}

void getstr(char * str, int nchar) {
    char c;  int i;
    for(i = 0; i < nchar; i++) {
        c = getchar();
        if(c != '\n') {
            str[i] = c;
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

void upper(char * str) {
    long long int l = 0;
    while(str[l]) {
        if(str[l] >= 'a' && str[l] <= 'z')
            str[l] -= 'a' - 'A';
        l++;
    }
}

long long int len(char * str) {
    long long int l = 0;
    while(str[l]) l++;
    return l;
}

char invertText(char * str) {
    long long int l=0, n=len(str);
    while (l <= n) {
        printf("%c", str[n-l]);
        l++;
    }
}
