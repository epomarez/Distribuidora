namespace Distribuidora.Entidades
{
    public class Produccion
    {
        public int IdProduccion { get; set; }
        public string NombreProducto { get; set; }
        public int CantidadProducida { get; set; }
        public DateTime FechaProduccion { get; set; }

        public Produccion() { }

        public Produccion(int idProduccion, string nombreProducto, int cantidadProducida, DateTime fechaProduccion)
        {
            IdProduccion = idProduccion;
            NombreProducto = nombreProducto;
            CantidadProducida = cantidadProducida;
            FechaProduccion = fechaProduccion;
        }
    }
}
