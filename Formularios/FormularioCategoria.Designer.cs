﻿
namespace ProyectoFinal.Formularios
{
    partial class FormularioCategoria
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
            this.button1 = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(72, 92);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(51, 15);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(72, 120);
            this.inputNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(247, 23);
            this.inputNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción";
            // 
            // inputDescripcion
            // 
            this.inputDescripcion.Location = new System.Drawing.Point(72, 200);
            this.inputDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputDescripcion.Multiline = true;
            this.inputDescripcion.Name = "inputDescripcion";
            this.inputDescripcion.Size = new System.Drawing.Size(247, 66);
            this.inputDescripcion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Formulario Categorías";
            // 
            // FormularioCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioCategoria";
            this.Text = "FormularioCategoria";
            this.Load += new System.EventHandler(this.FormularioCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputDescripcion;
        private System.Windows.Forms.Label label2;
    }
}