using System;
using System.Windows.Forms;
using Distribuidora.Entidades;
using Distribuidora.LogicaNegocios;

namespace Distribuidora.Vista
{
    public partial class FrmAddProduccion : Form
    {
        public FrmAddProduccion()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                Producto[] productos = ProductoLN.GetProducto();
                if (productos != null)
                {
                    foreach (var p in productos)
                    {
                        if (p != null)
                        {
                            cmbProducto.Items.Add(p.NombreProducto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducto.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombreProducto = cmbProducto.SelectedItem.ToString();

                if (!int.TryParse(txtBxCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad producida debe ser un número entero válido mayor a cero.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime fechaProduccion = dtpFechaProduccion.Value;
                int idGenerado = ProduccionLN.CantidadProduccion + 1;

                Produccion nuevaProduccion = new Produccion
                {
                    IdProduccion = idGenerado,
                    NombreProducto = nombreProducto,
                    CantidadProducida = cantidad,
                    FechaProduccion = fechaProduccion
                };

                bool resultado = ProduccionLN.AddProduccion(nuevaProduccion);

                if (resultado)
                {
                    MessageBox.Show("Producción registrada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la producción. Capacidad máxima del arreglo alcanzada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
