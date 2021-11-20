using System;
using System.Collections.Generic;
using System.Text;

namespace TadPilaOO
{
    class Nodo
    {
        private int dato;
        private Nodo siguiente = null;
        
       public int Dato { get => dato; set => dato = value; }
       internal Nodo Siguiente { get => siguiente; set => siguiente = value; }

        public override string ToString()
        {
            return string.Format("{0}", dato);
        }
    }
}
