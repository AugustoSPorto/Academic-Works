def main():
    hpryu = int(input())
    hpken = int(input())
    atkryu = 0
    atkken = 0

    while True:
        if hpken > 0 or hpryu > 0:
            atk = int(input())
        if atk > 0:
            hpken = hpken - atk
            print("RYU APLICOU UM GOLPE:", atk)
            if hpken < 0:
                hpken = 0
            print("HP RYU =", hpryu)
            print("HP KEN =", hpken)
            atkryu += 1
        if atk < 0:
            hpryu = hpryu + atk
            print("KEN APLICOU UM GOLPE:", atk*(-1))
            if hpryu < 0:
                hpryu = 0
            print("HP RYU =", hpryu)
            print("HP KEN =", hpken)
            atkken += 1
        if hpken == 0 or hpryu == 0:
            break

    if hpken == 0:
        print("LUTADOR VENCEDOR: RYU")
    else:
        print("LUTADOR VENCEDOR: KEN")

    print("GOLPES RYU =", atkryu)
    print("GOLPES KEN =", atkken)

main()
