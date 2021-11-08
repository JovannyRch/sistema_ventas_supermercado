using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProyectoFinal
{
    class Cliente
    {
        private static Db db = new Db();
        public int id;
        public String nombre;
        public String direccion;
        public String telefono;

        public Cliente(int id, String nombre, String direccion, String telefono){
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public Cliente(String nombre, String direccion, String telefono){
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        private static Cliente FromMap(Dictionary<String, String> item)
        {
            var res = new Cliente(int.Parse(item["id"]), item["nombre"], item["direccion"],item["telefono"]);
            return res;
        }

        public static List<Cliente> GetAll()
        {

            List<Cliente> res = new List<Cliente>();
            List<Dictionary<String, String>> dataDb = db.QueryArray("SELECT * FROM clientes order by nombre");

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
            var query = $"INSERT INTO clientes(nombre, direccion, telefono) values('{nombre}',{direccion}, {telefono})";
            Debug.WriteLine(query);
            return db.Insert(query);
        }

        public Boolean Actualizar()
        {
            return db.Query($"UPDATE clientes SET nombre='{nombre}', direccion='{direccion}', telefono='{telefono}' where id={id}");
        }

        public Boolean Eliminar()
        {
            return db.Query($"DELETE from clientes where id = {id}");
        }


    }
}
