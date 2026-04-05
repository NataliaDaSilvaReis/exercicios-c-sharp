using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01
{
    internal class Vertice
    {
        private int vertice;

        public Vertice(int vertice)
        {
            this.vertice = vertice;
        }

        public override string ToString()
        {
            return $"v{vertice}";
        }
    }
}
