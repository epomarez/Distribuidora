namespace Distribuidora.Entidades
{
    public class RecetaProducto
    {
        public int IdRecetaProducto { get; set; }
        public string NombreProducto { get; set; }
        public string NombreIngrediente { get; set; }
        public decimal CantidadRequerida { get; set; }

        public RecetaProducto() { }

        public RecetaProducto(int idRecetaProducto, string nombreProducto, string nombreIngrediente, decimal cantidadRequerida)
        {
            IdRecetaProducto = idRecetaProducto;
            NombreProducto = nombreProducto;
            NombreIngrediente = nombreIngrediente;
            CantidadRequerida = cantidadRequerida;
        }
    }
}
