// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. medio1: Palíndromo, do grego palin (novo) e dromo (percurso), é toda palavra ou frase que pode ser lida de trás
// pra frente e que, independente da direção, mantém o seu sentido. Peça ao usuário para escrever uma mensagem de uma linha
// (uma palavra, uma frase, algum texto). Verifique se a mensagem é um palíndromo.

#include <stdio.h>
#define N 1024

int palind(char * str); void getstrMod(char * str, int nchar); void upper(char * str); long long int len(char * str);

int main() {
    char inPalavra[N], res;
    printf("Informe a string:\n");
    getstrMod(inPalavra, N);
    upper(inPalavra);
    //printf("%s\n", inPalavra);
    //printf("%d\n", len(inPalavra));

    if (palind(inPalavra)) {
        printf("Palindromo: Verdadeiro");
    }
    else {
        printf("Palindromo: Falso");
    }
}

void getstrMod(char * str, int nchar) {
    char c;  int i;
    for(i = 0; i < nchar; i++) {
        c = getchar();
        if(c != '\n' && ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))) {
            str[i] = c;
        } 
        else if(c == '\n') {
           str[i] = '\0';
           break;
        }
        else {
            i--;
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
        if (str[l] >= 'a' && str[l] <= 'z') 
            str[l] -= 'a' - 'A';
        l++;
    }
}

long long int len(char * str) {
    long long int l = 0;
    while(str[l]) l++;
    return l;
}

int palind(char * str) {
    int l = 0, n = len(str)-1;
    for (int i=0; i<=n; i++) {
        if (str[i] == str[n-i]) {
            l++;
        }
    }
    if (l == n+1)
        return 1;
    else 
        return 0;
}
