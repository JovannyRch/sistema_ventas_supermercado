using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class RegistroProductosForm : Form
    {

        private List<Categoria> categorias;
        private List<Proveedor> proveedores;

        int id = -1;



        public RegistroProductosForm()
        {
            InitializeComponent(); 
            this.cargarDatos();
        }

        public void setVisible(bool val)
        {
            this.Visible = val;
            this.cargarDatos();
        }

        private void cargarDatos()
        {
            categorias = Categoria.GetAll();
            Helpers.insertarEnCombo(comboCategoria, categorias.Select( c => c.nombre).ToArray());


            proveedores = Proveedor.GetAll();
            Helpers.insertarEnCombo(comboProveedor, proveedores.Select(p => p.nombre).ToArray());
        }


        public void setDatos(int id, String nombre, int existencias, double precio, String marca, String descripcion, int id_proveedor, int id_categoria)
        {
            this.id = id;
            inputNombre.Text = nombre;
            inputExistencia.Text = existencias.ToString();
            inputPrecio.Text = precio.ToString();
            inputMarca.Text = marca;
            inputDescripcion.Text = descripcion;
            comboProveedor.SelectedIndex = buscarIndexProveedor(id_proveedor);
            comboCategoria.SelectedIndex = buscarIndexCategoria(id_categoria);
            btnGuardar.Text = "Actualizar";
        }


        public int buscarIndexProveedor(int id)
        {

            int i = 0; 
            foreach(var p in proveedores)
            {
                if (p.id == id) return i;
                i++;
            }
            return -1;
        }

        public int buscarIndexCategoria(int id)
        {

            int i = 0;
            foreach (var p in categorias)
            {
                if (p.id == id) return i;
                i++;
            }
            return -1;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombre = inputNombre.Text;
            int existencias = int.Parse(inputExistencia.Text);
            double precio = double.Parse(inputPrecio.Text);
            String marca = inputMarca.Text;
            String descripcion = inputDescripcion.Text;

            int id_proveedor = proveedores[comboProveedor.SelectedIndex].id;
            int id_categoria = categorias[comboCategoria.SelectedIndex].id;

            Producto p = new Producto(
                nombre, precio, existencias,
                marca, descripcion,
                id_proveedor, id_categoria
                );

            if (id == -1)
            {
                p.Guardar();
            }
            else
            {
                p.id = id;
                p.Actualizar();
            }

            this.Close();
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RegistroProductosForm_Load(object sender, EventArgs e)
        {

        }


        

    }
}
