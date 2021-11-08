using System;
using System.Collections.Generic;
using System.Diagnostics;
using MySqlConnector;

namespace ProyectoFinal
{
    public class Usuario
    {


        public int id;
        public String email;
        private String pass = "";

        private static Db db = new();

        public Usuario(int id, String email)
        {
            this.id = id;
            this.email = email;
        }
        public static Boolean Crear(String email, String password)
        {

            Usuario usuario = Buscar(email, password);

            if(usuario == null)
            {
                Debug.WriteLine("Usuario no encontrado");
                return db.Insert($"INSERT INTO usuarios(email, pass) value ('{email}','{password}')");
            }
            else
            {
                Debug.WriteLine("Usuario repetido "+ usuario.email);
            }


            return false;
        }


        public static Usuario Buscar(String email, String password)
        {
            String query = $"SELECT * FROM usuarios where email = '{email}' and pass = '{password}'";
            Debug.WriteLine(query);
            Dictionary<String, String> res = db.QueryRow(query);
           

            if (res == null)
            {
                return null;
            }

            int id = int.Parse(res["id"]);
            String mail = res["email"];
            return new Usuario(id, mail);
        }
    }

}
