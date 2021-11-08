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
    public partial class ClientesLista : Form
    {

        List<Cliente> clientes;
        public ClientesLista()
        {
            InitializeComponent();
        }

        private void ClientesLista_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            clientes = Cliente.GetAll();
            Helpers.formatGrid(dataGridView1);

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();


            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Dirección", "Dirección");
            dataGridView1.Columns.Add("Teléfono", "Teléfono");


            foreach (var c in clientes)
            {
                dataGridView1.Rows.Add( c.nombre, c.direccion, c.telefono);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientesForm form = new();

            form.ShowDialog();

            cargarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index == -1 || index >= clientes.ToArray().Length) return;
            var item = clientes[index];

            var form = new ClientesForm();

            form.setDatos(item.id, item.nombre, item.direccion, item.telefono);

            form.ShowDialog();

            cargarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index == -1 || index >= clientes.ToArray().Length) return;

            var item = clientes[index];

            item.Eliminar();

            cargarDatos();
        }
    }
}
