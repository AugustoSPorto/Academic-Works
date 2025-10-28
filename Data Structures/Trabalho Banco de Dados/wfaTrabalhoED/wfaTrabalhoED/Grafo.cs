using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using wfaTrabalhoED;

namespace wfaTrabalhoED
{
    public class Grafo
    {
        //Argumentos
        private List<Aresta> arestas;
        private int tamanho;

        //getters e setters
        internal List<Aresta> Arestas { get => arestas; set => arestas = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }

        //Métodos
        // * construtores
        public Grafo() 
        {
            arestas = null;
            tamanho = 0;
        }
        public Grafo(int vertices)
        {
            arestas = new List<Aresta>();
            tamanho = vertices;
        }

        // * adiciona duas aresta (de ida e volta)
        public void addAresta(int origem, int destino, int distancia)
        {
            Aresta a1 = new Aresta(origem, destino, distancia);
            arestas.Add(a1);
            a1 = new Aresta(destino, origem, distancia);
            arestas.Add(a1);
        }

        // utiliza algoritmo dijkstra para obter o menor caminho entre dois vertices, analisando a distancia de cada vertice a origem
        public List<int> dijkstra(int origem, int destino)
        {
            int[] distancias = new int[tamanho];
            int[] previos = new int[tamanho];
            bool[] visitados = new bool[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                distancias[i] = 9999;
                previos[i] = -1;
                visitados[i] = false;
            }

            distancias[origem] = 0;

            for (int i = 0; i < tamanho - 1; i++)
            {
                int verticeMaisProx = acharVerticeMaisProx(distancias, visitados);
                visitados[verticeMaisProx] = true;

                List<Aresta> arestasVizinhas = acharArestasVizinhas(verticeMaisProx);
                foreach (Aresta a1 in arestasVizinhas)
                {
                    int vizinho = a1.Destino;
                    int distanciaAtual = a1.Distancia;
                    int novaDistancia = distancias[verticeMaisProx] + distanciaAtual;

                    if (!visitados[vizinho] && novaDistancia < distancias[vizinho])
                    {
                        distancias[vizinho] = novaDistancia;
                        previos[vizinho] = verticeMaisProx;
                    }
                }
            }

            return acharMenorCaminho(origem, destino, previos);
        }

        // * analisa vertices vizinhos aos visitados e seleciona aquele com menor distancia
        private int acharVerticeMaisProx(int[] distancias, bool[] visitados)
        {
            int distanciaMin = 9999;
            int verticeMaisProx = -1;

            for (int i = 0; i < distancias.Length; i++)
            {
                if (!visitados[i] && distancias[i] < distanciaMin)
                {
                    distanciaMin = distancias[i];
                    verticeMaisProx = i;
                }
            }

            return verticeMaisProx;
        }

        // * retorna uma lista com arestas, que levam aos vertices vizinhos
        private List<Aresta> acharArestasVizinhas(int vertice)
        {
            List<Aresta> verticesVizinhos = new List<Aresta>();

            foreach (Aresta a1 in arestas)
            {
                if (a1.Origem == vertice)
                {
                    verticesVizinhos.Add(a1);
                }
            }

            return verticesVizinhos;
        }

        // * retorna lista com os valores dos vertices percorridos 
        private List<int> acharMenorCaminho(int origem, int destino, int[] previos)
        {
            List<int> menorCaminho = new List<int>();
            int verticeAtual = destino;

            while (verticeAtual != -1)
            {
                menorCaminho.Insert(0, verticeAtual);
                verticeAtual = previos[verticeAtual];
            }

            return menorCaminho;
        }

        // * retorna o valor da distancia efetiva entre a origem e destino (soma distancias de vertice a vertice no menor caminho)
        public int acharDistancia(int origem, int destino)
        {
            List<int> menorCaminho = dijkstra(origem, destino);

            int dist = 0;
            for (int i = 0; i < menorCaminho.Count - 1; i++)
            {
                int verticeAtual = menorCaminho[i];
                int novoVertice = menorCaminho[i + 1];

                foreach (Aresta a1 in arestas)
                {
                    if (a1.Origem == verticeAtual && a1.Destino == novoVertice)
                    {
                        dist += a1.Distancia;
                        break;
                    }
                }
            }

            return dist;
        }
    }
}

