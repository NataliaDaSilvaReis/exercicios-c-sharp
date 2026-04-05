using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01
{
    internal class MatrizAdjacencia
    {
        private int[,] matrizAdjacencia;
        private Grafo grafo;
        int quantidadeVertices;



        /// <summary>
        /// Inicializa a matriz de adjacência a partir de um grafo.
        /// </summary>
        /// <param name="grafo">Grafo utilizado para gerar a matriz.</param>
        /// <exception cref="ArgumentNullException">Lançada quando o grafo é nulo.</exception>
        public MatrizAdjacencia(Grafo grafo)
        {

            if (grafo == null)
            {
                throw new ArgumentNullException("O grafo não pode ser nulo.");
            }

            this.grafo = grafo;
            quantidadeVertices = grafo.Vertices.Count;

            matrizAdjacencia = new int[quantidadeVertices, quantidadeVertices];

            GerarMatriz();
        }



        /// <summary>
        /// Preenche a matriz de adjacência com base nas arestas do grafo.
        /// </summary>
        private void GerarMatriz()
        {
            for (int i = 0; i < quantidadeVertices; i++)
            {
                for (int j = 0; j < quantidadeVertices; j++)
                {
                    Vertice verticeOrigem = grafo.Vertices[i];
                    Vertice verticeDestino = grafo.Vertices[j];

                    foreach (Aresta aresta in grafo.Arestas)
                    {

                        if ((verticeOrigem == aresta.Origem && verticeDestino == aresta.Destino) ||
                            (verticeOrigem == aresta.Destino && verticeDestino == aresta.Origem))
                        {
                            matrizAdjacencia[i, j] = 1;
                        }
                    }
                }
            }
        }



        /// <summary>
        /// Obtém a vizinhança de um vértice a partir da matriz de adjacência e chama sua impressão.
        /// </summary>
        /// <param name="vertice">Identificador do vértice.</param>
        public void Vizinhanca(int vertice)
        {
            List<Vertice> vizinhanca = new List<Vertice>();

            for (int i = 0; i < quantidadeVertices; i++)
            {
                if (matrizAdjacencia[(vertice - 1), i] == 1)
                {
                    vizinhanca.Add(grafo.Vertices[i]);
                }
            }

            ImprimirVizinhanca(vertice, vizinhanca);
        }



        /// <summary>
        /// Imprime a matriz de adjacência no console.
        /// </summary>
        public void Imprimir()
        {
            Console.WriteLine();

            for (int i = 0; i < matrizAdjacencia.GetLength(0); i++)
            {
                for (int j = 0; j < matrizAdjacencia.GetLength(1); j++)
                {
                    Console.Write(matrizAdjacencia[i, j] + " ");
                }
                Console.WriteLine();
            }
        }



        /// <summary>
        /// Imprime a vizinhança de um vértice no console.
        /// </summary>
        /// <param name="vertice">Identificador do vértice.</param>
        /// <param name="vizinhanca">Lista de vértices vizinhos.</param>
        public void ImprimirVizinhanca(int vertice, List<Vertice> vizinhanca)
        {
            Console.WriteLine();
            Console.Write($"Vizinhança (v{vertice}) = ");

            foreach (Vertice vizinho in vizinhanca)
            {
                Console.Write($"{vizinho.ToString()}, ");
            }
        }
    }
}
