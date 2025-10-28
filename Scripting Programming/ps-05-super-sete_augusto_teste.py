def main():
    col1 = int(input())
    col3 = int(input())
    col4 = int(input())
    col6 = int(input())

    apostas(col1, col3, col4, col6)

    for i in range(col1, col3+1):
        col2 = i

        for j in range(col4, col6+1):
            col5 = j

            for k in range(col6, 10):
                col7 = k
                soma = col1+col2+col3+col4+col5+col6+col7

                if soma%7 != 0 and soma%13 != 0:
                    print(f'{col1} - {col2} - {col3} - {col4} - {col5} - {col6} - {col7}')


def apostas(x,y,z,w):
    print("Primeira:", x)
    print("Terceira:", y)
    print("Quarta:", z)
    print("Sexta:", w)
    print("Lista de apostas:")


main()