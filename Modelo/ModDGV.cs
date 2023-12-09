using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
   
    public class ModDGV: ConexionSQL
    {
        public List<string> LoadNombreVendedor()
        {
            List<string> nombresProveedor = new List<string>();

            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "SELECT Nombre FROM Usuarios WHERE ID_Rol = 3";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Agregar cada nombre de proveedor a la lista
                            string nombreProveedor = reader["Nombre"].ToString();
                            nombresProveedor.Add(nombreProveedor);
                        }
                    }
                }

                return nombresProveedor; // Devuelve la lista de nombres de proveedores
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Manejar la excepción de manera adecuada
                return null; // En caso de error, puedes devolver null o una lista vacía, dependiendo de tus necesidades
            }
        }

    }
}
