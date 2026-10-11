namespace Distribuidora.Vista
{
    partial class FrmAddIngrediente
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
            txtBxNombre = new TextBox();
            txtBxUnidad = new TextBox();
            txtBxExistencia = new TextBox();
            txtBxCosto = new TextBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre Ingrediente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 80);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 1;
            label2.Text = "Unidad de Medida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 130);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 2;
            label3.Text = "Existencia Actual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 180);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 3;
            label4.Text = "Costo Unitario";
            // 
            // txtBxNombre
            // 
            txtBxNombre.Location = new Point(230, 27);
            txtBxNombre.Name = "txtBxNombre";
            txtBxNombre.Size = new Size(250, 31);
            txtBxNombre.TabIndex = 4;
            // 
            // txtBxUnidad
            // 
            txtBxUnidad.Location = new Point(230, 77);
            txtBxUnidad.Name = "txtBxUnidad";
            txtBxUnidad.Size = new Size(250, 31);
            txtBxUnidad.TabIndex = 5;
            // 
            // txtBxExistencia
            // 
            txtBxExistencia.Location = new Point(230, 127);
            txtBxExistencia.Name = "txtBxExistencia";
            txtBxExistencia.Size = new Size(250, 31);
            txtBxExistencia.TabIndex = 6;
            // 
            // txtBxCosto
            // 
            txtBxCosto.Location = new Point(230, 177);
            txtBxCosto.Name = "txtBxCosto";
            txtBxCosto.Size = new Size(250, 31);
            txtBxCosto.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(368, 235);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmAddIngrediente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 295);
            Controls.Add(btnConfirmar);
            Controls.Add(txtBxCosto);
            Controls.Add(txtBxExistencia);
            Controls.Add(txtBxUnidad);
            Controls.Add(txtBxNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddIngrediente";
            Text = "Nuevo Ingrediente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBxNombre;
        private TextBox txtBxUnidad;
        private TextBox txtBxExistencia;
        private TextBox txtBxCosto;
        private Button btnConfirmar;
    }
}