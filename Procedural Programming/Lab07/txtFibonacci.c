//Aluno: Augusto Soares Porto 
//Matrícula: 12121ECP016
//Exerc.1:

#include <stdio.h>

void fibonacci(int num, FILE * arq);

int  main() {
    FILE * arq;
    arq = fopen("sequenciaFib.txt", "w+");

//    if (arq == NULL) {
//        perror("AAAAAAAAAA\n");
//        return 1;
//    }

    int  num=0;
    printf("Informe num: ");
    scanf("%d", &num);
    fibonacci(num, arq);
    fclose(arq);
}

void fibonacci(int num, FILE * arq) {
    unsigned long long int  pos=1, resposta=0, aux1=0;
        for (unsigned long long int  i=1; i<=num; aux1 = resposta + pos, resposta = pos, pos = aux1, i++) {
        //printf("%d\n", resposta);
        fprintf(arq, "%llu\n", resposta);         
    }
}