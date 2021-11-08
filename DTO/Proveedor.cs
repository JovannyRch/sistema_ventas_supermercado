using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Proveedor
    {
        private static Db db = new Db();
        public int id;

        public String nombre;
        public String direccion;
        public String telefono;

        public Proveedor(int id, String nombre, String direccion, String telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public Proveedor(String nombre, String direccion, String telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        private static Proveedor FromMap(Dictionary<String, String> item)
        {
            var res = new Proveedor(int.Parse(item["id"]), item["nombre"], item["direccion"], item["telefono"]);
            return res;
        }

        public static List<Proveedor> GetAll()
        {

            List<Proveedor> res = new List<Proveedor>();
            List<Dictionary<String, String>> dataDb = db.QueryArray("SELECT * FROM proveedores order by nombre");

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

        public Boolean Guardar()
        {

            return db.Insert($"INSERT INTO proveedores(nombre, direccion, telefono) values('{nombre}',{direccion}, {telefono})");

        }

        public Boolean Actualizar()
        {

            return db.Query($"UPDATE proveedores SET nombre='{nombre}', direccion='{direccion}', telefono='{telefono}' where id={id}");
        }

        public Boolean Eliminar()
        {
            return db.Query($"DELETE from proveedores where id = {id}");
        }

        public static Proveedor BuscarPorId(List<Proveedor> data, int id)
        {

            foreach(var p in data){
                if (p.id == id) return p;
            }


            return null;

        }
    }
}
