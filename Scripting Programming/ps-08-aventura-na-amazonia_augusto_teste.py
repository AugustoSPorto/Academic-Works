def main():
    entra = [int(i) for i in input().split()]
    nlinhas = entra[0]
    ncolunas = entra[1]
    mapa = criarMatriz(nlinhas,ncolunas)
    mapa = percurso(mapa)
    saida(mapa)

def criarMatriz(l,c):
    matriz = []
    for i in range(l):
        linha = ["." for i in range(c)]
        matriz.append(linha)
    return matriz

def saida(matriz):
    for i in range(len(matriz)):
        for j in range(len(matriz[0])):
            if j != len(matriz[0])-1:
                print(matriz[i][j], end = " ")
            else:
                print(matriz[i][j])

def percurso(matriz):
    entra = ""
    pos = [int(i) for i in input().split()]
    while True:
        entra = [i for i in input().split()]
        comando = entra[0].upper()
        if comando == "A":
            matriz[pos[0]][pos[1]] = "#"
        if comando  == "S":
            res = sul(matriz,pos,int(entra[1]))
            matriz = res[0]   
            pos = res[1]
        if comando  == "N":
            res = norte(matriz,pos,int(entra[1]))
            matriz = res[0]   
            pos = res[1]
        if comando  == "O":
            res = oeste(matriz,pos,int(entra[1]))
            matriz = res[0]   
            pos = res[1]
        if comando  == "L":
            res = leste(matriz,pos,int(entra[1]))
            matriz = res[0]   
            pos = res[1]
        if comando  == "F":
            if matriz[pos[0]][pos[1]] != "#":
                matriz[pos[0]][pos[1]] = "+"
            break
    return matriz

def sul(matriz,pos,val):
    for i in range(val):
        if matriz[pos[0]][pos[1]] != "#":
            matriz[pos[0]][pos[1]] = "+"
        pos[0] += 1
    #print(pos)
    return [matriz,pos]

def norte(matriz,pos,val):
    for i in range(val):
        if matriz[pos[0]][pos[1]] != "#":
            matriz[pos[0]][pos[1]] = "+"
        pos[0] -= 1
    #print(pos)
    return [matriz,pos]

def oeste(matriz,pos,val):
    for i in range(val):
        if matriz[pos[0]][pos[1]] != "#":
            matriz[pos[0]][pos[1]] = "+"
        pos[1] -= 1
    #print(pos)
    return [matriz,pos]

def leste(matriz,pos,val):
    for i in range(val):
        if matriz[pos[0]][pos[1]] != "#":
            matriz[pos[0]][pos[1]] = "+"
        pos[1] += 1
    #print(pos)
    return [matriz,pos]

main()
