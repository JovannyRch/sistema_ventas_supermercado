
namespace ProyectoFinal
{
    partial class RegistroProductosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputExistencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPrecio = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.inputMarca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboProveedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(190, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario de Productos";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(86, 115);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.PlaceholderText = "Ingrese nombre del producto";
            this.inputNombre.Size = new System.Drawing.Size(405, 23);
            this.inputNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Existencias";
            // 
            // inputExistencia
            // 
            this.inputExistencia.Location = new System.Drawing.Point(86, 178);
            this.inputExistencia.Name = "inputExistencia";
            this.inputExistencia.PlaceholderText = "Ingrese exitencia";
            this.inputExistencia.Size = new System.Drawing.Size(200, 23);
            this.inputExistencia.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // inputPrecio
            // 
            this.inputPrecio.Location = new System.Drawing.Point(322, 178);
            this.inputPrecio.Name = "inputPrecio";
            this.inputPrecio.PlaceholderText = "Ingrese precio";
            this.inputPrecio.Size = new System.Drawing.Size(168, 23);
            this.inputPrecio.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(244, 504);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Marca";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // inputMarca
            // 
            this.inputMarca.Location = new System.Drawing.Point(86, 241);
            this.inputMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputMarca.Name = "inputMarca";
            this.inputMarca.PlaceholderText = "Ingrese marca del producto";
            this.inputMarca.Size = new System.Drawing.Size(405, 23);
            this.inputMarca.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descripción";
            // 
            // inputDescripcion
            // 
            this.inputDescripcion.Location = new System.Drawing.Point(86, 306);
            this.inputDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputDescripcion.Multiline = true;
            this.inputDescripcion.Name = "inputDescripcion";
            this.inputDescripcion.PlaceholderText = "Descripción del producto";
            this.inputDescripcion.Size = new System.Drawing.Size(405, 48);
            this.inputDescripcion.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Categoría";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(86, 387);
            this.comboCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(200, 23);
            this.comboCategoria.TabIndex = 12;
            this.comboCategoria.Text = "Seleccione Categoría";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Proveedor";
            // 
            // comboProveedor
            // 
            this.comboProveedor.FormattingEnabled = true;
            this.comboProveedor.Location = new System.Drawing.Point(322, 387);
            this.comboProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboProveedor.Name = "comboProveedor";
            this.comboProveedor.Size = new System.Drawing.Size(168, 23);
            this.comboProveedor.TabIndex = 14;
            this.comboProveedor.Text = "Seleccione Proveedor";
            // 
            // RegistroProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 578);
            this.Controls.Add(this.comboProveedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputMarca);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputExistencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.label1);
            this.Name = "RegistroProductosForm";
            this.Text = "RegistroProductosForm";
            this.Load += new System.EventHandler(this.RegistroProductosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputExistencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputPrecio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboProveedor;
    }
}