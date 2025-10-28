# Augusto Soares Porto
# 12121ECP016

# ENTRADA E PROCESSAMENTO
# -> Criacao de variaveis
indic = True        # indicador de passagem
command = input()   # variavel que determina qual bloco sera executado dentro do "while".
waterPts = 0.0      # variavel que armazenara os pontos do elemento agua.
earthPts = 0.0      # variavel que armazenara os pontos do elemento terra.
firePts = 0.0       # variavel que armazenara os pontos do elemento fogo.
airPts = 0.0        # variavel que armazenara os pontos do elemento ar.

# -> Executar laco
while indic:
    # * Ao receber o valor W, armazena o numero de pontos do elemento agua.
    if command == 'W':
        p = float(input())
        waterPts = waterPts + p

        # Calculo da desvantagem causada aos pontos de fogo, considerando que esses nao podem ser menores que 0:
        firePts = firePts - (p/2)
        if firePts < 0.0:
            firePts = 0.0

    # * Ao receber o valor E, armazena o numero de pontos do elemento terra.
    elif command == 'E':
        p = float(input())
        earthPts = earthPts + p

        # Calculo da desvantagem causada aos pontos de ar, considerando que esses nao podem ser menores que 0:
        airPts = airPts - (p/2)
        if airPts < 0.0:
            airPts = 0.0

    # * Ao receber o valor F, armazena o numero de pontos do elemento fogo.
    elif command == 'F':
        p = float(input())
        firePts = firePts + p

        # Calculo da desvantagem causada aos pontos de agua, considerando que esses nao podem ser menores que 0:
        waterPts = waterPts - (p/2)
        if waterPts < 0.0:
            waterPts = 0.0

    # * Ao receber o valor A, armazena o numero de pontos do elemento ar.
    elif command == 'A':
        p = float(input())
        airPts = airPts + p

        # Calculo da desvantagem causada aos pontos de terra, considerando que esses nao podem ser menores que 0:
        earthPts = earthPts - (p/2)
        if earthPts < 0.0:
            earthPts = 0.0

    # Ao receber o valor de X, termina o laco.
    elif command == 'X':
        break

    command = input()

# SAIDA
# -> Saida da tabela com a pontuacao final
print('Pontuacao Final')
print('Agua: {:.1f}'.format(waterPts))      # pontuacao do elemento agua.
print('Terra: {:.1f}'.format(earthPts))     # pontuacao do elemento terra.
print('Fogo: {:.1f}'.format(firePts))       # pontuacao do elemento fogo.
print('Ar: {:.1f}'.format(airPts))          # pontuacao do elemento ar.

# -> Condicao para "print()" final
# * Quando um ou mais elementos tiver pontuacao igual a 0:
if (waterPts == 0) or (earthPts == 0) or (firePts == 0) or (airPts == 0):
    print('Realize mais treinamentos.')
# * Quando nenhum elemento tiver pontuacao igual azero igual a 0:
else:
    print('Treinamento realizado com sucesso.')
