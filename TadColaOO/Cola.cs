using System;
using System.Collections.Generic;
using System.Text;

namespace TadColaOO
{
    class Cola
    {
        private Nodo ancla;
        private Nodo proceso;

        public Cola()
        {
            ancla = new Nodo();
            ancla.Siguiente = null;
        }

        public void Encolar(int Cdato)
        {
            proceso = ancla;
            while (proceso.Siguiente != null)
            {
                proceso = proceso.Siguiente;
            }

            Nodo temp = new Nodo();
            temp.Dato = Cdato;
            temp.Siguiente = null;
            proceso.Siguiente = temp;
        }

        public int Desencolar()
        {
            int valor = 0;
            if (ancla.Siguiente != null)
            {
                proceso = ancla.Siguiente;
                valor = proceso.Dato;
                ancla.Siguiente = proceso.Siguiente;
                proceso.Siguiente = null;
            }
            return valor;
        }


        public int Cabeza()
        {
            int valor = 0;
            if (ancla.Siguiente != null)
            {
                proceso = ancla.Siguiente;
                valor = proceso.Dato;
            }
            return valor;
        }

    }
}
