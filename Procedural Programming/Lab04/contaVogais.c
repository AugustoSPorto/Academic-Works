// Nome: Augusto Soares Porto
// Matricula: 12121ECP016
// Exerc. basico1: Peça ao usuário para digitar uma palavra. Seu programa precisa contar as vogais e apresentá-las ao usuário.
// Para este exercício, ignore outras letras que podem ou não ser consideradas vogais, ou seja, considere apenas “A, E, I, O e U”
// (tanto minúsculas quanto maiúsculas) como vogais.

#include <stdio.h>
#define n 1024

void getstr(char * str, int nchar); long long int nVogais(char * str); long long int len(char * str); void upper(char * str);

int main() {
    char inPalavra[n], res;
    printf("Informe a string:\n");
    getstr(inPalavra, n);
    upper(inPalavra);
    printf("A string fornecida tem %lld vogais", nVogais(inPalavra));
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

long long int len(char * str) {
    long long int l = 0;
    while(str[l]) l++;
    return l;
}

void upper(char * str) {
    long long int l = 0;
    while(str[l]) {
        if(str[l] >= 'a' && str[l] <= 'z')
            str[l] -= 'a' - 'A';
        l++;
    }
}

long long int nVogais(char * str) {
    long long int l = 0, num = 0;
    while(str[l]) {
        if(str[l] == 'A' || str[l] == 'E' || str[l] == 'I' || str[l] == 'O' || str[l] == 'U')
            num += 1;
        l++;
    }
    return num;
}
