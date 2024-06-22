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

        public DataTable ObtenerComprasPorFechaYEstado(int DNI, DateTime fechaInicio, DateTime fechaFin, int estado)
        {
            try
            {
                // Obtener todas las compras del proveedor con el estado especificado
                DataTable todasLasCompras = ObtenerCompras(DNI, estado);

                // Filtrar las compras por fecha
                DataTable comprasFiltradas = todasLasCompras.Clone(); // Clonar la estructura del DataTable original

                foreach (DataRow row in todasLasCompras.Rows)
                {
                    DateTime fechaCompra = Convert.ToDateTime(row["Fecha"]);
                    if (fechaCompra >= fechaInicio && fechaCompra <= fechaFin)
                    {
                        comprasFiltradas.ImportRow(row); // Agregar la fila al DataTable de compras filtradas
                    }
                }

                return comprasFiltradas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public DataTable ObtenerInfoAuditoria()
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = @"
                SELECT 
                    A.ID,
                    A.DNI,
                    U.Nombre,
                    A.TimeLogin,
                    A.TimeLogout,
                    CONVERT(VARCHAR, DATEADD(SECOND, 
                        CASE 
                            WHEN A.TimeLogout IS NULL 
                                THEN DATEDIFF(SECOND, A.TimeLogin, GETDATE())
                            ELSE 
                                DATEDIFF(SECOND, A.TimeLogin, A.TimeLogout)
                        END, 0), 108) AS DuracionSesion
                FROM 
                    [TrabajoDeDiploma].[dbo].[Auditoria] A
                JOIN 
                    [TrabajoDeDiploma].[dbo].[Usuarios] U ON A.DNI = U.DNI
                ORDER BY 
                    A.TimeLogin DESC";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
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




        public DataTable ObtenerInfoAuditoriaPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
               
                DataTable todosAuditoria = ObtenerInfoAuditoria();

                // Filtrar las compras por fecha
                DataTable AuditoriaFiltrada = todosAuditoria.Clone(); // Clonar la estructura del DataTable original

                foreach (DataRow row in todosAuditoria.Rows)
                {
                    DateTime fechaLogin = Convert.ToDateTime(row["TimeLogin"]);
                    if (fechaLogin >= fechaInicio && fechaLogin <= fechaFin)
                    {
                        AuditoriaFiltrada.ImportRow(row); // Agregar la fila al DataTable de compras filtradas
                    }
                }

                return AuditoriaFiltrada;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public DataTable ObtenerDetallesAuditoria(string auditoriaID)
        {
            DataTable dataTable = new DataTable();
            string query = @"
          SELECT 
            DA.auditoriaID as 'ID Auditoria',
            DA.FechaOperacion as 'Fecha Operacion',
            P.Permiso as 'Operacion Realizado'
        FROM 
            [TrabajoDeDiploma].[dbo].[DetalleAuditoria] DA
        JOIN
            [TrabajoDeDiploma].[dbo].[Permisos] P ON DA.ID_Operacion = P.ID
        WHERE 
            DA.AuditoriaID = @AuditoriaID
    ";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AuditoriaID", auditoriaID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

    }
}
