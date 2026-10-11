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
    public class VentaLN
    {
        private static short cantidadVentas = 0;
        public static int CantidadVentas => cantidadVentas;
        public static bool AddVenta(Venta venta)
        {
            try
            {
                if (venta == null) return false;
                cantidadVentas++;
                return AccesoDatos.DataAccess.Add(TipoEntidad.Venta, venta);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar venta: " + ex.Message);
            }
        }

        public static Venta[] GetVenta()
        {
            try
            {
                return (Venta[])AccesoDatos.DataAccess.GetAll(TipoEntidad.Venta);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de ventas: " + ex.Message);
            }

        }
    }
}
