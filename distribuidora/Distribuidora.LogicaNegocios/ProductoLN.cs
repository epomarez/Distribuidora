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
    public class ProductoLN
    {
        private static short cantidadProductos = 0;
        public static int CantidadProductos => cantidadProductos;
        public static bool AddProducto(Producto producto)
        {
            try
            {
                if (producto == null) return false;
                cantidadProductos++;
                return AccesoDatos.DataAccess.Add(TipoEntidad.Producto, producto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar producto: " + ex.Message);
            }
        }

        public static Producto[] GetProducto()
        {
            try
            {
                return (Producto[])AccesoDatos.DataAccess.GetAll(TipoEntidad.Producto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de productos: " + ex.Message);
            }

        }
    }
}
