def main():
    torreA = [int(i) for i in input().split()]
    torre0 = [i for i in torreA]
    torreB = []
    torreD = []
    torreC = []
    #torreA,torreB,torreD = hanoi3(torre0,torreA,torreB,torreD)
    torreA,torreB,torreC,torreD = hanoi4(torre0,torreA,torreB,torreC,torreD)
    #print(torreA,torreB,torreC,torreD)

def hanoi3(torre0,torreA,torreB,torreD):
    n = len(torre0)%2
    if n == 0:
        while torreD != torre0:
            if verificar(torre0,torreD):
                torreA,torreB = move1(torreA,torreB)
            if verificar(torre0,torreD):
                torreA,torreD = move2(torreA,torreD)
            if verificar(torre0,torreD):
                torreD,torreB = move3(torreD,torreB)
    else:
        while torreD != torre0:
            if verificar(torre0,torreD):
                torreA,torreD = move2(torreA,torreD)
            if verificar(torre0,torreD):
                torreA,torreB = move1(torreA,torreB)
            if verificar(torre0,torreD):
                torreD,torreB = move3(torreD,torreB)
    return torreA,torreB,torreD

def move1(torreA,torreB):
    if torreB == []:
        print(f"Mover o anel {torreA[-1]} de A para B")
        torreB.append(torreA[-1])
        del(torreA[-1])
        return torreA,torreB
    elif torreA == []:
        print(f"Mover o anel {torreB[-1]} de B para A")
        torreA.append(torreB[-1])
        del(torreB[-1])
        return torreA,torreB
    elif torreB != [] and torreB[-1] > torreA[-1]:
        print(f"Mover o anel {torreA[-1]} de A para B")
        torreB.append(torreA[-1])
        del(torreA[-1])
        return torreA,torreB
    elif torreA != [] and torreA[-1] > torreB[-1]:
        print(f"Mover o anel {torreB[-1]} de B para A")
        torreA.append(torreB[-1])
        del(torreB[-1])
        return torreA,torreB

def move2(torreA,torreD):
    if torreD == []:
        print(f"Mover o anel {torreA[-1]} de A para D")
        torreD.append(torreA[-1])
        del(torreA[-1])
        return torreA,torreD
    elif torreA == []:
        print(f"Mover o anel {torreD[-1]} de D para A")
        torreA.append(torreD[-1])
        del(torreD[-1])
        return torreA,torreD
    elif torreD != [] and torreD[-1] > torreA[-1]:
        print(f"Mover o anel {torreA[-1]} de A para D")
        torreD.append(torreA[-1])
        del(torreA[-1])
        return torreA,torreD
    elif torreA != [] and torreA[-1] > torreD[-1]:
        print(f"Mover o anel {torreD[-1]} de D para A")
        torreA.append(torreD[-1])
        del(torreD[-1])
        return torreA,torreD

def move3(torreB,torreD):
    if torreD == []:
        print(f"Mover o anel {torreB[-1]} de B para D")
        torreD.append(torreB[-1])
        del(torreB[-1])
        return torreB,torreD
    elif torreB == []:
        print(f"Mover o anel {torreD[-1]} de D para B")
        torreB.append(torreD[-1])
        del(torreD[-1])
        return torreB,torreD
    elif torreD != [] and torreD[-1] > torreB[-1]:
        print(f"Mover o anel {torreB[-1]} de B para D")
        torreD.append(torreB[-1])
        del(torreB[-1])
        return torreB,torreD
    elif torreB != [] and torreB[-1] > torreD[-1]:
        print(f"Mover o anel {torreD[-1]} de D para B")
        torreB.append(torreD[-1])
        del(torreD[-1])
        return torreB,torreD

def hanoi4(torre0,torreA,torreB, torreC, torreD):
    torreC.append(torreA[-1])
    del(torreA[-1])
    del(torre0[-1])
    print(f"Mover o anel {torreC[-1]} de A para C")
    torreA,torreB,torreD = hanoi3(torre0,torreA,torreB,torreD)
    print (f"Mover o anel {torreC[-1]} de C para D")
    torreD.append(torreC[-1])
    del(torreC[-1])
    return torreA,torreB,torreC,torreD

def verificar(torre0,torreD):
    if torre0 != torreD:
        return True
    return False

main()