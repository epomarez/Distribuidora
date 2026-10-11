namespace Distribuidora.Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public decimal PrecioVenta { get; set; }

        public Producto() { }

        public Producto(int idProducto, string nombreProducto, string categoria, decimal precioVenta)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            Categoria = categoria;
            PrecioVenta = precioVenta;
        }
    }
}
