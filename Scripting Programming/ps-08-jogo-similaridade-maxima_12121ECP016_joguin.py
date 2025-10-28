# Aluno: Augusto Soares Porto
# Matricula: 12121ECP016

# Funcao principal
def main():
    # Cria duas matrizes, onde os valores no input serao armazenados
    matrizg = []
    matrizp = []
    # Chama a funcao criamatriz() secundaria que efetivamente cria as matrizes que serao analisadas
    matrizg = criamatriz(matrizg)
    matrizp = criamatriz(matrizp)

    # Armazena os valores retornados pela funcao comparar() em uma lista chamada de resposta
    resposta = comparar(matrizg, matrizp)

    # Imprime as resposta presente na lista anterior
    print('Posição:', resposta[0])
    print('Similaridade máxima: {:.2f}%'.format(resposta[1]))


# Funcao secundaria que cria matrizes
def criamatriz(matriz):
    # n determina o tamanho (ixj) de uma matriz
    n = int(input())
    # Recebe os valores e os armazena em lista, que representa uma linha da futura matriz
    linhan = [int(i) for i in input().split()]
    matriz = []

    # Armazena n linhas na matriz
    for i in range(n):
        matriz.append(linhan)
        # Condicao para que a matriz n receba uma linha a mais que o esperado
        if i < n - 1:
            linhan = [int(i) for i in input().split()]

    return matriz


# Funcao secundaria que compara duas matrizes e retorna os valores exigidos pela questao
def comparar(matriz1, matriz2):
    # Estabelece os valores iniciais como nulos, cso nao haja semelhanca entre as matrizes
    maxima = 0
    coord = '(0,0)'

    # Laco que transita a matriz menor (matriz2) na area coberta pela matriz maior (matriz1)
    for i in range(len(matriz1) - len(matriz2) + 1):
        for j in range(len(matriz1[0]) - len(matriz2[0]) + 1):
            # Variavel que armazenara a quantidade de quadrados semelhantes entre as matrizes
            semelhantes = 0

            # Laco que passa por cada quadrado da matriz menor e os compara com os analogos na matriz maior
            for a in range(len(matriz2)):
                for b in range(len(matriz2)):
                    # Para cada valor identico entre as matrizes (0 ou 1), incrementa 1 a variavel semelhantes
                    if matriz2[a][b] == matriz1[i+a][j+b]:
                        semelhantes += 1

            # Armazena a razao entre os quadrados iguais e o total
            razao = semelhantes / len(matriz2)**2

            # Condicional que reescreve os valores de maxima e coord, associados a maior semelhanca
            if razao > maxima:
                maxima = razao
                coord = '({},{})'.format(i, j)

    # Cria uma lista que armazena os valores a serem retornados pela funcao, multiplica-se maxima por 100 para ser usado como porcentagem
    a = [coord, maxima*100]
    return a


# Chama a funcao main() ao final
main()
