using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Club
{
    internal class MySQLHelper
    {
        public void MySqlConnector()
        {

        }


        public MySqlConnection GetSqlConnection()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                Port = 3307,
                UserID = "root",
                Password = "SOCD0501",
                Database = "appclub",


            };
            return new MySqlConnection(builder.ConnectionString);
        }

        public Alumno GetAlumnoPorCredenciales(string numcontrol, string contraseñaEncriptada)
        {
            var sqlConnection = GetSqlConnection();
            sqlConnection.Open();

            var command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT * FROM Alumno WHERE numcontrol = @numcontrol AND contraseña = @contraseña LIMIT 1";
            command.Parameters.AddWithValue("@numcontrol", numcontrol);
            command.Parameters.AddWithValue("@contraseña", contraseñaEncriptada);

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            Alumno resultado = null;

            if (reader.Read())
            {
                resultado = new Alumno
                {
                    numcontrol = reader.GetString("numcontrol"),
                    contraseña = reader.GetString("contraseña"),
                    nombreComp = reader.GetString("nombreComp"),
                    carrera = reader.GetString("carrera")
                };
            }

            return resultado;
        }


        public bool InsertarRegistro(string numcontrol, string nombreComp, string carrera, string club)
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO registro (numcontrol, nombreComp, carrera, club)
                                VALUES (@numcontrol, @nombreComp, @carrera, @club)";
                command.Parameters.AddWithValue("@numcontrol", numcontrol);
                command.Parameters.AddWithValue("@nombreComp", nombreComp);
                command.Parameters.AddWithValue("@carrera", carrera);
                command.Parameters.AddWithValue("@club", club);

                int filasAfectadas = command.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

    }
}
