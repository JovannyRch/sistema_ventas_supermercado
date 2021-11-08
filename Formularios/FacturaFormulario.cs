using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios
{
    public partial class FacturaFormulario : Form
    {

        List<Cliente> clientes;
        List<Producto> productos;
        Cliente clienteSeleccionado = null;
        Producto productoSeleccionado = null;
        double total = 0.0;
        List<CompraItem> compras;
        int id_factura;

        public FacturaFormulario(int id)
        {
            this.id_factura = id;
            InitializeComponent();
            compras = new();
        }

        private void FacturaFormulario_Load(object sender, EventArgs e)
        {
            clientes = Cliente.GetAll();
            Helpers.insertarEnCombo(comboClientes, clientes.Select(c => c.nombre).ToArray());

            productos = Producto.GetAllWithCategoriaWithProveedorDisponibles();

            Helpers.insertarEnCombo(comboProducto, productos.Select(c => $"{c.nombre} / ${c.precio}").ToArray());
            inputCantidad.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            if (inputCantidad.Text == "" && productoSeleccionado == null && clienteSeleccionado == null)
            {

                Helpers.MostrarMensaje("Datos incompletos");
                return;
            }
            int cantidad = int.Parse(inputCantidad.Text);

            if (cantidad > productoSeleccionado.existencias){
                Helpers.MostrarMensaje("Cantidad no disponible, max: "+productoSeleccionado.existencias);
                return;
            }

            productos[comboProducto.SelectedIndex].existencias -= cantidad;
            productoSeleccionado.existencias -= cantidad;
            compras.Add(new CompraItem(productoSeleccionado, int.Parse(inputCantidad.Text)));
            actualizarDatos();
            inputCantidad.Text = "1";
            
        }

        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteSeleccionado = clientes[comboClientes.SelectedIndex];
        }

        private void comboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            productoSeleccionado = productos[comboProducto.SelectedIndex];
        }

        

        private void actualizarDatos()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Total", "Total");
            Helpers.formatGrid(dataGridView1);
            dataGridView1.Rows.Clear();

            total = 0.0;
            foreach (var c in compras)
            {
                dataGridView1.Rows.Add(c.producto.id, c.producto.nombre, c.cantidad, $"${productoSeleccionado.precio}", $"${c.total}");
                total += c.total;
            }

            labelTotal.Text = $"TOTAL: ${total}";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(compras.ToArray().Length == 0)
            {
                Helpers.MostrarMensaje("No hay compras agregadas");
                return;
            }

            DTO.Factura factura = new DTO.Factura(id_factura, clienteSeleccionado.id, total);
            factura.Guardar();

            foreach(var compra in compras){

                compra.producto.ActualizarExistencias(compra.cantidad);
                DTO.Venta venta = new DTO.Venta(id_factura, compra.producto.id, compra.cantidad);
                venta.Guardar();
            }

            this.Close();
        }
    }

    public class CompraItem
    {
        public Producto producto;
        public int cantidad;
        public double total;

        public CompraItem(Producto p, int cantidad) {
            this.producto = p;
            this.cantidad = cantidad;
            this.total = cantidad * p.precio;
        }
        
    }
}
