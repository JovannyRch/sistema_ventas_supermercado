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
    public partial class InicioForm : Form
    {

        RegistroProductosForm registroProductos;
        Usuario usuario;
        public InicioForm(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnRegistroProductos_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void InicioForm_Load(object sender, EventArgs e)
        {
            this.labelUsuario.Text = "USUARIO: " + usuario.email;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new CategoriasLista();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new Listas.ClientesLista();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Listas.ProveedoresLista();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new Listas.ProductosLista();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new OtrasPantallas.PedidosProveedores();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new OtrasPantallas.Facturas();
            form.ShowDialog();
        }
    }
}
