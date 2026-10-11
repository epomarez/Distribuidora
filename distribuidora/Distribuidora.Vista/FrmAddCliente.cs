using System;
using System.Windows.Forms;
using Distribuidora.Entidades;
using Distribuidora.LogicaNegocios;

namespace Distribuidora.Vista
{
    public partial class FrmAddCliente : Form
    {
        public FrmAddCliente()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string identificacion = txtBxIdentificacion.Text.Trim();
                string nombreCompleto = txtBxNombreCompleto.Text.Trim();

                if (string.IsNullOrEmpty(identificacion) || string.IsNullOrEmpty(nombreCompleto))
                {
                    MessageBox.Show("Por favor complete todos los campos de texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
                DateTime fechaRegistro = DateTime.Now;

                int idGenerado = ClienteLN.CantidadClientes + 1;

                // Instancia adaptada a la estructura actual de Persona / Cliente
                Cliente nuevoCliente = new Cliente(
                    idGenerado,
                    identificacion,
                    nombreCompleto,
                    fechaNacimiento,
                    fechaRegistro
                );

                bool resultado = ClienteLN.AddCliente(nuevoCliente);

                if (resultado)
                {
                    MessageBox.Show("Cliente registrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el cliente. Capacidad máxima del arreglo alcanzada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
