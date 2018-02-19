using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Examen
{
    public class DataBaseLogger : ILogger
    {
        public void LogMensaje(string mensaje, Seguridad SeguridadLevel)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Logger"].ConnectionString;
            
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string CodigodeNivel = (((int)SeguridadLevel) + 1).ToString();

                string query = "INSERT INTO LOG(Mensaje, CodigodeNivel, FechaCreacion) VALUES(@Mensaje, @CodigodeNivel, @FechaCreacion)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("Mensaje", mensaje);
                command.Parameters.AddWithValue("CodigodeNivel", CodigodeNivel);
                command.Parameters.AddWithValue("FechaCreacion", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }
    }
}
