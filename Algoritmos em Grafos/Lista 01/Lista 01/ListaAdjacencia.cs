using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01
{
    internal class ListaAdjacencia
    {
        private List<List<Vertice>> listasAdjacencia;
        private Grafo grafo;



        /// <summary>
        /// Inicializa a lista de adjacência a partir de um grafo.
        /// </summary>
        /// <param name="grafo">Grafo utilizado para gerar as listas.</param>
        /// <exception cref="ArgumentNullException">Lançada quando o grafo é nulo.</exception>
        public ListaAdjacencia(Grafo grafo)
        {
            if (grafo == null)
            {
                throw new ArgumentNullException("O grafo não pode ser nulo.");
            }

            this.grafo = grafo;

            listasAdjacencia = new List<List<Vertice>>();
            List<Vertice> vertices = grafo.Vertices;

            foreach (Vertice v in vertices)
            {
                listasAdjacencia.Add(GerarLista(v));
            }
        }



        /// <summary>
        /// Gera a lista de vértices adjacentes a um vértice.
        /// </summary>
        /// <param name="vertice">Vértice de referência.</param>
        /// <returns>Lista de vértices vizinhos.</returns>
        private List<Vertice> GerarLista(Vertice vertice)
        {
            List<Vertice> lista = new List<Vertice>();
            List<Aresta> arestas = grafo.Arestas;

            foreach (Aresta aresta in arestas)
            {
                if (vertice == aresta.Origem)
                {
                    lista.Add(aresta.Destino);
                }
                else if (vertice == aresta.Destino)
                {
                    lista.Add(aresta.Origem);
                }
            }

            return lista;
        }



        /// <summary>
        /// Obtém a vizinhança de um vértice e chama a impressão.
        /// </summary>
        /// <param name="vertice">Identificador do vértice.</param>
        public void Vizinhanca(int vertice)
        {
            List<Vertice> vizinhanca = new List<Vertice>();
            vizinhanca = listasAdjacencia[vertice - 1];

            ImprimirVizinhanca(vertice, vizinhanca);
        }



        /// <summary>
        /// Imprime a lista de adjacência do grafo no console.
        /// </summary>
        public void Imprimir()
        {
            Console.WriteLine();

            for (int i = 0; i < listasAdjacencia.Count; i++)
            {
                Console.Write($"v{i + 1}: ");

                foreach (Vertice v in listasAdjacencia[i])
                {
                    Console.Write(v + " ");
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
