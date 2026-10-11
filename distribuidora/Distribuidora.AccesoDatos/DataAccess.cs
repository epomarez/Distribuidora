using Distribuidora.Entidades;

/*
   UNED III Cuatrimestre.
   Proyecto 1: Distribuidora Gourmet.
   Descripcion: Este es un proyecto en C# desarrollado en Visual Studio, 
   y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
   Estudiante: Edrey Pomarez.
   Fecha: 11 de Octubre del 2026
*/
// El objetivo de esta clase es simular una base de datos en memoria,
// utilizando arreglos para almacenar diferentes entidades relacionadas
// con el negocio de venta de vehículos.
// Cada arreglo representa una colección de objetos de un tipo específico.
// Esta estructura permite gestionar y acceder a los datos de manera organizada dentro del programa.
namespace Distribuidora.AccesoDatos
{
    public class DataAccess
    {

        private static Cajero[] cajeros = new Cajero[15];
        private static Cliente[] clientes = new Cliente[50];
        private static Ingrediente[] ingredientes = new Ingrediente[50];
        private static Produccion[] produccion = new Produccion[200];
        private static Producto[] productos = new Producto[50];
        private static RecetaDeProducto[] recetasDeProductos = new RecetaDeProducto[200];
        private static Venta[] ventas = new Venta[200];

        // A continuación, se añadirán algunos métodos básicos para gestionar
        // estas colecciones, como agregar nuevos elementos.

        // Estos métodos genéricos permitn manipular los arreglos según el tipo
        // de entidad con que se quiera trabajar.
        // Se sigue el principio de deep modules antes de shallow modules,
        // para hacer el código más modular y fácil de mantener. Así como
        // reducir la carga cognitiva del desarrolador, haciendo una interfaz de módulos más simple.
        public static bool Add(TipoEntidad tipo, object entidad)
        {
            switch (tipo)
            {
                case TipoEntidad.Cajero: return InternalAdd(cajeros, entidad);
                case TipoEntidad.Cliente: return InternalAdd(clientes, entidad);
                case TipoEntidad.Ingrediente: return InternalAdd(ingredientes, entidad);
                case TipoEntidad.Produccion: return InternalAdd(produccion, entidad);
                case TipoEntidad.Producto: return InternalAdd(productos, entidad);
                case TipoEntidad.RecetaDeProducto: return InternalAdd(recetasDeProductos, entidad);
                case TipoEntidad.Venta: return InternalAdd(ventas, entidad);
                default: return false;
            }
        }

        // Metodo que guarda los objetos en su respectivo arreglo.
        private static bool InternalAdd(object[] arreglo, object item)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == null)
                {
                    arreglo[i] = item;
                    return true; // Elemento agregado exitosamente
                }
            }
            return false;
        }

        Metodo que retorna los respectivos arreglos segun el tipo solicitado.
        public static object[] GetAll(TipoEntidad tipo)
        {
            switch (tipo)
            {
                case TipoEntidad.Cajero: return cajeros;
                case TipoEntidad.Cliente: return clientes;
                case TipoEntidad.Ingrediente: return ingredientes;
                case TipoEntidad.Produccion: return produccion;
                case TipoEntidad.Producto: return productos;
                case TipoEntidad.RecetaDeProducto: return recetasDeProductos;
                case TipoEntidad.Venta: return ventas;
                default: return null;
            }
        }
    }
}