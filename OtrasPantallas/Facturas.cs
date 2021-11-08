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
    public partial class Facturas : Form
    {

        List<DTO.Factura> lista;
        public Facturas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            if(lista.ToArray().Length == 0)
            {
                id = 1;
            }
            else
            {
                id = lista.Last().id + 1;
            }

            Formularios.FacturaFormulario form = new(id);

            form.ShowDialog();

            cargarDatos();

        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            lista = DTO.Factura.GetAllWithCliente();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            Helpers.formatGrid(dataGridView1);
            dataGridView1.RowHeadersWidthSizeMode =
           DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Add("id", "Id Factura");
            dataGridView1.Columns.Add("Cliente", "Cliente");
            dataGridView1.Columns.Add("Total", "Total");
            dataGridView1.Columns.Add("Fecha", "Fecha");


            foreach (var item in lista)
            {
                dataGridView1.Rows.Add(item.id, item.cliente, "$"+item.total, item.fecha);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index == -1 || index >= lista.ToArray().Length) return;
            var item = lista[index];

            item.Eliminar();
            cargarDatos();
        }
    }
}
