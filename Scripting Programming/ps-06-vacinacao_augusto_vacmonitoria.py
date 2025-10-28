def main():
    meses = int(input())
    vacinas = [int(input()) for i in range(meses)]
    priDose = []
    totalPri = 0
    totalSeg = 0
    totalDev = 0

    for i in range(meses):
        vacMensal = vacinas[i]
        devolvidas = 0
        pri = 0
        seg = 0

        if i >= 3:
            seg = priDose[i-3]
            totalSeg += seg
            totalPri -= seg
            vacMensal -= seg
            
        
        if meses-i <= 3:
            pri = vacMensal
            totalPri += pri
            priDose.append(vacMensal)

        else:
            if vacMensal <= vacinas[i+3]:
                pri = vacMensal
                totalPri += pri
                priDose.append(vacMensal)
            else:
                pri = vacinas[i+3]
                totalPri += pri
                priDose.append(vacinas[i+3])
                devolvidas = vacMensal - pri
                totalDev += devolvidas
        
        print(f'Mes {i+1}:\nVacinados com a primeira dose: {pri}\nVacinados com a segunda dose: {seg}\nVacinas devolvidas: {devolvidas}')

    print(f'Total:\nVacinados apenas com a primeira dose: {totalPri}\nVacinados com as duas doses: {totalSeg}\nVacinas devolvidas: {totalDev}')

                    
main()