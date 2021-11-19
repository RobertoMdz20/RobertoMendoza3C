using System;
using System.Collections.Generic;
using System.Text;

namespace AppFacultad
{
    class Profesores:PersonaFacultad
    {
        private string departamento;

        public Profesores(string departamento, string nombres, string apellidos, string estado_civil, int nroid) : base(nombres, apellidos, estado_civil, nroid)
        {
            this.departamento = departamento;
        }

        public string getDepartamento()
        {
            return departamento;
        }

        public void setDepartamento(string departamento)
        {
            this.departamento = departamento;
        }

        //Metodo para cambio de departamento a profesor.
        public void cambiodepartamento(string departamento)
        {
            this.departamento = departamento;
        }

        public override void imprimirinformacion()
        {
            Console.WriteLine("<--- PROFESOR --->");
            base.imprimirinformacion();
            Console.WriteLine("Departamento: " + getDepartamento());
        }
    }
}
