using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloEmpresa
{
    class EmpleadoPorHora : Empleado
    {
        private static double preciohora;
        private int numerohoras;
        private double sueldo;

        public EmpleadoPorHora(double preciohora, int numerohoras, string nombres, string apellidos, int edad, string departamento) : base(nombres, apellidos, edad, departamento)
        {
            this.numerohoras = numerohoras;
        }
        public double getsueldo()
        {
            return sueldo;
        }
        public void setsueldo(double sueldo, double preciohora, int numerohoras)
        {
            this.sueldo = sueldo;
            this.numerohoras = numerohoras;
            sueldo = preciohora * numerohoras;
        }
    }
}
