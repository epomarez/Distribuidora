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
    public class ClienteLN
    {
        private static short cantidadClientes = 0;
        public static int CantidadClientes => cantidadClientes;
        public static bool AddCliente(Cliente cliente)
        {
            try
            {
                if (cliente == null) return false;
                cantidadClientes++;
                return AccesoDatos.DataAccess.Add(TipoEntidad.Cliente, cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar cliente: " + ex.Message);
            }
        }

        public static Cliente[] GetCliente()
        {
            try
            {
                return (Cliente[])AccesoDatos.DataAccess.GetAll(TipoEntidad.Cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de clientes: " + ex.Message);
            }

        }
    }
}
