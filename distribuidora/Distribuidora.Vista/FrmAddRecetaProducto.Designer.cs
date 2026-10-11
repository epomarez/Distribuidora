namespace Distribuidora.Vista
{
    partial class FrmAddRecetaProducto
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
            cmbProducto = new ComboBox();
            cmbIngrediente = new ComboBox();
            txtBxCantidad = new TextBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 95);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.Text = "Ingrediente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 150);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.Text = "Cantidad Requerida";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(220, 37);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(250, 33);
            // 
            // cmbIngrediente
            // 
            cmbIngrediente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngrediente.FormattingEnabled = true;
            cmbIngrediente.Location = new Point(220, 92);
            cmbIngrediente.Name = "cmbIngrediente";
            cmbIngrediente.Size = new Size(250, 33);
            // 
            // txtBxCantidad
            // 
            txtBxCantidad.Location = new Point(220, 147);
            txtBxCantidad.Name = "txtBxCantidad";
            txtBxCantidad.Size = new Size(250, 31);
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(358, 210);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmAddRecetaProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 275);
            Controls.Add(btnConfirmar);
            Controls.Add(txtBxCantidad);
            Controls.Add(cmbIngrediente);
            Controls.Add(cmbProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddRecetaProducto";
            Text = "Nueva Receta de Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbProducto;
        private ComboBox cmbIngrediente;
        private TextBox txtBxCantidad;
        private Button btnConfirmar;
    }
}