using System;
using System.Collections.Generic;
using System.Text;

namespace AppFacultad
{
    class PersonaFacultad
    {
        private string nombres;
        private string apellidos;
        private string estado_civil;
        private int nroid;

        public PersonaFacultad(string nombres, string apellidos, string estado_civil, int nroid)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.estado_civil = estado_civil;
            this.nroid = nroid;
        }

        public string getNombres()
        {
            return nombres;
        }

        public void setNombres(string nombres)
        {
            this.nombres = nombres;
        }

        public string getApellides()
        {
            return apellidos;
        }

        public void setApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
        public string getEstadocivil()
        {
            return estado_civil;
        }

        public void setEstadocivil(string estado_civil)
        {
            this.estado_civil = estado_civil;
        }

        public int getNroid()
        {
            return nroid;
        }

        public void setNroid(int nroid)
        {
            this.nroid = nroid;
        }

        //Metodo para cambio de estado civil.
        public void cambioestado_civil(string estado_civil)
        {
            this.estado_civil = estado_civil;
        }
        public virtual void imprimirinformacion()
        {
            Console.WriteLine("Nombre: " + nombres + "\nApellidos: " + apellidos + "\nNúmero de identificació: " + nroid + "\nEstado Civil: " + estado_civil);
        }

    }
}
