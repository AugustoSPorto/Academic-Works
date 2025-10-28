/* Aluno: Augusto Soares Porto
Matrícula: 12121ECP016
Ex. básico 1:
Peça ao usuário por duas coordenadas (x e y) de dois pontos A e B. Faça uma função que
receba as coordenadas e mostre ao usuário a distância Euclidiana entre eles. Distância
Euclidiana
*/
#include <stdio.h>
#include <math.h>

double distE(float x1,float y1, float x2,float y2);

int main() {
    float xA, xB, yA, yB;
    printf("Informe as coordenadas de A e B:\n");
    scanf("%f %f %f %f", &xA, &yA, &xB, &yB);
    distE(xA,yA,xB,yB);
    return 0;
}

double distE(float x1,float y1,float x2,float y2) {
    float termo1, termo2;
    double dist;
    dist = sqrt(pow((x1-x2),2)+pow((y1-y2),2));
    printf("%g\n", dist);
    return 0;
}