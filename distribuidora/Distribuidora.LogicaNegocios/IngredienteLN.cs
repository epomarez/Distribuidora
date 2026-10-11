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
    public class IngredienteLN
    {
        private static short cantidadIngredientes = 0;
        public static int CantidadINgredientes => cantidadIngredientes;
        public static bool AddIngrediente(Ingrediente ingrediente)
        {
            try
            {
                if (ingrediente == null) return false;
                cantidadIngredientes++;
                return AccesoDatos.DataAccess.Add(TipoEntidad.Ingrediente, ingrediente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar ingrediente: " + ex.Message);
            }
        }

        public static Ingrediente[] GetIngrediente()
        {
            try
            {
                return (Ingrediente[])AccesoDatos.DataAccess.GetAll(TipoEntidad.Ingrediente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de ingredientes: " + ex.Message);
            }

        }
    }
}
