

using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProyectoFinal
{
    class Db
    {
        MySqlConnectionStringBuilder builder;
        private MySqlConnection conexion;
        public Db()
        {
           try
            {
                builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.Database = "supermercado";
                builder.UserID = "root";
                builder.Password = "";
                builder.Port = 3306;
                builder.ApplicationName = "app1";

                Console.WriteLine(builder.ConnectionString);
                this.conexion = new MySqlConnection(builder.ConnectionString);
                this.conexion.Ping();
            }
            catch (Exception e) 
            {
                Debug.WriteLine("Error en la conexión a la base de datos: " + e.ToString());
            }

        }


        public Boolean Insert(String query)
        {
            try
            {
                conexion.Open();
                MySqlCommand command = new MySqlCommand(query, conexion);
                command.ExecuteReader();
                conexion.Close();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error al insertar");
                conexion.Close();
                Debug.WriteLine(e.ToString());
                return false;
            }
        }


        public Dictionary<String, String> QueryRow(String query)
        {

            Dictionary<String, String> res = new Dictionary<string, string>();
            try
            {
                conexion.Open();
                MySqlCommand command = new MySqlCommand(query, conexion);

                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    String columnName = reader.GetName(i);
                    String data = reader[columnName].ToString();
                    res[columnName] = data;
                }
                conexion.Close();
                return res;
            }
            catch (Exception e)
            {
                conexion.Close();
                Debug.WriteLine("Error en la consulta");
                Debug.WriteLine(e.ToString());
            }
            return null;
        }


        public bool Query(String query)
        {
            Debug.WriteLine(query);
            Dictionary<String, String> res = new Dictionary<string, string>();
            try
            {
                conexion.Open();
                MySqlCommand command = new MySqlCommand(query, conexion);

                command.ExecuteReader();
                conexion.Close();
                return true;
            }
            catch (Exception e)
            {
                conexion.Close();
                Debug.WriteLine("Error en el query");
                Debug.WriteLine(e.ToString());

                return true;
            }
        }

        public List<Dictionary<String, String>> QueryArray(String query)
        {
            Debug.WriteLine(query);
            List<Dictionary<String, String>> res = new();
            try
            {
                conexion.Open();
                MySqlCommand command = new MySqlCommand(query, conexion);

                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {

                    var item = new Dictionary<string, string>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        String columnName = reader.GetName(i);
                        String data = reader[columnName].ToString();
                        item[columnName] = data;
                    }
                    res.Add(item);
                }
                
                conexion.Close();
                return res;
            }
            catch (Exception e)
            {
                conexion.Close();
                Debug.WriteLine("Error en la consulta");
                Debug.WriteLine(e.ToString());
            }
            return null;
        }


    }
}
