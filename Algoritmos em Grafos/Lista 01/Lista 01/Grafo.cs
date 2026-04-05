using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01
{
    internal class Grafo
    {
        private List<Vertice> vertices;
        private List<Aresta> arestas;

        public Grafo(List<Vertice> vertices, List<Aresta> arestas)
        {
            if (vertices == null || vertices.Count <= 0)
            {
                throw new ArgumentException("A lista de vértices não pode ser nula ou vazia.");
            }
            if (arestas == null || arestas.Count <= 0)
            {
                throw new ArgumentException("A lista de arestas não pode ser nula ou vazia.");
            }

            this.vertices = vertices;
            this.arestas = arestas;
        }

        public List<Vertice> Vertices
        {
            get { return vertices; }
        }

        public List<Aresta> Arestas
        {
            get { return arestas; }
        }

    }
}
