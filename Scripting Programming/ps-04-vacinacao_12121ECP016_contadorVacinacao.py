# Aluno: Augusto Soares Porto
# Matricula: 12121ECP016

# FUNCAO PRINCIPAL
# Corresponde a entrada e processamento.
def main():

    # Variavel que ira receber e armazenar o numero de meses:
    nmeses = int(input())       # N

    # Variaveis que serao usadas nas equacoes para achar a saida final:
    vacinas = 0
    dose1 = 0
    dose2vac = 0        # D2
    dose1espera = 0     # D1A
    dose2atraso = 0     # D2A
    apenas1dose = 0     # D1

    # --------------------------------------- Inicio do laco --------------------------------------- #
    while True:
        # -> Para numero de meses acima de 0, executa:
        if nmeses > 0:
            vacinas = int(input())
            # 1. Condicao que implica que pessoas que nao receberam a primeira dose tenham desvantagem sobre o restante:
            if dose1 == 0 and dose1espera == 0:
                dose1 = dose1 + vacinas

            # 2. Condicao para que as pessoas que receberam a primeira dose no mes anterior tenham vantagem sobre as que
            # nao receberam nenhuma e desvantagem sobre as que estao a espera da segunda dose com atraso:
            elif dose1 != 0 and dose1espera == 0:

                # * O numero de vacinados no mes sempre sera o minimo entre o numero de vacinas e pacienets com a
                # primeira dose. Assim so basta somar a D2, acumulativamente.
                dose2vac = dose2vac + min(vacinas, dose1)

                if vacinas >= dose1:
                    dose1 = vacinas - dose1

                elif vacinas < dose1:
                    dose1espera = dose1 - vacinas

                    dose1 = 0
                # * Obs.: Como os pacientes que tomaram a 1 dose entram na fila de espera, para se descobrir o valor
                # absoluto de pessoas que so tomaram a 1 dose, e necessario criar uma variavel (apenas1dose) que some
                # as duas ao final.

            # 3. Condicao para que as pessoas esperando a segunda dose com atraso tenham prioridade sobre as outras:
            elif dose1espera != 0:

                # * O numero de vacinados no mes sempre sera o minimo entre o numero de vacinas e pacienets na fila
                # de espera para a segunda dose. Assim so basta somar a D2, acumulativamente.
                dose2vac = dose2vac + min(vacinas, dose1espera)

                if vacinas < dose1espera:
                    dose2atraso = dose2atraso + vacinas
                    dose1espera = dose1espera - vacinas

                elif vacinas > dose1espera:
                    dose2atraso = dose2atraso + dose1espera

                    vacinas = vacinas - dose1espera
                    dose1 = dose1 + vacinas

                    dose1espera = 0     # (Todos os pacientes na fila de espera tomaram a segunda dose)

        # -> Para o numero de meses igual a 0, o laco e quebrado:
        elif nmeses == 0:
            break

        # -> Linha necessaria para que o loop nao seja infinito:
        nmeses = nmeses - 1
    # --------------------------------------- Fim do laco --------------------------------------- #

    #  A fim de conseguir o valor final de pessoas que tomaram apenas 1 dose, soma-se o numero de pessoas que receberam
    #  a primeira dose no mes anterior e as pessoas estao na fila de espera pela segunda dose:
    apenas1dose = dose1 + dose1espera

    #  Atribui os valores calculados, para serem printados com a funcao imprimir:
    imprimir(dose2vac, apenas1dose, dose2atraso, dose1espera)


# FUNCAO QUE IMPRIMIRA A SAIDA FINAL
# Corresponde a saida esperada, que sera chamada ao final de "main()".
def imprimir(D2, D1, D1A, D2A):
    print('Pessoas completamente imunizadas:', D2)
    print('Pessoas imunizadas apenas com uma dose:', D1)
    print('Pessoas que tomaram a segunda dose com atraso:', D1A)
    print('Pessoas esperando a segunda dose com atraso:', D2A)


# Por fim, chamar a funcao principal:
main()
