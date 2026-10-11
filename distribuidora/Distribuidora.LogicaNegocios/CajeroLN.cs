/*
   UNED III Cuatrimestre.
   Proyecto 1: Distribuidora Gourmet.
   Descripcion: Este es un proyecto en C# desarrollado en Visual Studio, 
   y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
   Estudiante: Edrey Pomarez.
   Fecha: 11 de Octubre del 2026
*/
using Distribuidora.Entidades;
namespace Distribuidora.LogicaNegocios
{
    public class CajeroLN
    {
        private static short cantidadCajeros = 0;
        public static int CantidadCajeros => cantidadCajeros;
        public static bool AddCajero(Cajero cajero)
        {
            try
            {
                if (cajero == null) return false;
                cantidadCajeros++;
                return AccesoDatos.DataAccess.Add(TipoEntidad.Cajero, cajero);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar cajero: " + ex.Message);
            }
        }

        public static Cajero[] GetCajero()
        {
            try
            {
                return (Cajero[])AccesoDatos.DataAccess.GetAll(TipoEntidad.Cajero);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de cajeros: " + ex.Message);
            }

        }
    }
}