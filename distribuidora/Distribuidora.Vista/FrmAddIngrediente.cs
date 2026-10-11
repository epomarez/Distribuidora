using System;
using System.Windows.Forms;
using Distribuidora.Entidades;
using Distribuidora.LogicaNegocios;

namespace Distribuidora.Vista
{
    public partial class FrmAddIngrediente : Form
    {
        public FrmAddIngrediente()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación defensiva (Try-Catch y conversiones seguras)
                string nombre = txtBxNombre.Text.Trim();
                string unidad = txtBxUnidad.Text.Trim();

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(unidad))
                {
                    MessageBox.Show("Por favor complete todos los campos de texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtBxExistencia.Text, out int existencia) || existencia < 0)
                {
                    MessageBox.Show("La existencia actual debe ser un número entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtBxCosto.Text, out decimal costo) || costo < 0)
                {
                    MessageBox.Show("El costo unitario debe ser un valor numérico válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generamos un ID automático basado en el contador actual
                int idGenerado = IngredienteLN.CantidadINgredientes + 1;

                Ingrediente nuevoIngrediente = new Ingrediente
                {
                    IdIngrediente = idGenerado,
                    NombreIngrediente = nombre,
                    UnidadMedida = unidad,
                    ExistenciaActual = existencia,
                    CostoUnitario = costo
                };

                bool resultado = IngredienteLN.AddIngrediente(nuevoIngrediente);

                if (resultado)
                {
                    MessageBox.Show("Ingrediente registrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el ingrediente. Capacidad máxima del arreglo alcanzada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
