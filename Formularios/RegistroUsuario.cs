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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String correo = inputCorreo.Text;
            String pass = inputContrasenia.Text;

            Usuario usuario = Usuario.Buscar(correo, pass);

            if(usuario != null)
            {

                Helpers.MostrarMensaje("Usuario ya registrado, intente con otro usuario");
                return;
            }

            if(Usuario.Crear(correo, pass))
            {
                Helpers.MostrarMensaje("Usuario creado exitosamente");
                this.Close();
            }
            else
            {
                Helpers.MostrarMensaje("Ocurrió un error al registrar el usuario");
            }


        }
    }
}
