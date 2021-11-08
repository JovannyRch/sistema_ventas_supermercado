using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Listas
{
    public partial class ProductosLista : Form
    {

        List<Producto> productos;
        public ProductosLista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new RegistroProductosForm();
            form.ShowDialog();


        }

        private void ProductosLista_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void cargarDatos()
        {

            productos = Producto.GetAllWithCategoriaWithProveedor();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            Helpers.formatGrid(dataGridView1);
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Existencias", "Existencias");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Marca", "Marca");
            dataGridView1.Columns.Add("Descripcion", "Descripcion");
            dataGridView1.Columns.Add("Proveedor", "Proveedor");
            dataGridView1.Columns.Add("Categoría", "Categoría");



            foreach (var item in productos)
            {
                dataGridView1.Rows.Add(item.nombre, item.descripcion, $"${item.precio}", item.marca, item.descripcion, item.proveedor, item.categoria);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int index = dataGridView1.CurrentRow.Index;
            if (index == -1 || index >= productos.ToArray().Length) return;
            var item = productos[index];

            var form = new RegistroProductosForm();
            form.setDatos(item.id, item.nombre, item.existencias, item.precio, item.marca, item.descripcion, item.id_proveedor, item.id_categoria);
            form.ShowDialog();
            cargarDatos();
        }
    }
}
