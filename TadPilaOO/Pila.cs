using System;
using System.Collections.Generic;
using System.Text;

namespace TadPilaOO
{
    class Pila
    {
        private Nodo ancla;
        private Nodo proceso;

        public Pila()
        {
            ancla = new Nodo();
            ancla.Siguiente = null;
        }

        public void Apilar(int Pdato)
        {
            Nodo temp = new Nodo();
            temp.Dato = Pdato;
            temp.Siguiente = ancla.Siguiente;
            ancla.Siguiente = temp;
        }

        public int Desapilar()
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

        public int Cima()
        {
            int valor = 0;
            if (ancla.Siguiente != null){
                proceso = ancla.Siguiente;
                valor = proceso.Dato;
            }
            return valor;
        }
    }
}
