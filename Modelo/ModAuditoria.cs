using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Modelo
{
    public class ModAuditoria : ConexionSQL
    {

        public void RegistrarLogin(int dni)
        {
            string queryUsuario = "SELECT Nombre FROM [TrabajoDeDiploma].[dbo].[Usuarios] WHERE DNI = @DNI";
            string nombreUsuario = "";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand commandUsuario = new SqlCommand(queryUsuario, connection);
                commandUsuario.Parameters.AddWithValue("@DNI", dni);
                connection.Open();

                SqlDataReader reader = commandUsuario.ExecuteReader();
                if (reader.Read())
                {
                    nombreUsuario = reader["Nombre"].ToString();
                }
                reader.Close();

                string query = @"
            INSERT INTO Auditoria (Usuario, TiempoLogin, Operacion, FechaOperacion)
            VALUES (@Usuario, GETDATE(), 'Login', GETDATE())
        ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", nombreUsuario);
                command.ExecuteNonQuery();
            }
        }





    }
}
