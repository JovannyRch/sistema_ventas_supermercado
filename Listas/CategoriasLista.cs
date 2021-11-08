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
    public partial class CategoriasLista : Form
    {

        List<Categoria> categorias;

        public CategoriasLista()
        {
            InitializeComponent();
        }

        private void CategoriasLista_Load(object sender, EventArgs e)
        {
            cargarDatos();

        }
    

        private void cargarDatos()
        {
            categorias = Categoria.GetAll();
            Helpers.formatGrid(dataGrid);
            dataGrid.Columns.Clear();
            dataGrid.Columns.Add("Nombre", "Nombre");
            dataGrid.Columns.Add("Descripción", "Descripción");

            dataGrid.Rows.Clear();


            foreach (var c in categorias)
            {
                dataGrid.Rows.Add( c.nombre, c.descripcion);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FormularioCategoria form = new Formularios.FormularioCategoria();

            form.ShowDialog();

            cargarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGrid.CurrentRow.Index;
            if (index != -1 && index < categorias.ToArray().Length)
            {

                bool res = categorias[index].Eliminar();

                if (res)
                {
                    Helpers.MostrarMensaje("Categoría eliminada exitosamente");
                }
                else
                {
                    Helpers.MostrarMensaje("Ocurrió un error al eliminar la categoría");
                }
                cargarDatos();
            }
            }

        private void button3_Click(object sender, EventArgs e)

        {
            int index = dataGrid.CurrentRow.Index;
            if (index == -1 || index >= categorias.ToArray().Length) return;

            Formularios.FormularioCategoria form = new Formularios.FormularioCategoria();
            Categoria c = categorias[index];
            form.setDatos(c.id, c.nombre, c.descripcion);

            form.ShowDialog();

            cargarDatos();
        }
    }
    }


