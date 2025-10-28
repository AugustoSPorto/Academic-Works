# Classe nó
class no_arvore():
    def __init__(self, valor):
        self.valor = valor
        self.filho_esq = None
        self.filho_dir = None


# Superclasse de arvore ABB
class arvore_ABB():
    def __init__(self):
        self.raiz = None
        
    # Insere nó na árvore
    # * Insere menores à esquerda e maiores a direita
    def inserir_recursivo(self, no, valor):
        if valor < no.valor:
            if no.filho_esq is None:
                no.filho_esq = no_arvore(valor)
            else:
                self.inserir_recursivo(no.filho_esq, valor)
        elif valor > no.valor:
            if no.filho_dir is None:
                no.filho_dir = no_arvore(valor)
            else:
                self.inserir_recursivo(no.filho_dir, valor)
    # * Insere nó 
    def inserir(self, valor):
        #Se a árvore for vazia, insere uma raiz. Senão, insere um ramo
        if self.raiz is None:
            self.raiz = no_arvore(valor)
        else:
            self.inserir_recursivo(self.raiz, valor)    
            
                
    # Imprime a árvore
    # * Printa primeiro o lado esquerdo e depois o direito, se existirem
    def imprimir_recursivo(self, no, prefixo, ultimo_filho):
        if no is None:
            return None
        print(prefixo, end="")
        if ultimo_filho:
            print("^-- ", end="")
            prefixo += "    "
        else:
            print("|-- ", end="")
            prefixo += "|   "
        print(no.valor)
        if no.filho_esq is not None:
            self.imprimir_recursivo(no.filho_esq, prefixo, no.filho_dir == None)
        if no.filho_dir is not None:
            self.imprimir_recursivo(no.filho_dir, prefixo, True)
    # * Imprime árvore a partir da raiz
    def imprimir(self):
        self.imprimir_recursivo(self.raiz, "", True)
           
                
    # Questão 1: Implemente uma função que retorna a altura de uma árvore binária.    
    # * Retorna altura de cada subárvore
    def altura_sub(self, no):
        #Se não houver raiz, a altura é zero
        if no is None:
            return 0
        else:
            #Calcula altura da subárvore à esquersa
            altura_esq = self.altura_sub(no.filho_esq)
            #Calcula a altura da subárvore à direita
            altura_dir = self.altura_sub(no.filho_dir)
            #Retorna a maior das duas alturas + 1 (equivalente a raiz)
            if altura_esq > altura_dir:
                return altura_esq + 1
            else:
                return altura_dir + 1
    # * Retorna a altura total da árvore
    def altura(self):
        return self.altura_sub(self.raiz)
    
    
    # Questão 2: Implemente uma função que retorna a quantidade de nós de uma árvore binária.    
    def qtd_nos_sub(self, no):
        if no is None:
            return 0
        qtd_esq = self.qtd_nos_sub(no.filho_esq)
        qtd_dir = self.qtd_nos_sub(no.filho_dir)
        return qtd_esq + qtd_dir + 1
      
    def qtd_nos(self):
        return self.qtd_nos_sub(self.raiz)
    
       
     # Questão 3:  Escreva uma função que calcula o número de folhas em uma árvore binária dada.    
    def qtd_folhas_sub(self, no):
        if no == None:
            return 0
        if no.filho_esq == None and no.filho_dir == None:
            return 1
        else:
            folhas_esq = folhas_dir = 0
            if no.filho_esq != None:
                folhas_esq = self.qtd_folhas_sub(no.filho_esq)
            if no.filho_dir != None:
                folhas_dir = self.qtd_folhas_sub(no.filho_dir)
            return folhas_esq + folhas_dir
        
    def qtd_folhas(self):
        return self.qtd_folhas_sub(self.raiz)   
    
    
    # Questão 4: Escreva uma função que compara se duas árvores binárias são iguais.
    def igualdade_nos(self, no1, no2):
        if no1 == no2 == None:
            return True
        elif (no1 == None and no2 != None) or (no1 != None and no2 == None):
            return False
        else:
            verif_esq = self.igualdade_nos(no1.filho_esq, no2.filho_esq)
            verif_dir = self.igualdade_nos(no1.filho_dir, no2.filho_dir)
            
            if no1.valor == no2.valor and verif_dir and verif_esq:
                return True
            else:
                return False
            
    def igualdade_arvores(self, outra_arvore):
        return self.igualdade_nos(self.raiz, outra_arvore.raiz)


