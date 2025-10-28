# Aluno: Augusto Soares Porto
#  Matricula:12121ECP016

# FUNCAO PRINCIPAL
def main():
    # Cria a matriz rede que sera infectada por Fake News
    rede = criar_matriz()

    # Recebe uma lista de dois valores, os divide e, em seguida, armazena seus int em duas variaveis (eixox e eixoy)
    coordenadas = [i for i in input().split()]
    eixox = int(coordenadas[0])
    eixoy = int(coordenadas[1])

    # Condicao para nao infectar posicoes iniciais que tenham valores # e .
    if rede[eixox][eixoy] == '.' or rede[eixox][eixoy] == '#':
        resultado(rede)

    # Condicao para infectar posicoes com valores diferentes de# e . (0-9)
    else:
        infectar(rede, eixox, eixoy)
        resultado(rede)


# FUNCAO QUE CRIA A MATRIZ QUE REPRESENTARA AREA DE EXTENSAO DA INFECCAO
def criar_matriz():
    # Cria matriz vazia e armazena o numero de linhas em n
    matriz = []
    n = int(input())
    # Ja recebe o  input e o converte em uma lista de strings para serem armazenada na matriz
    linhan = list(input())
    # Armazena n inputs dentro da lista matriz
    for i in range(n):
        matriz.append(linhan)
        if i < n - 1:
            linhan = list(input())
    # Retorna a matriz criada
    return matriz


# FUNCAO QUE INFECTA UM USUARIO (COM FAKE NEWS) E ESPALHA DE ACORDO COM SUA INTENSIDADE
def infectar(matriz, x, y):
    # Recebe o valor na posicao escolhida (de 0 a 9) e armaneza em intensidade
    if (int(matriz[x][y]) > -1) and (int(matriz[x][y]) < 10):
        intensidade = int(matriz[x][y])
        # Atribui o valor da posicao infectada para X
        matriz[x][y] = 'X'

        # Laco que parte da posicao escolhida e anda n casas para cima, sendo n o valor de sua intensidade
        for i in range(x - 1, x - intensidade - 1, -1):
            # Condicoes para que o laco continue so ate a primeira linha possivel (linha 0)
            if i >= 0:
                # Condicao para para o laco quando o valor for #
                if matriz[i][y] == '#':
                    break
                # Condicao para so infectar os valores 0-9
                elif matriz[i][y] != '#' and matriz[i][y] != '.' and matriz[i][y] != 'X':
                    infectar(matriz, i, y)
            else:
                break

        # Laco que parte da posicao escolhida e anda n casas para baixo, sendo n o valor de sua intensidade
        for i in range(x + 1, x + intensidade + 1):
            # Condicoes para que o laco continue so ate a ultima linha possivel
            if i < len(matriz):
                # Condicao para para o laco quando o valor for #
                if matriz[i][y] == '#':
                    break
                # Condicao para so infectar os valores 0-9
                elif matriz[i][y] != '#' and matriz[i][y] != '.' and matriz[i][y] != 'X':
                    infectar(matriz, i, y)
            else:
                break

        # Laco que parte da posicao escolhida e anda n casas para sua esquerda, sendo n o valor de sua intensidade
        for i in range(y - 1, y - intensidade - 1, -1):
            # Condicoes para que o laco continue so ate a primeira coluna possivel (linha 0)
            if i >= 0:
                # Condicao para para o laco quando o valor for #
                if matriz[x][i] == '#':
                    break
                # Condicao para so infectar os valores 0-9
                elif matriz[x][i] != '#' and matriz[x][i] != '.' and matriz[x][i] != 'X':
                    infectar(matriz, x, i)
            else:
                break

        # Laco que parte da posicao escolhida e anda n casas para sua direita, sendo n o valor de sua intensidade
        for i in range(y + 1, y + intensidade + 1):
            # Condicoes para que o laco continue so ate a ultima coluna possivel
            if i < len(matriz[0]):
                # Condicao para para o laco quando o valor for #
                if matriz[x][i] == '#':
                    break
                # Condicao para so infectar os valores 0-9
                elif matriz[x][i] != '#' and matriz[x][i] != '.' and matriz[x][i] != 'X':
                    infectar(matriz, x, i)
            else:
                break

    # Retorna a matriz ao final da recursividade
    return matriz


# FUNCAO QUE IMPRIME A MATRIZ FINAL DESEJADA, EM STRING, LINHA POR LINHA
def resultado(matriz):
    # Laco que imprime linha por linha da matriz desejada
    for i in range(len(matriz)):
        # Agrupa os elementos de cada linha em uma unica string e a imprime
        linha = ''.join(matriz[i])
        print(linha)


# Condicao que chama a funcao main() apenas quando o programa for usado como script
if __name__ == '__main__':
    main()
