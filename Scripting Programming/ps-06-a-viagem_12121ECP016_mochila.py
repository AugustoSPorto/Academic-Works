# Aluno: Augusto Soares Porto
# Matricula: 12121ECP016

# ---------- # ---------- # # ---------- # -------- FUNCAO PRINCIPAL -------- # ---------- # ---------- # ---------- #
def main():
    # * Variavel que armazenara, acumulativamente, o peso total dos itens na mochila:
    pesomochila = 0
    # * Lista que armazenara os valores dos itens escolhidos para serem levados:
    escolhidos = []

# -> ENTRADA
    # Recebe e armazena o numero de possiveis itens a serem armazenados na mochila na variavel num:
    num = int(input())
    # Recebe e armazena o peso maximo suportado pela mochila na variavel capacidade:
    capacidade = int(input())
    # Recebe e armazena o peso individual de cada item na lista pesos:
    pesos = [int(input()) for i in range(num)]
    # Recebe e armazena o valor individual de cada item na lista valores:
    valores = [int(input()) for i in range(num)]

# -> Processamento
    # I. Cria uma nova lista com a razao do valor pelo peso de cada item
    razao = [valores[i] / pesos[i] for i in range(num)]

    # II. Cria um laco que se repete ate que a condicao para o break seja cumprida
    while True:
        # * Variavel que armazenara o indice do item a ser adicionado caso a capacidade da mochila permita:
        maxrazao = 0

        # * Caso a lista esteja vazia, ou seja, quando todos os itens serem excluidos, sai do laco while:
        if razao == []:
            break

        # * Laco que passa por razao em razao da lista, e armazena o indice com a maior
        for i in range(len(razao)):
            if razao[i] > razao[maxrazao]:
                maxrazao = i

            elif razao[maxrazao] == razao[i]:
                if pesos[i] < pesos[maxrazao]:
                    maxrazao = i
                # Quando duas razoes sao iguais, o indice armazenado e o que se refere ao item mais leve

        # * Caso o peso nao execeda a capacidade, o valor do item e adicionado a lista de escolhidos e seu peso e somado
        # ao total da mochila:
        if (pesomochila + pesos[maxrazao]) <= capacidade:
            pesomochila += pesos[maxrazao]
            escolhidos.append(valores[maxrazao])

            excluir(pesos, valores, razao, maxrazao)
            #   Como o item nao com maior razao valor/peso acabou de ser adicionado a mochila, ele e excluido da tabela
            # de possiveis escolhas

        # * Caso o peso execeda a capacidade, o item nao e adicionado a lista de escolhidos:
        elif (pesomochila + pesos[maxrazao]) > capacidade:
            excluir(pesos, valores, razao, maxrazao)
            #   Como o item nao com maior razao valor/peso nao cabe na mochila, ele e excluido da tabela de possiveis
            # escolhas

    # III. Calculo do valor final acumulado de todos os itens na mochila
    # * Variavel acumulativa que armazena o valor total dos itens da mochila
    valorfinal = 0
    # * Laco que passa por cada valor armazenado em escolhidos
    for i in range(len(escolhidos)):
        valorfinal += escolhidos[i]

# -> SAIDA
    # Imprime o valor total dos itens na mochila
    print(valorfinal)
    # Imprime o peso total da mochila
    print(pesomochila)
# ---------- # ---------- # ---------- # ---------- # ---------- # ---------- # ---------- # ---------- # ---------- #


# ---------- # ---------- # ---------- # -------- FUNCAO SECUNDARIA --------- # ---------- # ---------- # ---------- #
#   Exclui o item da tabela de possiveis escolhas ao deletar suas caracteristicas (peso, valor e razao entre essas) das
# listas onde estao inseridas:
def excluir(lista1, lista2, lista3, indice):
    del (lista1[indice])
    del (lista2[indice])
    del (lista3[indice])
# ---------- # ---------- # ---------- # ---------- # ---------- # ---------- # ---------- # ---------- # ---------- #


# Chama a funcao main ao final do codigo:
main()
