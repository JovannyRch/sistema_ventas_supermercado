using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Categoria
    {

        public int id;
        private static Db db = new Db();
        public String nombre;
        public String descripcion;

        public Categoria(int id, String nombre, String descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }


        public Categoria(String nombre, String descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }


        private static Categoria FromMap(Dictionary<String, String> item)
        {
            var res = new Categoria(int.Parse(item["id"]), item["nombre"], item["descripcion"]);
            return res;
        }

        public static List<Categoria> GetAll()
        {

            List<Categoria> res = new List<Categoria>();
            List<Dictionary<String, String>> dataDb = db.QueryArray("SELECT * FROM categorias order by nombre");

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

            return db.Insert($"INSERT INTO categorias(nombre, descripcion) values('{nombre}','{descripcion}')");

        }

        public Boolean Eliminar()
        {


            return db.Query($"DELETE from categorias where id = {id}");
        }

        public Boolean Actualizar()
        {

            return db.Query($"UPDATE categorias SET nombre='{nombre}', descripcion='{descripcion}' where id={id}");
        }

    }
}
