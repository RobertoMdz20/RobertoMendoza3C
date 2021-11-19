using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloEmpresa
{
    class Empleado
    {
        private string nombres;
        private string apellidos;
        private int edad;
        private string departamento;

        public Empleado(string nombres, string apellidos, int edad, string departamento)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
            this.departamento = departamento;
        }
        public string getNombres()
        {
            return nombres;
        }
        public void setNombres(string nombres)
        {
            this.nombres = nombres;
        }
        public string getApellidos()
        {
            return apellidos;
        }
        public void setApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
        public int getEdad()
        {
            return edad;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public string getDepartamento()
        {
            return departamento;
        }
        public void setdDepartamento(string departamento)
        {
            this.departamento = departamento;
        }
    }

}
