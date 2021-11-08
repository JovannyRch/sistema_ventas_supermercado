using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal.Listas
{
    public partial class ProveedoresLista : Form
    {

        List<Proveedor> proveedores;
        public ProveedoresLista()
        {
            InitializeComponent();
        }

        private void ProveedoresLista_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            proveedores = Proveedor.GetAll();
            Helpers.formatGrid(dataGridView1);
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();


            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Dirección", "Dirección");
            dataGridView1.Columns.Add("Teléfono", "Teléfono");


            foreach (var c in proveedores)
            {
                dataGridView1.Rows.Add( c.nombre, c.direccion, c.telefono);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProveedoresForm form = new();

            form.ShowDialog();

            cargarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index == -1 || index >= proveedores.ToArray().Length) return;
            var item = proveedores[index];

            ProveedoresForm form = new ProveedoresForm();

            form.setDatos(item.id, item.nombre, item.direccion, item.telefono);

            form.ShowDialog();

            cargarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index == -1 || index >= proveedores.ToArray().Length) return;

            var item = proveedores[index];

            item.Eliminar();

            cargarDatos();
        }
    }
}
