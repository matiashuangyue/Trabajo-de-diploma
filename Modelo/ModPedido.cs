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
                    string query = "INSERT INTO Pedidos (ID_Pedido,ID_Estado) " +
                                        "VALUES (@ID_Pedido,@ID_Estado)";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Pedido", pedido.ID_Pedido);
                        cmd.Parameters.AddWithValue("@ID_Estado", pedido.ID_Estado);
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

        public int RegistrarDetalleCompra(DetallePedido detallePedido)
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
    }
}
