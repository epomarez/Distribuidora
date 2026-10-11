namespace Distribuidora.Entidades
{
    public class Ingrediente
    {
        public int IdIngrediente { get; set; }
        public string NombreIngrediente { get; set; }
        public string UnidadMedida { get; set; }
        public decimal ExistenciaActual { get; set; }
        public decimal CostoUnitario { get; set; }

        // Constructor vacio
        public Ingrediente() { }

        // Constructor con parametros para facilitar la inicializacion
        public Ingrediente(int idIngrediente, string nombreIngrediente, string unidadMedida, decimal existenciaActual, decimal costoUnitario)
        {
            IdIngrediente = idIngrediente;
            NombreIngrediente = nombreIngrediente;
            UnidadMedida = unidadMedida;
            ExistenciaActual = existenciaActual;
            CostoUnitario = costoUnitario;
        }
    }
}
