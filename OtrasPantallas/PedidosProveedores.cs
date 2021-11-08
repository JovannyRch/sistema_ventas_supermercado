using ProyectoFinal.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.OtrasPantallas
{
    public partial class PedidosProveedores : Form
    {


        List<Pedido> pedidos;

        public PedidosProveedores()
        {
            InitializeComponent();
        }

        

        private void PedidosProveedores_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Formularios.PedidosForm();

            form.ShowDialog();
            cargarDatos();
        }


        private void cargarDatos()
        {
            pedidos = Pedido.GetAllWithProductoWithProveedor();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            Helpers.formatGrid(dataGridView1);

            dataGridView1.Columns.Add("id", "Id Pedido");
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Proveedor", "Proveedor");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Status", "Status");
            dataGridView1.Columns.Add("Fecha", "Fecha");


            foreach (var item in pedidos)
            {
                dataGridView1.Rows.Add(item.id, item.producto, item.proveedor, item.cantidad, item.status, item.fecha);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index == -1 || index >= pedidos.ToArray().Length) return;
            var item = pedidos[index];

            item.ActualizarStatus();

            cargarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index == -1 || index >= pedidos.ToArray().Length) return;
            var item = pedidos[index];

            item.Eliminar();

            cargarDatos();
        }
    }
}
