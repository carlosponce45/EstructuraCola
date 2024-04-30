using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Cola
{
    internal class Nodo
    {
        public int orden;
        public Nodo siguiente;

        public Nodo(int orden)
        {
            this.orden = orden;
            this.siguiente = null;
        }
    }
}
