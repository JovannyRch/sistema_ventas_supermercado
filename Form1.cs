using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String correo = inputCorreo.Text;
            String pass = inputPass.Text;

            Usuario usuario = Usuario.Buscar(correo, pass);


            if (usuario != null)
            {
                inputCorreo.Text = "";
                inputPass.Text = "";

                this.Visible = false;
                var form = new InicioForm(usuario);
                form.ShowDialog();

                this.Visible = true;

            }
            else
            {
                MessageBox.Show("Credenciales no encontradas, revise sus datos", "Error");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Formularios.RegistroUsuario();

            form.ShowDialog();



        }
    }
}
