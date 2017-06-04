using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARBOL
{
    class Arbol
    {
        private Nodo raiz;

        public void Agregar(Nodo nuevo)
        {
            if (raiz == null)
                raiz = nuevo;
            else
                Agregar(nuevo, raiz);
        }

        private void Agregar(Nodo n, Nodo r)
        {
            if (n._dato < r._dato)
                if (r._hizq == null)
                    r._hizq = n;
                else Agregar(n, r._hizq);
            else
                 if (r._hder == null)
                     r._hder = n;
                 else Agregar(n, r._hder);
        }

        public string InOrden()
        {
            if (raiz == null)
                return "Vacio";
            else
                return InOrden(raiz);
        }

        private string InOrden(Nodo r)
        {
            string res = "";
            if (r._hizq != null)
                res += InOrden(r._hizq);
            res += r.ToString();
            if (r._hder != null)
                res += InOrden(r._hder);
            return res;
        }

        public string PreOrden()
        {
            if (raiz == null)
                return "Vacio";
            else
                return PreOrden(raiz);
        }

        private string PreOrden(Nodo r)
        {
            string res = "";
            res += r.ToString();
            if (r._hizq != null)
                res += PreOrden(r._hizq);
            if (r._hder != null)
                res += PreOrden(r._hder);
            return res;
        }

        public string PostOrden()
        {
            if (raiz == null)
                return "Vacio";
            else
                return PostOrden(raiz);
        }

        private string PostOrden(Nodo r)
        {
            string res = "";
            if (r._hizq != null)
                res += PostOrden(r._hizq);
            if (r._hder != null)
                res += PostOrden(r._hder);
            res += r.ToString();
            return res;
        }

        public Nodo Buscar(int numero)
        {
            if (raiz._dato==numero)
                return raiz;
            else
                return Buscar(numero, raiz);
        }

        private Nodo Buscar(int numero, Nodo r)
        {
            Nodo temp;
            if (numero < r._dato)
                if (r._hizq._dato == numero)
                    temp = r._hizq;
                else temp = Buscar(numero, r._hizq);
            else
                 if (r._hder._dato == numero)
                temp = r._hder;
            else temp=Buscar(numero, r._hder);
            return temp;
        }
    }
}
