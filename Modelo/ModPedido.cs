using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Modelo
{
    public class ModPedido : ConexionSQL
    {

        public int insertarid(Pedido pedido)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "INSERT INTO Pedidos (ID_Pedido,ID_Estado,ID_Cliente) " +
                                        "VALUES (@ID_Pedido,@ID_Estado,@ID_Cliente)";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Pedido", pedido.ID_Pedido);
                        cmd.Parameters.AddWithValue("@ID_Estado", pedido.ID_Estado);
                        cmd.Parameters.AddWithValue("@ID_Cliente", pedido.ID_Cliente);
                        cmd.ExecuteNonQuery();
                    }
                }
                return 1; // Completo correctamente
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Manejar la excepción de manera adecuada
                return -1; // Error en insertar datos
            }
        }

        public int CerrarPedido(Pedido pedido)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "UPDATE Pedidos SET Fecha = @Fecha, Importe = @Importe, Netos=@Netos," +
                                   "ID_Vendedor = @ID_Vendedor, ID_Cliente = @ID_Cliente, ID_Estado = @ID_Estado, MetodoPago = @MetodoPago " + // Incluir MetodoPago
                                   "WHERE ID_Pedido = @ID_Pedido;";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Pedido", pedido.ID_Pedido);
                        cmd.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                        cmd.Parameters.AddWithValue("@Importe", pedido.Importe);
                        cmd.Parameters.AddWithValue("@Netos", pedido.Netos);
                        cmd.Parameters.AddWithValue("@ID_Vendedor", pedido.ID_Vendedor);
                        cmd.Parameters.AddWithValue("@ID_Cliente", pedido.ID_Cliente);
                        cmd.Parameters.AddWithValue("@ID_Estado", pedido.ID_Estado);
                        cmd.Parameters.AddWithValue("@MetodoPago", pedido.MetodoPago); // Agregar el parámetro MetodoPago
                        cmd.ExecuteNonQuery();
                    }
                }
                return 1; // Completo correctamente
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Manejar la excepción de manera adecuada
                return -1; // Error al modificar datos
            }
        }

        public DataTable ArrancarPedido(DetallePedido detallePedido)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string queryBuscarPorID = $"SELECT * FROM DetallePedidos WHERE ID_Pedido = '{detallePedido.ID_Pedido}'";

                    using (SqlCommand cmd = new SqlCommand(queryBuscarPorID, cnn))
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

        public int RegistrarDetallePedido(DetallePedido detallePedido)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "INSERT INTO DetallePedidos (ID_Pedido,ID_Producto,Cantidad,PrecioVenta,CantidadPrecio) " +
                                        "VALUES (@ID_Compra,@ID_Producto,@Cantidad,@PrecioVenta,@CantidadPrecio)";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Compra", detallePedido.ID_Pedido);
                        cmd.Parameters.AddWithValue("@ID_Producto", detallePedido.ID_Producto);
                        cmd.Parameters.AddWithValue("@Cantidad", detallePedido.Cantidad);
                        cmd.Parameters.AddWithValue("@PrecioVenta", detallePedido.PrecioVenta);
                        cmd.Parameters.AddWithValue("@CantidadPrecio", detallePedido.CantidadPrecio);
                        cmd.ExecuteNonQuery();
                        return 1;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Manejar la excepción de manera adecuada
                return -1;
            }
        }

        public int EliminarDetallePedido(long detalleID)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "DELETE FROM DetallePedidos WHERE DetalleID = @DetalleID";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@DetalleID", detalleID);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Manejar la excepción de manera adecuada
                return -1; // Error al eliminar
            }
        }



        public long ObtenerUltimoDetalleID()
        {
            long ultimoID = 0;
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "SELECT ISNULL(MAX(DetalleID), 0) FROM DetallePedidos";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            ultimoID = Convert.ToInt64(result);
                        }
                    }
                }
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Error de conversión: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el último DetalleID: {ex.Message}");
            }
            return ultimoID;
        }

    }
}
