int saida(int * lista, unsigned long long int num); int deciPraBin(unsigned long long int num,int * bin);

int main(){
    unsigned long long int num;
    int bin[64];
    printf("Informe o numero decimal positivo que deseja passar para binario:\n");
    scanf("%llu", &num);
    deciPraBin(num,bin);
    saida(bin,num);
}

int deciPraBin(unsigned long long int num,int * bin){
    for (int i=0; num >=1; i++){
        if (num%2 == 0) 
            bin[64-i] = 0;
        else
            bin[64-i] = 1;
        num /= 2;
    }
    return * bin;
}

int saida(int * lista, unsigned long long int num) {
    for (int i=0; (i << 1) <= num; i++){
        printf("%d", lista[64-i]);
    }
}