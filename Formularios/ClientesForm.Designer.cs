
namespace ProyectoFinal
{
    partial class ClientesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.inputTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(224, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(127, 118);
            this.inputNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(446, 23);
            this.inputNombre.TabIndex = 2;
            this.inputNombre.TextChanged += new System.EventHandler(this.inputNombre_TextChanged);
            // 
            // inputTelefono
            // 
            this.inputTelefono.Location = new System.Drawing.Point(132, 186);
            this.inputTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputTelefono.Name = "inputTelefono";
            this.inputTelefono.Size = new System.Drawing.Size(446, 23);
            this.inputTelefono.TabIndex = 4;
            this.inputTelefono.TextChanged += new System.EventHandler(this.inputTelefono_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teléfono";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // inputDireccion
            // 
            this.inputDireccion.Location = new System.Drawing.Point(132, 254);
            this.inputDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputDireccion.Name = "inputDireccion";
            this.inputDireccion.Size = new System.Drawing.Size(446, 23);
            this.inputDireccion.TabIndex = 6;
            this.inputDireccion.TextChanged += new System.EventHandler(this.inputDireccion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dirección";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.TextBox inputTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}