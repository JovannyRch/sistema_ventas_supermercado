using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DTO
{
    class Pedido
    {

        private static Db db = new Db();
        public int id;
        public int id_proveedor;
        public int id_producto;
        public int cantidad;
        public String proveedor = "";
        public String producto = "";
        public String status = "NO ENTREGADO";
        public String fecha = "";

        public Pedido(int id_producto, int id_proveedor, int cantidad)
        {
            this.id_producto = id_producto;
            this.cantidad = cantidad;
            this.id_proveedor = id_proveedor;
        }

        public Pedido(int id_producto, int id_proveedor, int cantidad, String status, String fecha)
        {
            this.id_producto = id_producto;
            this.cantidad = cantidad;
            this.id_proveedor = id_proveedor;
            this.status = status;
            this.fecha = fecha;
        }


        public Boolean Guardar()
        {

            return db.Insert($"INSERT INTO pedidos" +
                "(id_producto, id_proveedor, cantidad) " +
                $"values('{id_producto}',{id_proveedor}, {cantidad})");

        }


        public static List<Pedido> GetAll()
        {

            List<Pedido> res = new List<Pedido>();
            List<Dictionary<String, String>> dataDb = db.QueryArray("SELECT * FROM pedidos");

            if (dataDb == null)
            {
                return res;
            }

            foreach (var item in dataDb)
            {
                res.Add(FromMap(item));
            }

            return res;
        }

        public static List<Pedido> GetAllWithProductoWithProveedor()
        {

            List<Pedido> res = new List<Pedido>();
            List<Dictionary<String, String>> dataDb = db.QueryArray("SELECT p.*, prod.nombre producto, prov.nombre proveedor FROM pedidos p inner join productos prod on p.id_producto = prod.id inner join proveedores prov on prov.id = p.id_proveedor");

            if (dataDb == null)
            {
                return res;
            }

            foreach (var item in dataDb)
            {

                var p = FromMap(item);
                p.producto = item["producto"];
                p.proveedor = item["proveedor"];
                res.Add(p);

            }

            return res;
        }



        private static Pedido FromMap(Dictionary<String, String> item)
        {

            var p = new Pedido(
                int.Parse(item["id_producto"]),
                int.Parse(item["id_producto"]),
                 int.Parse(item["cantidad"]),
                 item["status"],
                 item["fecha"]
             );
            p.id = int.Parse(item["id"]);

            return p;
        }

        public Boolean ActualizarStatus()
        {
            return db.Query($"UPDATE pedidos SET " +
                $"status='ENTREGADO' " +
                $"where id={id}");
        }

        public Boolean Eliminar()
        {
            return db.Query($"DELETE from pedidos where id = {id}");
        }
    }
}
