# Aluno: Augusto Soares Porto
# Matricula: 12121ECP016

# FUNCAO PRINCIPAL
def main():
    # Entrada e Processamento
    # I.
    # * Recebe e armazena a sequencia da fita de dna, em string
    dna = input()
    # * Recebe a sequencia do primer e armazena a sequencia exceto os caracteres '5' e '3'
    primer = input().strip('53')

    # II.
    # * Cria uma lista com a sequencia primer, de maneira decrescente
    primer_ord = list(primer[::-1])
    # * Cria uma lista que armazenara a nova sequencia, apos o emparelhamento
    ligacao = []

    # III.
    # * Cria laco que realizara o emparelhamento para todos os indices da lista inicial
    for j in range(len(primer)):
        # Chama a funcao secundaria emparelhamento
        emparelhamento(primer_ord, j, ligacao)

    # * Transforma a lista criada em uma string
    ligacao = ''.join(ligacao)

    # Saida
    # * Executa caso a str ligacao nao esteja contida na sequencia de dna
    if ligacao not in dna:
        print('Nenhuma ligacao')

    # * Executa caso a str ligacao esteja contida na sequencia de dna
    if ligacao in dna:
        # Cria lista que armazenara as posicoes em que esta contida
        posicoes = []
        # Chama a funcao secundaria resultado
        resultado(dna, ligacao, posicoes)
        # Imprime o resultado
        for i in range(len(posicoes)):
            print('Ligacao na posicao', posicoes[i])


# FUNCAO QUE REALIZA O EMPARELHAMENTO DA SEQUENCIA DE DNA
def emparelhamento(lista1, i, lista2):
    # Caso a lista inicial tenha 'A', adiciona 'T' na nova lista, e vice versa
    if lista1[i] == 'A':
        lista2.append('T')
    elif lista1[i] == 'T':
        lista2.append('A')

    # Caso a lista inicial tenha 'G', adiciona 'C' na nova lista, e vice versa
    elif lista1[i] == 'G':
        lista2.append('C')
    elif lista1[i] == 'C':
        lista2.append('G')


# FUNCAO SECUNDARIA QUE COMPARA UMA STRING COM OUTRA E ARMAZENA OS LUGARES EM QUE ESSAS SE SOBREPOEM
def resultado(sequencia1, sequencia2, lista):
    # Cria o laco para comparar as duas strings
    for i in range(len(sequencia1) - len(sequencia2)+1):
        # Caso a segunda string esteja contida na primeira, armazena sua posicao (indice)
        if sequencia1[i:(i + len(sequencia2))] == sequencia2:
            lista.append(i)

    return lista


# Chama a funcao main() ao final
main()
