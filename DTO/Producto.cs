using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Producto
    {


        private static Db db = new Db();
        public String nombre;
        public double precio;
        public int existencias;
        public int id;
        public String marca;
        public String descripcion;
        public int id_proveedor;
        public int id_categoria;

        public String categoria = "";
        public String proveedor = "";

        public Producto(String nombre, double precio, int existencias, String marca, String descripcion, int id_proveedor, int id_categoria)
        {

            this.nombre = nombre;
            this.precio = precio;
            this.existencias = existencias;

            this.marca = marca;
            this.descripcion = descripcion;

            this.id_proveedor = id_proveedor;
            this.id_categoria = id_categoria;

        }

        public Boolean Guardar()
        {

            return db.Insert($"INSERT INTO productos" +
                "(nombre, precio, existencias, marca, descripcion, id_proveedor, id_categoria) "+
                $"values('{nombre}',{precio}, {existencias},'{marca}', '{descripcion}', {id_proveedor},{id_categoria})");

        }


        public static List<Producto> GetAll()
        {
            
            List<Producto> res = new List<Producto>();
            List<Dictionary<String, String>> dataDb = db.QueryArray("SELECT * FROM productos");

            if(dataDb == null)
            {
                return res;
            }

            foreach (var item in dataDb) {
                res.Add(FromMap(item));
            }

            return res; 
         }

        public static List<Producto> GetAllDisponibles()
        {

            List<Producto> res = new List<Producto>();
            List<Dictionary<String, String>> dataDb = db.QueryArray("SELECT * FROM productos where existencias != 0");

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

        public static List<Producto> GetAllWithCategoriaWithProveedor()
        {

            List<Producto> res = new List<Producto>();
            List<Dictionary<String, String>> dataDb = db.QueryArray("SELECT p.*, c.nombre categoria, pro.nombre proveedor " +
                "FROM productos p inner join categorias c on c.id = p.id_categoria " +
                "inner join proveedores pro on pro.id = p.id_proveedor ");

            if (dataDb == null)
            {
                return res;
            }

            foreach (var item in dataDb)
            {

                var p = FromMap(item);
                p.categoria = item["categoria"];
                p.proveedor = item["proveedor"];
                res.Add(p);

            }

            return res;
        }

        public static List<Producto> GetAllWithCategoriaWithProveedorDisponibles()
        {

            List<Producto> res = new List<Producto>();
            List<Dictionary<String, String>> dataDb = db.QueryArray("SELECT p.*, c.nombre categoria, pro.nombre proveedor " +
                "FROM productos p inner join categorias c on c.id = p.id_categoria " +
                "inner join proveedores pro on pro.id = p.id_proveedor  where p.existencias != 0");

            if (dataDb == null)
            {
                return res;
            }

            foreach (var item in dataDb)
            {

                var p = FromMap(item);
                p.categoria = item["categoria"];
                p.proveedor = item["proveedor"];
                res.Add(p);

            }

            return res;
        }



        private static Producto FromMap(Dictionary<String, String> item)
        {

            var p = new Producto(
                item["nombre"], 
                double.Parse(item["precio"]), 
                int.Parse(item["existencias"]),
                item["marca"],
                item["descripcion"],
                int.Parse(item["id_proveedor"] ),
                int.Parse(item["id_categoria"])
             );
            p.id = int.Parse(item["id"]);

            return p;
        }

        public Boolean Actualizar()
        {

            return db.Query($"UPDATE productos SET " +
                $"nombre='{nombre}', " +
                $"precio={precio}, " +
                $"existencias={existencias}, " +
                $"marca='{marca}', " +
                $"descripcion='{descripcion}', " +
                $"id_proveedor={id_proveedor}, " +
                $"id_categoria={id_categoria} " +
                $"where id={id}");
        }

        public Producto GetById(int id)
        {
            return Producto.FromMap(db.QueryRow($"SELECT * from productos where id = {id}"));
        }
        public Boolean ActualizarExistencias(int cantidad)
        {
            Producto p = GetById(id);
            int actualizacion = p.existencias - cantidad;
            return db.Query($"UPDATE productos SET " +
                $"existencias={actualizacion} " +
                $"where id={id}");
        }

        public Boolean Eliminar()
        {
            return db.Query($"DELETE from productos where id = {id}");
        }

    }
}
