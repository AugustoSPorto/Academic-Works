# Aluno: Augusto Soares Porto
# Matricula: 12121ECP016

# FUNCAO PRINCIPAL
def main():
    # Receber e armazenar a lista (senha a ser utilizada):
    sequencia = [int(i) for i in input().split()]

    #   >>Variaveis<<
    # * Variavel que sera usada para determinar quantas vezes o while sera executado:
    rotar = 0
    # * Variavel que determinara se a condicao para os prints finais foi cumprida:
    confirm = True

    # --------//--------//--------//--------//------- Inicio do laco --------//--------//--------//--------//------- #
    while rotar <= len(sequencia):
        # Atribui-se o valor de True para confirm toda vez que o laco e executado, para que assim seja redefinido caso a
        # sequencia fique em ordem crescente:
        confirm = True

        #  Dentro de for, a variavel item assumira todas as posicoes da lista, indo do primeiro ao penultimo, gracas a
        # funcao range.
        for item in range(len(sequencia)-1):
            # * Atribui-se a variavel proxitem o valor de item + 1 para representar a posicao a frente na lista:
            proxitem = item + 1
            # * Caso o valor armazenado na posicao "item" seja maior que o valor armazenado na posicao "item + 1",
            # confirm assume o valor de False:
            if sequencia[item] > sequencia[proxitem]:
                confirm = False

        # Condicao para quando a sequencia nao estiver em ordem crescente, ou seja, caso o programa tenha passado pela
        # linha 24 mesmo que uma unica vez:
        if not confirm:
            # * Chama a funcao rotacao, com sequencia como parametro:
            rotacao(sequencia)

        # Incremento de rotar para que o laco nao entre em looping infinito:
        rotar += 1
    # ---------//--------//--------//--------//-------- Fim do laco --------//--------//--------//--------//-------- #

    # Chamar funcao imprimir com confirm como parametro, ou seja, se confirm for True, entra no if, se for False entra
    # no else:
    imprimir(confirm)


# FUNCAO IMPRIMIR
def imprimir(condicao):
    # Imprime caso condicao for True:
    if condicao:
        print('Klift, Kloft, Still, a porta se abriu')
    # Imprime caso condicao for False:
    else:
        print('Senha incorreta')


# FUNCAO ROTACAO
def rotacao(lista):
    # * Adiciona o valor armazenado na primeira posicao ao final da lista:
    lista.append(lista[0])
    # * Deleta a primeira posicao:
    del (lista[0])


# Chamar a funcao main ao final, apos a imprimir ser definida:
main()
