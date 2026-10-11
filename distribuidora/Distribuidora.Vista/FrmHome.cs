using Distribuidora.Entidades;
using Distribuidora.LogicaNegocios;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Distribuidora.Vista
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        // Este método se ejecuta al cambiar de TabPage y recarga el GridView
        private void tCMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarGridView();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            cargarGridView();
        }

        // Este método se ejecuta al hacer clic en el botón "Añadir Elemento" 
        // y abre el formulario correspondiente según el TabPage seleccionado
        private void btnAniadirElemento_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedTab = tCMenu.SelectedTab;
                if (selectedTab == null) return;

                switch (selectedTab.Text)
                {
                    case "Ingredientes":
                        FrmAddIngrediente frmIngrediente = new FrmAddIngrediente();
                        frmIngrediente.ShowDialog();
                        cargarGridView();
                        break;
                    case "Productos":
                        FrmAddProducto frmProducto = new FrmAddProducto();
                        frmProducto.ShowDialog();
                        cargarGridView();
                        break;
                    case "Recetas":
                        FrmAddRecetaProducto frmReceta = new FrmAddRecetaProducto();
                        frmReceta.ShowDialog();
                        cargarGridView();
                        break;
                    case "Clientes":
                        FrmAddCliente frmCliente = new FrmAddCliente();
                        frmCliente.ShowDialog();
                        cargarGridView();
                        break;
                    case "Cajeros":
                        FrmAddCajero frmCajero = new FrmAddCajero();
                        frmCajero.ShowDialog(); 
                        cargarGridView();
                        break;
                    case "Producción":
                        FrmAddProduccion frmProduccion = new FrmAddProduccion();
                        frmProduccion.ShowDialog();
                        cargarGridView();
                        break;
                    case "Ventas":
                        FrmAddVenta frmVenta = new FrmAddVenta();
                        frmVenta.ShowDialog();
                        cargarGridView();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Este método carga el DataSource en el GridView según el TabPage seleccionado
        private void cargarGridView()
        {
            try
            {
                var selectedTab = tCMenu.SelectedTab;
                if (selectedTab == null) return;

                dgvInfoArreglos.DataSource = null;
                dgvInfoArreglos.AutoGenerateColumns = false;
                dgvInfoArreglos.Columns.Clear();

                switch (selectedTab.Text)
                {
                    case "Ingredientes":
                        dgvInfoArreglos.DataSource = IngredienteLN.GetIngrediente();
                        ConfigurarColumnasIngredientes();
                        break;
                    case "Productos":
                        dgvInfoArreglos.DataSource = ProductoLN.GetProducto();
                        ConfigurarColumnasProductos();
                        break;
                    case "Recetas":
                        dgvInfoArreglos.DataSource = RecetaDeProductoLN.GetRecetaDeProducto();
                        ConfigurarColumnasRecetas();
                        break;
                    case "Clientes":
                        dgvInfoArreglos.DataSource = ClienteLN.GetCliente();
                        ConfigurarColumnasClientes();
                        break;
                    case "Cajeros":
                        dgvInfoArreglos.DataSource = CajeroLN.GetCajero();
                        ConfigurarColumnasCajeros();
                        break;
                    case "Producción":
                        dgvInfoArreglos.DataSource = ProduccionLN.GetProduccion();
                        ConfigurarColumnasProduccion();
                        break;
                    case "Ventas":
                        dgvInfoArreglos.DataSource = VentaLN.GetVenta();
                        ConfigurarColumnasVentas();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos en el grid: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos de configuración de columnas para el DataGridView
        private void ConfigurarColumnasIngredientes()
        {
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdIngrediente", HeaderText = "ID" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NombreIngrediente", HeaderText = "Nombre" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnidadMedida", HeaderText = "Unidad de Medida" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ExistenciaActual", HeaderText = "Existencia" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CostoUnitario", HeaderText = "Costo Unitario" });
        }

        private void ConfigurarColumnasProductos()
        {
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdProducto", HeaderText = "ID" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NombreProducto", HeaderText = "Nombre" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Categoria", HeaderText = "Categoría" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PrecioVenta", HeaderText = "Precio Venta" });
        }

        private void ConfigurarColumnasRecetas()
        {
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdRecetaProducto", HeaderText = "ID Receta" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NombreProducto", HeaderText = "Producto" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NombreIngrediente", HeaderText = "Ingrediente" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CantidadRequerida", HeaderText = "Cantidad Requerida" });
        }

        private void ConfigurarColumnasClientes()
        {
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Identificacion", HeaderText = "Identificación" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nombre", HeaderText = "Nombre" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Apellido", HeaderText = "Apellido" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FechaNacimiento", HeaderText = "Fecha Nacimiento" });
        }

        private void ConfigurarColumnasCajeros()
        {
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Identificacion", HeaderText = "Identificación" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nombre", HeaderText = "Nombre" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Apellido", HeaderText = "Apellido" });
        }

        private void ConfigurarColumnasProduccion()
        {
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdProduccion", HeaderText = "ID Producción" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CantidadProducida", HeaderText = "Cantidad" });
        }

        private void ConfigurarColumnasVentas()
        {
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdVenta", HeaderText = "ID Venta" });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cantidad", HeaderText = "Cantidad" });
        }
    }
}