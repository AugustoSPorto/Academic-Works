#include <stdio.h>
#include <stdlib.h>

int main()
{
/*  Fazer um  programa em C que imprime uma tabela com a tabuada de 1 a 9. */

int n1=1, n2=1, op=0;

while (n1<=10) {

    if (n2 <= 10) {
        printf(" %d x %d = %d\n",n1,n2,n1*n2);
        n2++;

    }else {
        n2 = 1;
        n1++;
    }
}
    return 0;
}
