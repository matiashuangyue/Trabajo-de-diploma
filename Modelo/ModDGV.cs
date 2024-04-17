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


        public DataTable ObtenerPedidosPorFecha(int DNI, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                // Obtener todos los pedidos del vendedor
                DataTable todosLosPedidos = ObtenerPedidos(DNI);

                // Filtrar los pedidos por fecha
                DataTable pedidosFiltrados = todosLosPedidos.Clone(); // Clonar la estructura del DataTable original

                foreach (DataRow row in todosLosPedidos.Rows)
                {
                    DateTime fechaPedido = Convert.ToDateTime(row["Fecha"]);
                    if (fechaPedido >= fechaInicio && fechaPedido <= fechaFin)
                    {
                        pedidosFiltrados.ImportRow(row); // Agregar la fila al DataTable de pedidos filtrados
                    }
                }

                return pedidosFiltrados;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Manejar la excepción de manera adecuada
                return null; // Error al obtener pedidos por fecha
            }
        }


        public DataTable ObtenerPedidos(int DNI)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string queryBuscarPorDNI = $"SELECT * FROM Pedidos WHERE ID_Vendedor = '{DNI}'";

                    using (SqlCommand cmd = new SqlCommand(queryBuscarPorDNI, cnn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Crear un DataTable y llenarlo con los datos leídos
                                DataTable dataTable = new DataTable();
                                dataTable.Load(reader);
                                return dataTable;
                            }
                        }
                    }
                }

                // Si no se encuentra el pedido, puedes retornar un DataTable vacío o null según tu lógica
                return new DataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Manejar la excepción de manera adecuada
                return null; // Error al modificar datos
            }
        }


        public DataTable ObtenerCompras(int DNI,int Estado)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string queryBuscarPorDNI = "SELECT * FROM Compras WHERE ID_Proveedor = @ID_Proveedor AND ID_Estado = @ID_Estado";

                    using (SqlCommand cmd = new SqlCommand(queryBuscarPorDNI, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Proveedor", DNI);
                        cmd.Parameters.AddWithValue("@ID_Estado", Estado);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Crear un DataTable y llenarlo con los datos leídos
                                DataTable dataTable = new DataTable();
                                dataTable.Load(reader);
                                return dataTable;
                            }
                        }
                    }
                }

                // Si no se encuentra el pedido, puedes retornar un DataTable vacío o null según tu lógica
                return new DataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Manejar la excepción de manera adecuada
                return null; // Error al modificar datos
            }
        }

    }
}
