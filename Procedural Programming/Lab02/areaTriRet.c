/*Aluno: Augusto Soares Porto
Matrícula: 12121ECP016
Ex.básico 3:
Peça ao usuário as coordenadas (x, y) para ambos os pontos A e B, e calcule a área do triângulo 
retângulo onde xC = xB e yC = yA*/
#include <stdio.h>
#include <math.h>

double distE(float x1,float y1, float x2,float y2);
double area(double b, double h);

int main(){
    float xA, xB, xC, yA, yB, yC;
    double base, altura;
    printf("Informe as coordenadas de A e B:\n");
    scanf("%f %f %f %f", &xA, &yA, &xB, &yB);
    xC = xB;
    yC = yA;
    base = distE(xA, yA, xC, yC);
    altura = distE(xB,yB,xC,yC);
    area(base, altura);
}

double distE(float x1,float y1,float x2,float y2) {
    float termo1, termo2;
    double dist;
    dist = sqrt(pow((x1-x2),2)+pow((y1-y2),2));
    return dist;
}

double area(double b, double h) {
    double area;
    area = b*h/2;
    printf("%g\n", area);
}
