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
    public class RecetaDeProductoLN
    {
        private static short cantidadRecetasDeProducto = 0;
        public static int CantidadRecetasDeProducto => cantidadRecetasDeProducto;
        public static bool AddRecetaDeProducto(RecetaProducto recetaDeProducto)
        {
            try
            {
                if (recetaDeProducto == null) return false;
                cantidadRecetasDeProducto++;
                return AccesoDatos.DataAccess.Add(TipoEntidad.RecetaProducto, recetaDeProducto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar receta de producto: " + ex.Message);
            }
        }

        public static RecetaProducto[] GetRecetaDeProducto()
        {
            try
            {
                return (RecetaProducto[])AccesoDatos.DataAccess.GetAll(TipoEntidad.RecetaProducto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de receta de productos: " + ex.Message);
            }

        }
    }
}
