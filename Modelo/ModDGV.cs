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
        public List<string> LoadNombreVendedor(int ID_ROL)
        {
            List<string> nombresProveedor = new List<string>();

            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "SELECT Nombre FROM Usuarios WHERE ID_Rol = @ID_Rol";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Rol", ID_ROL);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string nombreProveedor = reader["Nombre"].ToString();
                            nombresProveedor.Add(nombreProveedor);
                        }
                    }
                }

                return nombresProveedor; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; 
            }
        }

    }
}
