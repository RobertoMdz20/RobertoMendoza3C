using System;
using System.Collections.Generic;
using System.Text;

namespace AppFacultad
{
    class Estudiantes:PersonaFacultad
    {
        private string curso;
        public Estudiantes(string curso, string nombres, string apellidos, string estado_civil, int nroid) : base(nombres, apellidos, estado_civil, nroid)
        {
            this.curso = curso;
        }

        public string getCurso()
        {
            return curso;
        }

        public void setCurso(string curso)
        {
            this.curso = curso;
        }

        //Metodo para matricualar un nuevo curso.
        public void matriculanuevocurso(string curso)
        {
            this.curso = curso;
        }


        public override void imprimirinformacion()
        {
            Console.WriteLine("<--- ESTUDIANTE --->");
            base.imprimirinformacion();
            Console.WriteLine("Curso Matricualdo: " + getCurso());
        }
    }
}

