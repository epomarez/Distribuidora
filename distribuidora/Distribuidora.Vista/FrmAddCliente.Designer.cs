namespace Distribuidora.Vista
{
    partial class FrmAddCliente
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
            label4 = new Label();
            txtBxIdentificacion = new TextBox();
            txtBxNombreCompleto = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 35);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.Text = "Identificación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 90);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.Text = "Nombre Completo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 145);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.Text = "Fecha de Nacimiento";
            // 
            // txtBxIdentificacion
            // 
            txtBxIdentificacion.Location = new Point(230, 32);
            txtBxIdentificacion.Name = "txtBxIdentificacion";
            txtBxIdentificacion.Size = new Size(250, 31);
            // 
            // txtBxNombreCompleto
            // 
            txtBxNombreCompleto.Location = new Point(230, 87);
            txtBxNombreCompleto.Name = "txtBxNombreCompleto";
            txtBxNombreCompleto.Size = new Size(250, 31);
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(230, 140);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 31);
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(368, 210);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmAddCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 275);
            Controls.Add(btnConfirmar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtBxNombreCompleto);
            Controls.Add(txtBxIdentificacion);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddCliente";
            Text = "Nuevo Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtBxIdentificacion;
        private TextBox txtBxNombreCompleto;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnConfirmar;
    }
}