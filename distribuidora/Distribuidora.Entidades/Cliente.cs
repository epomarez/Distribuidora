/*
   UNED III Cuatrimestre.
   Proyecto 1: Distribuidora Gourmet.
   Descripcion: Este es un proyecto en C# desarrollado en Visual Studio, 
   y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
   Estudiante: Edrey Pomarez.
   Fecha: 11 de Octubre del 2026
*/

using Distribuidora.Entidades;

public class Cliente : Persona
{
    public DateTime FechaRegistro { get; set; }

    public Cliente(int id, string identificacion, string nombre, string apellido, DateTime fechaNacimiento, bool activo, DateTime fechaRegistro)
        : base(id, identificacion, nombre, apellido, fechaNacimiento, activo)
    {
        FechaRegistro = fechaRegistro;
    }

    // Polimorfismo
    public override string ObtenerRolDetallado()
    {
        return $"Cliente registrado el {FechaRegistro.ToShortDateString()}";
    }
}