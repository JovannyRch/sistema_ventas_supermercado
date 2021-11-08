using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DTO
{
    public class Venta
    {

        public int id;
        public int id_factura;
        public int id_producto;
        public int cantidad;
        private static Db db = new Db();

        public Venta(int id_factura, int id_producto, int cantidad)
        {
            this.id_factura = id_factura;
            this.id_producto = id_producto;
            this.cantidad = cantidad;
        }

        public Boolean Guardar()
        {

            return db.Insert($"INSERT INTO ventas(id_factura, id_producto, cantidad) values('{id_factura}','{id_producto}','{cantidad}')");

        }


    }
}
