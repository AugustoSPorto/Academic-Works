salario_bruto = float(input())

INSS = 0
if salario_bruto <= 1045.0:
    INSS = salario_bruto * 0.075
elif (salario_bruto >= 1045.01) and (salario_bruto <= 2089.6):
    INSS = salario_bruto * 0.09
elif (salario_bruto >= 2089.61) and (salario_bruto <= 3134.4):
    INSS = salario_bruto * 0.12
elif (salario_bruto >= 3134.41) and (salario_bruto <= 6101.06):
    INSS = salario_bruto * 0.14
else:
    INSS = 6101.061 * 0.14

posInss = salario_bruto - INSS

IR = 0
if posInss <= 1903.98:
    IR = 0
elif (posInss >= 1903.99) and (posInss <= 2826.65):
    IR = posInss * 0.075 - 142.8
elif (posInss >= 2826.66) and (posInss <= 3751.05):
    IR = posInss * 0.15 - 354.8
elif (posInss >= 3751.6) and (posInss <= 4664.68):
    IR = posInss * 0.225 - 636.13
else:
    IR = posInss * 0.275 - 869.36

salario_liquido = salario_bruto - INSS -IR

print("Bruto: R$", format(salario_bruto, ".2f").replace(".", ","))
print("INSS: R$", format(INSS, ".2f").replace(".", ","))
print("IR: R$", format(IR, ".2f").replace(".", ","))
print("Liquido: R$", format(salario_liquido, ".2f").replace(".", ","))