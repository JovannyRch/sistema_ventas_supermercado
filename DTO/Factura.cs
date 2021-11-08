using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DTO
{
    public class Factura
    {

        public int id;
        private static Db db = new Db();
        public double total = 0.0;
        public String fecha = "";
        public String cliente = "";
        public int id_cliente;

        public Factura(int id, int id_cliente, double total)
        {
            this.id = id;
            this.id_cliente = id_cliente;
            this.total = total;
        }

        public Boolean Guardar()
        {

            return db.Insert($"INSERT INTO facturas" +
                "(id, id_cliente, total) " +
                $"values({id},{id_cliente}, {total})");

        }


        public static List<Factura> GetAll()
        {

            List<Factura> res = new List<Factura>();
            List<Dictionary<String, String>> dataDb = db.QueryArray("SELECT * FROM facturas");

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

        public static List<Factura> GetAllWithCliente ()
        {

            List<Factura> res = new List<Factura>();
            List<Dictionary<String, String>> dataDb = db.QueryArray("SELECT f.*, c.nombre cliente from facturas f inner join clientes c on c.id = f.id_cliente");

            if (dataDb == null)
            {
                return res;
            }

            foreach (var item in dataDb)
            {

                var p = FromMap(item);
                p.fecha = item["fecha"];
                p.cliente = item["cliente"];
                res.Add(p);

            }

            return res;
        }



        private static Factura FromMap(Dictionary<String, String> item)
        {

            var p = new Factura(
                int.Parse(item["id"]),
                int.Parse(item["id_cliente"]),
                double.Parse(item["total"])
             );
            p.fecha = item["fecha"];

            return p;
        }

    
        public Boolean Eliminar()
        {
            return db.Query($"DELETE from facturas where id = {id}");
        }
    }
}
