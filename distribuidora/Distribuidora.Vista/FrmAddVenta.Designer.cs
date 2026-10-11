namespace Distribuidora.Vista
{
    partial class FrmAddVenta
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbProducto = new ComboBox();
            txtBxCantidad = new TextBox();
            cmbCliente = new ComboBox();
            cmbCajero = new ComboBox();
            dtpFechaVenta = new DateTimePicker();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 80);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 130);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 180);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.Text = "Cajero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 230);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.Text = "Fecha Venta";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(220, 27);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(250, 33);
            // 
            // txtBxCantidad
            // 
            txtBxCantidad.Location = new Point(220, 77);
            txtBxCantidad.Name = "txtBxCantidad";
            txtBxCantidad.Size = new Size(250, 31);
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(220, 127);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(250, 33);
            // 
            // cmbCajero
            // 
            cmbCajero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCajero.FormattingEnabled = true;
            cmbCajero.Location = new Point(220, 177);
            cmbCajero.Name = "cmbCajero";
            cmbCajero.Size = new Size(250, 33);
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.Format = DateTimePickerFormat.Short;
            dtpFechaVenta.Location = new Point(220, 227);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(250, 31);
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(358, 290);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmAddVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 355);
            Controls.Add(btnConfirmar);
            Controls.Add(dtpFechaVenta);
            Controls.Add(cmbCajero);
            Controls.Add(cmbCliente);
            Controls.Add(txtBxCantidad);
            Controls.Add(cmbProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddVenta";
            Text = "Nueva Venta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbProducto;
        private TextBox txtBxCantidad;
        private ComboBox cmbCliente;
        private ComboBox cmbCajero;
        private DateTimePicker dtpFechaVenta;
        private Button btnConfirmar;
    }
}