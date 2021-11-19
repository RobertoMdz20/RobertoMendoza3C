using System;

namespace AppFacultad
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados empleado1 = new Empleados(2014, 15, "Roberto Alejandro", "Mendoza Velez", "Soltero", 0620);
            empleado1.imprimirinformacion();
            Estudiantes estudiante1 = new Estudiantes("Octavo", "Melany Camila", "Zambrano Garcia", "Soltera", 1108);
            estudiante1.imprimirinformacion();
            Profesores profesor1 = new Profesores("Medicina", "Ture Paúl", "Cuadros García", "Casado", 2201);
            profesor1.imprimirinformacion();
            PersonalServicios servicios1 = new PersonalServicios("Decanato", "María José", "Cedeño Zambrano", "Casada", 3022);
            servicios1.imprimirinformacion();
        }
    }
}
