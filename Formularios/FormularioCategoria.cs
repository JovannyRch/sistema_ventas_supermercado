using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios
{
    public partial class FormularioCategoria : Form
    {


        int id = -1;

        public FormularioCategoria()
        {
            InitializeComponent();
        }



        private void FormularioCategoria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            String nombre = Helpers.ObtenerTexto(inputNombre);
            String descripcion = Helpers.ObtenerTexto(inputDescripcion);

            Categoria c = new Categoria(nombre, descripcion);
     

            if (id == -1)
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

        public void setDatos(int id, String nombre, String descripcion)
        {
            this.id = id;
            inputNombre.Text = nombre;
            inputDescripcion.Text = descripcion;

            button1.Text = "Actualizar";

        }

    }
}
