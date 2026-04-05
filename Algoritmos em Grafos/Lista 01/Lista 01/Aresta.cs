using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01
{
    internal class Aresta
    {
        private Vertice origem;
        private Vertice destino;

        public Aresta(Vertice verticeOrigem, Vertice verticeDestino)
        {
            if (verticeOrigem == null || verticeDestino == null)
            {
                throw new ArgumentNullException("Os vértices da aresta não podem ser nulos.");
            }

            origem = verticeOrigem;
            destino = verticeDestino;
        }

        public Vertice Origem
        {
            get { return origem; }
        }

        public Vertice Destino
        {
            get { return destino; }
        }
    }
}
