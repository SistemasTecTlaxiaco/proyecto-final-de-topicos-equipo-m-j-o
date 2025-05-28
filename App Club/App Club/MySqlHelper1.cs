using System;
using MySqlConnector;
using System.Data;

namespace MySqlHelper1
{
	public class MySqlHelper
	{

		public void MySqlConnector()
		{

		}


		public MySqlConnection GetSqlConnection()
		{
			var builder = new MySqlConnectionStringBuilder
			{
				Server = "127.0.0.1",
				UserID = "root",
				Password = "SOCD0501",
				Database = "appclub",


			};
			return new MySqlConnection(builder.ConnectionString);
		}

        public Alumno Getnumcontrol(int numcontrol)
        {
            var sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            var command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT * FROM Alumno WHERE numcontrol = @numcontrol LIMIT 1";
            command.Parameters.AddWithValue("@numcontrol", numcontrol);

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            Alumno resultado = null;

            if (reader.Read())
            {
                resultado = new Alumno
                {
                    numcontrol = reader.GetInt32("numcontrol"),
                    contraseña = reader.GetString("contraseña"),
                    nombreComp = reader.GetString("nombreComp"),
                    carrera = reader.GetString("carrera")
                };
            }

            return resultado;
        }

    }
}
