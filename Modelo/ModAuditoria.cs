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

        public string RegistrarLogin(int dni)
        {
            string id = DateTime.Now.ToString("yyyyMMddHHmmssfff"); // Crear una cadena única basada en el tiempo actual

            using (SqlConnection connection = GetConnection())
            {
                string query = @"
            INSERT INTO Auditoria (ID, DNI, TimeLogin)
            VALUES (@ID, @DNI, GETDATE())
        ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@DNI", dni);
                connection.Open();
                command.ExecuteNonQuery();
            }

            return id;
        }

        public void RegistrarLogout(string auditoriaId)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = @"
            UPDATE Auditoria
            SET TimeLogout = GETDATE()
            WHERE ID = @AuditoriaID AND TimeLogout IS NULL
        ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AuditoriaID", auditoriaId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void RegistrarOperacion(string auditoriaId, int dni, string operacion)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = @"
            INSERT INTO DetalleAuditoria (AuditoriaID, DNI, ID_Operacion, FechaOperacion)
            VALUES (
                @AuditoriaID,
                @DNI,
                (SELECT ID FROM Permisos WHERE Permiso = @Operacion),
                GETDATE()
            )
        ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AuditoriaID", auditoriaId);
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@Operacion", operacion);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }





    }
}
