#Augusto Soares Porto
#12121ECP016

# Entrada
# * Utilizar int() para que o valor lido pelo input() ja seja convertido para um numero inteiro.
total = int(input())

# Processamento
# * Converter o valor total de segundos para dias inteiros ao dividir por 3600*24 (quantidade de segundos em um dia).
# * Obter o resto da divisao anterior para saber quantos segundos nao foram convertidos para dias.
dias = total // (3600*24)
resto1 = total % (3600*24)

# * Converter o valor excedente de segundos em horas ao dividir por 3600 (quantidade de segundos em uma hora).
# * Obter o resto da divisao anterior para saber quantos segundos nao foram convertidos para horas.
horas = resto1 // 3600
resto2 = resto1 % 3600

# * Converter o valor excedente de segundos em minutos ao dividir por 60 (quantidade de segundos em um minuto).
minutos = resto2 // 60

# * Obter o resto da operacao anterior para saber quantos segundos nao foram convertidos para minutos.
segundos = resto2 % 60

# Saida
print('{} dia(s), {} hora(s), {} minuto(s) e {} segundo(s).'.format(dias, horas, minutos, segundos))
