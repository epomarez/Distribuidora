namespace Distribuidora.Vista
{
    partial class FrmAddProducto
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
            txtBxNombre = new TextBox();
            txtBxCategoria = new TextBox();
            txtBxPrecio = new TextBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.Text = "Nombre Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 95);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.Text = "Categoría";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 150);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.Text = "Precio Venta";
            // 
            // txtBxNombre
            // 
            txtBxNombre.Location = new Point(200, 37);
            txtBxNombre.Name = "txtBxNombre";
            txtBxNombre.Size = new Size(250, 31);
            // 
            // txtBxCategoria
            // 
            txtBxCategoria.Location = new Point(200, 92);
            txtBxCategoria.Name = "txtBxCategoria";
            txtBxCategoria.Size = new Size(250, 31);
            // 
            // txtBxPrecio
            // 
            txtBxPrecio.Location = new Point(200, 147);
            txtBxPrecio.Name = "txtBxPrecio";
            txtBxPrecio.Size = new Size(250, 31);
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(338, 210);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmAddProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 275);
            Controls.Add(btnConfirmar);
            Controls.Add(txtBxPrecio);
            Controls.Add(txtBxCategoria);
            Controls.Add(txtBxNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddProducto";
            Text = "Nuevo Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBxNombre;
        private TextBox txtBxCategoria;
        private TextBox txtBxPrecio;
        private Button btnConfirmar;
    }
}