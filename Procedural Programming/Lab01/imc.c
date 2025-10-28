/*
Aluno: Augusto Soares Porto 
Matrícula: 12121ECP016
Data: 03/11/2022
Exerc.4: Pergunte ao usuário qual seu peso em [kg] e qual sua altura em [m]. Calcule o IMC
baseado na fórmula.
*/

#include <stdio.h>

float peso=0.0, altura=0.0, imc=0.0;

int main(){
    printf("Informe o peso: ");
    scanf("%f", &peso);
    printf("Informe a altura: ");
    scanf("%f", &altura);

    imc = peso/(altura*altura);

    if (imc<16) {
        printf("%.2f (Perigo de vida)", imc);
    }
    else if ((imc>=16) && (imc<17)) {
        printf("%.2f (Muito abaixo do peso)", imc);
    }
    else if ((imc>=17) && (imc<18.5)) {
        printf("%.2f (Abaixo do peso)", imc);
    }
    else if ((imc>=18.5) && (imc<25)) {
        printf("%.2f (Peso Normal)", imc);
    }
    else if ((imc>=25) && (imc<30)) {
        printf("%.2f (Acima do peso)", imc);
    }
    else if ((imc>=30) && (imc<35)) {
        printf("%.2f (Obesidade grau I)", imc);
    }
    else if ((imc>=35) && (imc<40)) {
        printf("%.2f (Obesidade grau II)", imc);
    }
    else {
        printf("%.2f (Obesidade grau III)", imc);
    }    
}