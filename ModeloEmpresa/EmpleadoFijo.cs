using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloEmpresa
{
    class EmpleadoFijo : Empleado
    {
        private double sueldo;
        private double complementoanual;
        private int aniosempresa;

        public EmpleadoFijo(double complementoanual, int aniosempresa, string nombres, string apellidos, int edad, string departamento) : base(nombres, apellidos, edad, departamento)
        {
            this.complementoanual = complementoanual;
            this.aniosempresa = aniosempresa;
        }
        public double getsueldo()
        {
            return sueldo;
        }
        public void setsueldo(double sueldo, int aniosempresa, double complementoanual)
        {
            this.sueldo = sueldo;
            this.aniosempresa = aniosempresa;
            this.complementoanual = complementoanual;
            sueldo = sueldo + (aniosempresa * complementoanual);
        }
    }
}
