using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    class Helpers
    {

        public static void LimpiarCampo(TextBox t)
        {
            t.Text = "";
        }

        public static String ObtenerTexto(TextBox t)
        {
            return t.Text;
        }

        public static void MostrarMensaje(String mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje");
        }

        public static void insertarEnCombo(ComboBox combo ,String[] items)
        {
            combo.Items.Clear();
            combo.Items.AddRange(items);
        }
        public static void formatGrid(DataGridView dataGridView1)
        {
            dataGridView1.RowHeadersWidthSizeMode =
           DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.AutoSizeColumnsMode =

                DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
