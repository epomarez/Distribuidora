/*
   UNED III Cuatrimestre.
   Proyecto 1: Distribuidora Gourmet.
   Descripcion: Este es un proyecto en C# desarrollado en Visual Studio, 
   y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
   Estudiante: Edrey Pomarez.
   Fecha: 11 de Octubre del 2026
*/

namespace Distribuidora.Entidades
{
    public abstract class Persona
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }

        protected Persona(int id, string identificacion, string nombre, string apellido, DateTime fechaNacimiento, bool activo)
        {
            Id = id;
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Activo = activo;
        }

        // Método abstracto para polimorfismo.
        public abstract string ObtenerRolDetallado();
    }
}