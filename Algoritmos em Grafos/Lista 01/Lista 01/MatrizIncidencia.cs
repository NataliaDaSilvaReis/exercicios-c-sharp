using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01
{
    internal class MatrizIncidencia
    {
        private int[,] matrizIncidencia;
        private Grafo grafo;
        int quantidadeVertices;
        int quantidadeArestas;



        /// <summary>
        /// Inicializa a matriz de incidência a partir de um grafo.
        /// </summary>
        /// <param name="grafo">Grafo utilizado para gerar a matriz.</param>
        /// <exception cref="ArgumentNullException">Lançada quando o grafo é nulo.</exception>
        public MatrizIncidencia(Grafo grafo)
        {
            if (grafo == null)
            {
                throw new ArgumentNullException("O grafo não pode ser nulo.");
            }

            this.grafo = grafo;
            quantidadeVertices = grafo.Vertices.Count;
            quantidadeArestas = grafo.Arestas.Count;

            matrizIncidencia = new int[quantidadeVertices, quantidadeArestas];

            GerarMatriz();
        }



        /// <summary>
        /// Preenche a matriz de incidência com base nos vértices e arestas do grafo.
        /// </summary>
        private void GerarMatriz()
        {

            for (int i = 0; i < quantidadeVertices; i++)
            {
                for (int j = 0; j < quantidadeArestas; j++)
                {
                    Vertice vertice = grafo.Vertices[i];
                    Aresta aresta = grafo.Arestas[j];

                    if (vertice == aresta.Origem || vertice == aresta.Destino)
                    {
                        matrizIncidencia[i, j] = 1;
                    }
                }
            }
        }



        /// <summary>
        /// Imprime a matriz de incidência no console.
        /// </summary>
        public void Imprimir()
        {
            Console.WriteLine();

            for (int i = 0; i < matrizIncidencia.GetLength(0); i++)
            {
                for (int j = 0; j < matrizIncidencia.GetLength(1); j++)
                {
                    Console.Write(matrizIncidencia[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
