using System;
using System.Collections.Generic;
using System.Text;

namespace AppFacultad
{
    class Empleados:PersonaFacultad
    {
        private int incorporacion;
        private int nrodespacho;

        public Empleados(int incorporacion, int nrodespacho, string nombres, string apellidos, string estado_civil, int nroid) : base(nombres, apellidos, estado_civil, nroid)
        {
            this.incorporacion = incorporacion;
            this.nrodespacho = nrodespacho;
        }

        public int getIncorporacion()
        {
            return incorporacion;
        }

        public void setIncorporacion(int incorporacion)
        {
            this.incorporacion = incorporacion;
        }

        public int getNrodespacho()
        {
            return nrodespacho;
        }

        public void setNrodespacho(int nrodespacho)
        {
            this.nrodespacho = nrodespacho;
        }

        //Metodo para reasignar despacho.
        public void reasignardespacho(int nrodespacho)
        {
            this.nrodespacho = nrodespacho;
        }

        public override void imprimirinformacion()
        {
            Console.WriteLine("<--- EMPLEADO --->");
            base.imprimirinformacion();
            Console.WriteLine("Año de incorporación: " + getIncorporacion() + "\nNúmero de despacho: " + getNrodespacho());
        }

    }
}

