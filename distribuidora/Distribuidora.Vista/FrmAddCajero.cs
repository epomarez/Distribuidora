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
    public partial class FrmAddCajero : Form
    {
        public FrmAddCajero()
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
                DateTime fechaIngreso = dtpFechaIngreso.Value;

                int idGenerado = CajeroLN.CantidadCajeros + 1;

                // Creando la instancia de Cajero (hereda de Persona y maneja polimorfismo)
                Cajero nuevoCajero = new Cajero(
                    idGenerado,
                    identificacion,
                    nombreCompleto,
                    fechaNacimiento,
                    fechaIngreso
                );

                bool resultado = CajeroLN.AddCajero(nuevoCajero);

                if (resultado)
                {
                    MessageBox.Show("Cajero registrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el cajero. Capacidad máxima del arreglo alcanzada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
