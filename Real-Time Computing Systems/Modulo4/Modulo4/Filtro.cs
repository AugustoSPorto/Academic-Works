using System.Collections.Generic;
using System.Text;
using System;

public class Filtro
{
    public List<string> Variaveis { get; } = new List<string>();
    public List<string> Operadores { get; } = new List<string>();
    public List<double> Valores { get; } = new List<double>();


    public void AdicionarFiltro(string variavel, string operador, double valor)
    {
        Variaveis.Add(variavel);
        Operadores.Add(operador);
        Valores.Add(valor);
    }
    public void AtualizarFiltro(string variavel, string operador, double valor, int indice)
    {
        Variaveis[indice] = variavel;
        Operadores[indice] = operador;
        Valores[indice] = valor;
    }
    public void ExcluirFiltro(int indice)
    {
        Variaveis.RemoveAt(indice);
        Operadores.RemoveAt(indice);
        Valores.RemoveAt(indice);
    }
    public void LimparFiltro()
    {
        Variaveis.Clear();
        Operadores.Clear();
        Valores.Clear();
    }

    //Aplica as regras de filtragem as medidas lidas 
    public string AplicarFiltros(List<string> var, List<double> val)
    {
        StringBuilder eventos = new StringBuilder();

        for (int i = 0; i < Variaveis.Count; i++)
        {
            for (int j = 0; j < val.Count; j++)
            {
                if (var[j] == Variaveis[i])
                {
                    bool resultado = AvaliarCondicao(
                        val[j],
                        Valores[i],
                        Operadores[i]
                    );

                    eventos.AppendLine($"{Variaveis[i]} {Operadores[i]} {Valores[i]} : {resultado}");
                }
            }
        }
        return eventos.ToString();
    }

    //Realiza a comparacao entre os valores, para cada operador
    private bool AvaliarCondicao(double valorRecebido, double valorFiltro, string operador)
    {
        switch (operador)
        {
            case ">": return valorRecebido > valorFiltro;
            case "<": return valorRecebido < valorFiltro;
            case "=": return valorRecebido == valorFiltro;
            case ">=": return valorRecebido >= valorFiltro;
            case "<=": return valorRecebido <= valorFiltro;
            default: throw new ArgumentException("Operador inválido");
        }
    }
}