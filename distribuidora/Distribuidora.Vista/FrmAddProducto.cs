using Distribuidora.Entidades;
using Distribuidora.LogicaNegocios;

namespace Distribuidora.Vista
{
    public partial class FrmAddProducto : Form
    {
        public FrmAddProducto()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtBxNombre.Text.Trim();
                string categoria = txtBxCategoria.Text.Trim();

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(categoria))
                {
                    MessageBox.Show("Por favor complete todos los campos de texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtBxPrecio.Text, out decimal precio) || precio < 0)
                {
                    MessageBox.Show("El precio de venta debe ser un número válido mayor o igual a cero.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idGenerado = ProductoLN.CantidadProductos + 1;

                Producto nuevoProducto = new Producto
                {
                    IdProducto = idGenerado,
                    NombreProducto = nombre,
                    Categoria = categoria,
                    PrecioVenta = precio
                };

                bool resultado = ProductoLN.AddProducto(nuevoProducto);

                if (resultado)
                {
                    MessageBox.Show("Producto registrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el producto. Capacidad máxima del arreglo alcanzada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
