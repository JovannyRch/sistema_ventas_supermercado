using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class ProveedoresForm : Form
    {

        int id = -1;
        public ProveedoresForm()
        {
            InitializeComponent();
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = Helpers.ObtenerTexto(inputNombre);
            String direccion = Helpers.ObtenerTexto(inputDireccion);
            String telefono = Helpers.ObtenerTexto(inputTelefono);

            Proveedor item = new Proveedor(nombre, direccion, telefono);

            if(id == -1)
            {
                item.Guardar();
            }
            else
            {
                item.id = id;
                item.Actualizar();
            }
            this.Close();
        }

        private void ProveedoresForm_Load(object sender, EventArgs e)
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
