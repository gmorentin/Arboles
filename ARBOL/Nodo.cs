using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARBOL
{
    class Nodo
    {
        public int _dato;
        private int dato { get { return _dato; } set { _dato = value; } }

        public Nodo _hizq;
        private Nodo hizq { get { return _hizq; } set { _hizq = value; } }

        public Nodo _hder;
        private Nodo hder { get { return _hder; } set { _hder  = value; } }

        public Nodo(int dato)
        {
            this.dato = dato;
        }

        public override string ToString()
        {
            return dato.ToString();
        }
    }
}
