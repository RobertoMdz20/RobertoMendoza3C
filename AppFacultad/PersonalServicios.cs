using System;
using System.Collections.Generic;
using System.Text;

namespace AppFacultad
{
    class PersonalServicios:PersonaFacultad
    {
        private string seccion;

        public PersonalServicios(string seccion, string nombres, string apellidos, string estado_civil, int nroid) : base(nombres, apellidos, estado_civil, nroid)
        {
            this.seccion = seccion;
        }

        public string getSeccion()
        {
            return seccion;
        }

        public void setSeccion(string seccion)
        {
            this.seccion = seccion;
        }

        //Metodo para cambiar de seccion a persona de servicio.
        public void cambiodeseccion(string seccion)
        {
            this.seccion = seccion;
        }

        public override void imprimirinformacion()
        {
            Console.WriteLine("<--- PERSONAL DE SERVICIOS --->");
            base.imprimirinformacion();
            Console.WriteLine("Sección: " + getSeccion());
        }
    }
}
