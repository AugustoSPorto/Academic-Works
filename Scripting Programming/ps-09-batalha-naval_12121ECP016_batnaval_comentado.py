# Aluno: Augusto Soares Porto
# Matricula: 12121ECP016

# FUNCAO PRINCIPAL
def main():
    # Recebe a primeira linha a ser implementada na matriz
    inicio = [i for i in input().split()]
    # Cria uma matriz chamada campo usando os inputs
    campo = criar_matriz(inicio)

    # Recebe as coordenadas da entrada e as transforma em listas de inteiros dois a dois
    escolhas = tentativas()
    organizar_coord(escolhas)

    # Laco que e realizado n vezes(numero de tentativas)
    for i in range(len(escolhas)):
        # Determinar os eixos a serem usados na busca (-1 pois as linhas/colunas começam em 0)
        eixo_linha = int(escolhas[i][0]) - 1
        eixo_coluna = int(escolhas[i][1]) - 1

        # Caso a posicao do tabuleiro corresponda a um ponto, imprime agua
        if campo[eixo_linha][eixo_coluna] == '.':
            print('agua')

        # Caso a posicao do tabuleiro nao corresponda a um ponto executa:
        else:
            # Armazena o valor da posicao escolhida para ser printada posteriormente e transforma a letra para minusculo
            navio = campo[eixo_linha][eixo_coluna]
            campo[eixo_linha][eixo_coluna] = navio.lower()

            # Condicao para que imprima atingiu o navio caso uma posicao caso o valor daposicao escolhida seja minusculo (ja tenha sido escolhida anteriormente), transformando em maiusculo antes
            if navio.islower():
                print('atingiu o navio', navio.upper())
            # Condicao para uma posicao escolhida pela primeira vez
            elif navio.isupper():
                # Verifica se ha outra posicao como mesmo valor(letra). Caso tenha, printa que o navio foi atingido e, caso nao tenha, printa que o navio afundou
                if verificador(navio, campo):
                    print('atingiu o navio', navio)
                else:
                    print('afundou o navio', navio)


# FUNCAO SECUNDARIA QUE DEFINE SE UM NAVIO FOI AFUNDADO OU SO ATINGIDO
def verificador(cond, matriz):
    verif = False
    # Se existir mais de uma posicao com a mesma letra, isso significa que o navio ainda nao foi afundado
    for i in range(len(matriz)):
        for j in range(len(matriz)):
            if matriz[i][j] == cond:
                verif = True

    # Se verif = True significa que o navio nao foi afundado ainda, se verif = False significa que o navio foi afundado
    return verif


# FUNCAO SECUNDARIA QUE ORGANIZA AS COORDENADAS COMO DOIS VALORES INTEIROS PARA SEREM USADOS NA BUSCA NA MATRIZ CAMPO
def organizar_coord(lista):
    for i in range(len(lista)):
        # Transforma os digitos de str para int
        lista[i][1] = int(lista[i][1])
        # Transforma letras em numeros
        if lista[i][0] == 'A':
            lista[i][0] = 1
        elif lista[i][0] == 'B':
            lista[i][0] = 2
        elif lista[i][0] == 'C':
            lista[i][0] = 3
        elif lista[i][0] == 'D':
            lista[i][0] = 4
        elif lista[i][0] == 'E':
            lista[i][0] = 5
        elif lista[i][0] == 'F':
            lista[i][0] = 6
        elif lista[i][0] == 'G':
            lista[i][0] = 7
        elif lista[i][0] == 'H':
            lista[i][0] = 8
        elif lista[i][0] == 'I':
            lista[i][0] = 9
        elif lista[i][0] == 'J':
            lista[i][0] = 10


# FUNCAO SECUNDARIA QUE RECEBE E ARMAZENA AS POSICOES ESCOLHIDAS PARA SEREM ATINGIDAS
def tentativas():
    # Recebe numero de tentativas
    num_tentativas = int(input())

    # Armazena coordenadas, separadamente, em uma lista
    lista = []
    for i in range(num_tentativas):
        coord = input().split()
        lista.append(coord)

    return lista


# FUNCAO SECUNDARIA QUE CRIA A MATRIZ QUE SERA USADA COMO TABULEIRO DO JOGO
def criar_matriz(linhan):
    matriz = []
    # Rebe 10 vez pois o tamanho da lista ja e definido
    for i in range(10):
        matriz.append(linhan)
        if i < 9:
            linhan = [i for i in input().split()]
    return matriz


# Chama a funcao main apenas como script
if __name__ == '__main__':
    main()
