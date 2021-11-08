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

namespace ProyectoFinal.Formularios
{
    public partial class PedidosForm : Form
    {

        List<Producto> productos;
        List<Proveedor> proveedores;
        Producto productoSeleccionado = null;

        public PedidosForm()
        {
            InitializeComponent();
        }

        private void comboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            productoSeleccionado = productos[comboProductos.SelectedIndex];
            int id_proveedor = productoSeleccionado.id_proveedor;
            Proveedor p = Proveedor.BuscarPorId(proveedores, id_proveedor);
            labelProveedor.Text = $"Proveedor: {p.nombre}";
        }


        private void PedidosForm_Load(object sender, EventArgs e)
        {
            productos = Producto.GetAll();
            proveedores = Proveedor.GetAll();


            Helpers.insertarEnCombo(comboProductos, productos.Select(c => c.nombre).ToArray());

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(productoSeleccionado != null)
            {
                int cantidad = int.Parse(textBox1.Text);
                Pedido p = new Pedido(productoSeleccionado.id, productoSeleccionado.id_proveedor, cantidad);
                p.Guardar();
                this.Close();
            }
        }
    }


}
