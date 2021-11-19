using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloEmpresa
{
    class EmpleadoTemporal : Empleado
    {
        private DateTime fechaingreso;
        private DateTime fechasalida;
        private double sueldo;

        public EmpleadoTemporal(DateTime fechaingreso, DateTime fechasalida, string nombres, string apellidos, int edad, string departamento) : base(nombres, apellidos, edad, departamento)
        {
            this.fechaingreso = fechaingreso;
            this.fechasalida = fechasalida;
        }
        public double getsueldo()
        {
            return sueldo;
        }
        public void setsueldo(double sueldo)
        {
            this.sueldo = sueldo;
        }
    }
}
