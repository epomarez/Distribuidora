namespace Distribuidora.Vista
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tCMenu = new TabControl();
            tPIngrediente = new TabPage();
            tPProducto = new TabPage();
            tPReceta = new TabPage();
            tPCliente = new TabPage();
            tPCajero = new TabPage();
            tPProduccion = new TabPage();
            tPVenta = new TabPage();
            dgvInfoArreglos = new DataGridView();
            btnAniadirElemento = new Button();
            tCMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfoArreglos).BeginInit();
            SuspendLayout();
            // 
            // tCMenu
            // 
            tCMenu.Controls.Add(tPIngrediente);
            tCMenu.Controls.Add(tPProducto);
            tCMenu.Controls.Add(tPReceta);
            tCMenu.Controls.Add(tPCliente);
            tCMenu.Controls.Add(tPCajero);
            tCMenu.Controls.Add(tPProduccion);
            tCMenu.Controls.Add(tPVenta);
            tCMenu.Location = new Point(120, 49);
            tCMenu.Multiline = true;
            tCMenu.Name = "tCMenu";
            tCMenu.SelectedIndex = 0;
            tCMenu.Size = new Size(751, 39);
            tCMenu.TabIndex = 0;
            tCMenu.SelectedIndexChanged += tCMenu_SelectedIndexChanged;
            // 
            // tPIngrediente
            // 
            tPIngrediente.Location = new Point(4, 34);
            tPIngrediente.Name = "tPIngrediente";
            tPIngrediente.Padding = new Padding(3);
            tPIngrediente.Size = new Size(743, 1);
            tPIngrediente.TabIndex = 0;
            tPIngrediente.Text = "Ingredientes";
            tPIngrediente.UseVisualStyleBackColor = true;
            // 
            // tPProducto
            // 
            tPProducto.Location = new Point(4, 34);
            tPProducto.Name = "tPProducto";
            tPProducto.Padding = new Padding(3);
            tPProducto.Size = new Size(743, 1);
            tPProducto.TabIndex = 1;
            tPProducto.Text = "Productos";
            tPProducto.UseVisualStyleBackColor = true;
            // 
            // tPReceta
            // 
            tPReceta.Location = new Point(4, 34);
            tPReceta.Name = "tPReceta";
            tPReceta.Padding = new Padding(3);
            tPReceta.Size = new Size(743, 1);
            tPReceta.TabIndex = 2;
            tPReceta.Text = "Recetas";
            tPReceta.UseVisualStyleBackColor = true;
            // 
            // tPCliente
            // 
            tPCliente.Location = new Point(4, 34);
            tPCliente.Name = "tPCliente";
            tPCliente.Size = new Size(559, 1);
            tPCliente.TabIndex = 3;
            tPCliente.Text = "Clientes";
            tPCliente.UseVisualStyleBackColor = true;
            // 
            // tPCajero
            // 
            tPCajero.Location = new Point(4, 34);
            tPCajero.Name = "tPCajero";
            tPCajero.Size = new Size(559, 1);
            tPCajero.TabIndex = 4;
            tPCajero.Text = "Cajeros";
            tPCajero.UseVisualStyleBackColor = true;
            // 
            // tPProduccion
            // 
            tPProduccion.Location = new Point(4, 34);
            tPProduccion.Name = "tPProduccion";
            tPProduccion.Size = new Size(743, 1);
            tPProduccion.TabIndex = 5;
            tPProduccion.Text = "Producción";
            tPProduccion.UseVisualStyleBackColor = true;
            // 
            // tPVenta
            // 
            tPVenta.Location = new Point(4, 34);
            tPVenta.Name = "tPVenta";
            tPVenta.Size = new Size(743, 1);
            tPVenta.TabIndex = 6;
            tPVenta.Text = "Ventas";
            tPVenta.UseVisualStyleBackColor = true;
            // 
            // dgvInfoArreglos
            // 
            dgvInfoArreglos.AllowUserToAddRows = false;
            dgvInfoArreglos.AllowUserToDeleteRows = false;
            dgvInfoArreglos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfoArreglos.Location = new Point(120, 94);
            dgvInfoArreglos.MultiSelect = false;
            dgvInfoArreglos.Name = "dgvInfoArreglos";
            dgvInfoArreglos.ReadOnly = true;
            dgvInfoArreglos.RowHeadersWidth = 62;
            dgvInfoArreglos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfoArreglos.Size = new Size(855, 357);
            dgvInfoArreglos.TabIndex = 1;
            // 
            // btnAniadirElemento
            // 
            btnAniadirElemento.Location = new Point(773, 470);
            btnAniadirElemento.Name = "btnAniadirElemento";
            btnAniadirElemento.Size = new Size(112, 34);
            btnAniadirElemento.TabIndex = 2;
            btnAniadirElemento.Text = "Añadir";
            btnAniadirElemento.UseVisualStyleBackColor = true;
            btnAniadirElemento.Click += btnAniadirElemento_Click;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 525);
            Controls.Add(btnAniadirElemento);
            Controls.Add(dgvInfoArreglos);
            Controls.Add(tCMenu);
            Name = "FrmHome";
            Text = "Distribuidora Gourmet - Menú Principal";
            Load += FrmHome_Load;
            tCMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInfoArreglos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tCMenu;
        private TabPage tPIngrediente;
        private TabPage tPProducto;
        private TabPage tPReceta;
        private TabPage tPCliente;
        private TabPage tPCajero;
        private TabPage tPProduccion;
        private TabPage tPVenta;
        private DataGridView dgvInfoArreglos;
        private Button btnAniadirElemento;
    }
}