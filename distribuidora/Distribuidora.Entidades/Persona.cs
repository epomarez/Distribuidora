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
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }

        protected Persona(int id, string identificacion, string nombreCompleto, DateTime fechaNacimiento)
        {
            Id = id;
            Identificacion = identificacion;
            this.NombreCompleto = nombreCompleto;
            FechaNacimiento = fechaNacimiento;
        }

        public string Nombre
        {
            get
            {
                if (string.IsNullOrWhiteSpace(NombreCompleto)) return string.Empty;
                int indiceEspacio = NombreCompleto.IndexOf(' ');
                if (indiceEspacio == -1)
                {
                    return NombreCompleto; // Si no hay espacios, todo es el nombre
                }
                return NombreCompleto.Substring(0, indiceEspacio);
            }
        }

        // Propiedad calculada para el GridView: Extrae el Apellido (todo lo que está después del primer espacio)
        public string Apellido
        {
            get
            {
                if (string.IsNullOrWhiteSpace(NombreCompleto)) return string.Empty;
                int indiceEspacio = NombreCompleto.IndexOf(' ');
                if (indiceEspacio == -1)
                {
                    return string.Empty; // Si no hay espacio, no hay apellido separado
                }
                return NombreCompleto.Substring(indiceEspacio + 1).Trim();
            }
        }

        // Método abstracto para polimorfismo.
        public abstract string ObtenerRolDetallado();
    }
}