namespace Distribuidora.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public string NombreCliente { get; set; }
        public string NombreCajero { get; set; }
        public DateTime FechaVenta { get; set; }

        public Venta() { }

        public Venta(int idVenta, string nombreProducto, int cantidad, string nombreCliente, string nombreCajero, DateTime fechaVenta)
        {
            IdVenta = idVenta;
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            NombreCliente = nombreCliente;
            NombreCajero = nombreCajero;
            FechaVenta = fechaVenta;
        }
    }
}