#Subclasse de arvore ABB balanceada, chamada de AVL
class arvore_AVL(arvore_ABB):
    def __init__(self):
        self.raiz = None
        
    # Override da função inserir
    def inserir(self, valor):
        if self.raiz == None:
            self.raiz = no_arvore(valor)
        else:
            self.inserir_recursivo(self.raiz, valor)
        self.balanceamento()
    
    # Encontra o fator de balanceamento de uma AVL
    def fator_balanceamento_no(self, no):
        if no == None:
            return 0
        altura_esq = self.altura_sub(no.filho_esq)
        altura_dir = self.altura_sub(no.filho_dir)
        return altura_esq - altura_dir
    
    
    # Questão 8: Implemente uma função que calcula o fator de balanceamento da raiz de uma árvore AVL
    def fator_balancemanto_raiz(self):
        return self.fator_balanceamento_no(self.raiz)
    
    
    # Realiza o balanceamento da AVL
    # * Balanceamento local (do ramo)
    def balanceamento_no(self, no):
        if no == None:
            return None
        fator_balanceamento = self.fator_balanceamento_no(no)
        # Caso o nó esteja desbalanceado à esquerda
        if fator_balanceamento > 1:
            if self.fator_balanceamento_no(no.filho_esq) < 0:
                no.filho_esq = self.rotacao_esquerda(no.filho_esq)
            return self.rotacao_direita(no)
        # Caso o nó esteja desbalanceado à direita
        if fator_balanceamento < -1:
            if self.fator_balanceamento_no(no.filho_dir) > 0:
                no.filho_dir = self.rotacao_direita(no.filho_dir)
            return self.rotacao_esquerda(no)
        # Caso o nó esteja balanceado, continua percorrendo a árvore
        no.filho_esq = self.balanceamento_no(no.filho_esq)
        no.filho_dir = self.balanceamento_no(no.filho_dir)
        return no
    # * Balanceamento da arvore inteira
    def balanceamento(self):
        self.raiz = self.balanceamento_no(self.raiz)

    # Rotação para a direita
    def rotacao_direita(self, no):
        novo_pai = no.filho_esq
        no.filho_esq = novo_pai.filho_dir
        novo_pai.filho_dir = no
        return novo_pai

    # Rotação para a esquerda
    def rotacao_esquerda(self, no):
        novo_pai = no.filho_dir
        no.filho_dir = novo_pai.filho_esq
        novo_pai.filho_esq = no
        return novo_pai      
    
     
                
def main():
    # Árvore 1
    valores = [5, 3, 7, 2, 4, 8, 9]
    arv = arvore_ABB()
    for i in valores:
        arv.inserir(i)
    # Árvore 2 
    valores = [5, 3, 7, 2, 4, 15]
    arv2 = arvore_ABB()
    for i in valores:
        arv2.inserir(i)
        
    arv.imprimir()
    
    print("Q1:")
    print(arv.altura())
    print()
    
    print("Q2:")    
    print(arv.qtd_nos())
    print() 
    
    print("Q3:") 
    print(arv.qtd_folhas())        
    print() 

    print("Q4:") 
    print(arv.igualdade_arvores(arv2))  
    print() 

    
    print("Q5:") 
    pre = [0, 2, 6, 8, 3, 9, 13]
    em = [6, 2, 8, 0, 9, 3, 13]
    print(transforma_em_pos(pre, em))
    print()
    
    
    print("Q6:") 
    #Questão 6: Qual é o pior caso para a altura de uma árvore binária de busca (ABB)? 
 # Os piores casos para uma árvore binária de busca e quando os elementos inseridos estão em ordem crescente ou decrescente. Por exemplo:
    valores = [1,2,3,4]
    arv3 = arvore_ABB()
    for i in valores:
        arv3.inserir(i)
    # Árvore 2 
    valores = [4,3,2,1]
    arv4 = arvore_ABB()
    for i in valores:
        arv4.inserir(i)
    arv3.imprimir()
    arv4.imprimir()
    print()
    
    print("Q7:") 
    print(em_ordem_arvore(arv))
    print()

    # Questão 9: Pode acontecer um fator de balanceamento em uma árvore AVL igual à +3? Justique sua resposta.
# Não, visto que o algoritmo transforma a árvore em balanceada assim que a árvore atinge o fator de balanceamento igual à +2 (>1)

    # Questão 10: Mostre a inserção passo-a-passo dos valores <1, 2, 3, 4, 5, 6, 7> em uma árvore AVL
    print("Q10:")
    valores = [1,2,3,4,5,6,7]
    arvAVL = arvore_AVL()
    for i in valores:
        arvAVL.inserir(i)
        arvAVL.imprimir()
    print()
    
    print("Q8:") 
    print(arvAVL.fator_balancemanto_raiz())
    print() 
     
     

# Questão 5: Implemente uma função que recebe os percursos pré-ordem e em-ordem de uma árvore binária T e retorna o percurso pós-ordem de T
def transforma_em_pos(pre_ordem, em_ordem):
    pos_ordem = []
    
    if len(pre_ordem) == 0 or len(pre_ordem) != len(em_ordem):
        return []
    
    raiz = pre_ordem[0]
    for i in range(len(em_ordem)):
        if em_ordem[i] == raiz:
            indice_raiz = i
    
    esquerda_pre = pre_ordem[1:indice_raiz+1]
    esquerda_em = em_ordem[:indice_raiz]
    direita_pre = pre_ordem[indice_raiz+1:]
    direita_em = em_ordem[indice_raiz+1:]

    pos_ordem_esquerda = transforma_em_pos(esquerda_pre, esquerda_em)
    pos_ordem_direita = transforma_em_pos(direita_pre, direita_em)
    
    pos_ordem = pos_ordem_esquerda + pos_ordem_direita + [raiz]
    
    return pos_ordem

# Questão 7: Projete um algoritmo de ordenação que utiliza uma ABB.
def em_ordem_arvore(arvore):
    resultado = []
    percorrer_em_ordem(arvore.raiz, resultado)
    return resultado

def percorrer_em_ordem(no, resultado):
    if no is None:
        return
    percorrer_em_ordem(no.filho_esq, resultado)
    resultado.append(no.valor)
    percorrer_em_ordem(no.filho_dir, resultado)
        
main()