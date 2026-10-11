using Distribuidora.Entidades;
using Distribuidora.LogicaNegocios;
using System;
using System.Windows.Forms;

namespace Distribuidora.Vista
{
    public partial class FrmAddVenta : Form
    {
        public FrmAddVenta()
        {
            InitializeComponent();
            CargarCatalogos();
        }

        private void CargarCatalogos()
        {
            try
            {
                // Cargar productos
                Producto[] productos = ProductoLN.GetProducto();
                if (productos != null)
                {
                    foreach (var p in productos)
                    {
                        if (p != null) cmbProducto.Items.Add(p.NombreProducto);
                    }
                }

                // Cargar clientes
                Cliente[] clientes = ClienteLN.GetCliente();
                if (clientes != null)
                {
                    foreach (var c in clientes)
                    {
                        if (c != null) cmbCliente.Items.Add(c.NombreCompleto);
                    }
                }

                // Cargar cajeros
                Cajero[] cajeros = CajeroLN.GetCajero();
                if (cajeros != null)
                {
                    foreach (var caj in cajeros)
                    {
                        if (caj != null) cmbCajero.Items.Add(caj.NombreCompleto);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los catálogos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducto.SelectedItem == null || cmbCliente.SelectedItem == null || cmbCajero.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un producto, un cliente y un cajero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtBxCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad vendida debe ser un número entero válido mayor a cero.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nombreProducto = cmbProducto.SelectedItem.ToString();
                string nombreCliente = cmbCliente.SelectedItem.ToString();
                string nombreCajero = cmbCajero.SelectedItem.ToString();
                DateTime fechaVenta = dtpFechaVenta.Value;

                int idGenerado = VentaLN.CantidadVentas + 1;

                Venta nuevaVenta = new Venta
                {
                    IdVenta = idGenerado,
                    NombreProducto = nombreProducto,
                    Cantidad = cantidad,
                    NombreCliente = nombreCliente,
                    NombreCajero = nombreCajero,
                    FechaVenta = fechaVenta
                };

                bool resultado = VentaLN.AddVenta(nuevaVenta);

                if (resultado)
                {
                    MessageBox.Show("Venta registrada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la venta. Capacidad máxima del arreglo alcanzada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
