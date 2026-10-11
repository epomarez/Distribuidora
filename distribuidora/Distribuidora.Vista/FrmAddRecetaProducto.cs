using Distribuidora.Entidades;
using Distribuidora.LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora.Vista
{
    public partial class FrmAddRecetaProducto : Form
    {
        public FrmAddRecetaProducto()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void CargarCombos()
        {
            try
            {
                // Cargar productos en el ComboBox
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

                // Cargar ingredientes en el ComboBox
                Ingrediente[] ingredientes = IngredienteLN.GetIngrediente();
                if (ingredientes != null)
                {
                    foreach (var ing in ingredientes)
                    {
                        if (ing != null)
                        {
                            cmbIngrediente.Items.Add(ing.NombreIngrediente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar listas en los combos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducto.SelectedItem == null || cmbIngrediente.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un producto y un ingrediente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombreProducto = cmbProducto.SelectedItem.ToString();
                string nombreIngrediente = cmbIngrediente.SelectedItem.ToString();

                if (!decimal.TryParse(txtBxCantidad.Text, out decimal cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad requerida debe ser un número válido mayor a cero.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idGenerado = RecetaDeProductoLN.CantidadRecetasDeProducto + 1;

                RecetaProducto nuevaReceta = new RecetaProducto
                {
                    IdRecetaProducto = idGenerado,
                    NombreProducto = nombreProducto,
                    NombreIngrediente = nombreIngrediente,
                    CantidadRequerida = cantidad
                };

                bool resultado = RecetaDeProductoLN.AddRecetaDeProducto(nuevaReceta);

                if (resultado)
                {
                    MessageBox.Show("Receta de producto registrada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la receta. Capacidad máxima del arreglo alcanzada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
