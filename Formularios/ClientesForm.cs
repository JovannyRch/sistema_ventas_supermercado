using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class ClientesForm : Form
    {

        int id = -1;
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = Helpers.ObtenerTexto(inputNombre);
            String direccion = Helpers.ObtenerTexto(inputDireccion);
            String telefono = Helpers.ObtenerTexto(inputTelefono);

            Cliente c = new Cliente(nombre, direccion, telefono);

            if(id == -1)
            {
                c.Guardar();
            }
            else
            {
                c.id = id;
                c.Actualizar();
            }

            this.Close();

        }

        private void inputDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void inputTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inputNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {

        }

        public void setDatos(int id, String nombre, String direccion, String telefono)
        {
            this.id = id;
            inputNombre.Text = nombre;
            inputDireccion.Text = direccion;
            inputTelefono.Text = telefono;

            button1.Text = "Actualizar";
        }
    }
}
