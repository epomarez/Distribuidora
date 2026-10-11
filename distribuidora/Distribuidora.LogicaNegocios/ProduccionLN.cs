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
    public class ProduccionLN
    {
        private static short cantidadProduccion = 0;
        public static int CantidadProduccion => cantidadProduccion;
        public static bool AddProduccion(Produccion produccion)
        {
            try
            {
                if (produccion == null) return false;
                cantidadProduccion++;
                return AccesoDatos.DataAccess.Add(TipoEntidad.Produccion, produccion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar produccion: " + ex.Message);
            }
        }

        public static Produccion[] GetProduccion()
        {
            try
            {
                return (Produccion[])AccesoDatos.DataAccess.GetAll(TipoEntidad.Produccion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de produccion: " + ex.Message);
            }

        }
    }
}
