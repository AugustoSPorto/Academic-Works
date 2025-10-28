def main():
    plataforma = [int(i) for i in input().split()]
    i = int(input())
    n = len(plataforma)
    lPlat =[]

    while True:
        if i in lPlat:
            print("loop")
            break
        else:
            print(i)
            lPlat.append(i)
            i = pula(plataforma[i-1], i)
            if i > n:
                print("direita")
                break
            if i < 1:
                print("esquerda")
                break

            

def pula(move, posIn):
    if move >= 0:
        posFi = posIn + mod(move)
    else:
        posFi = posIn - mod(move)
    return posFi

def mod(n):
    if n < 0:
        return n*-1
    else:
        return n


main()
