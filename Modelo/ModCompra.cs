﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Modelo
{
    public class ModCompra: ConexionSQL
    {
        public int CerrarCompra(Compra compra)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "UPDATE Compras SET Fecha = @Fecha, ImporteTotal = @ImporteTotal, " +
                                   "ID_Proveedor = @ID_Proveedor, DNI_Usuario = @DNI_Usuario, ID_Estado = @ID_Estado " +
                                   "WHERE ID_Compra = @ID_Compra;";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Compra", compra.ID_Compra);
                        cmd.Parameters.AddWithValue("@Fecha", compra.Fecha);
                        cmd.Parameters.AddWithValue("@ImporteTotal", compra.ImporteTotal);
                        cmd.Parameters.AddWithValue("@ID_Proveedor", compra.ID_Proveedor);
                        cmd.Parameters.AddWithValue("@DNI_Usuario", compra.DNI_Usuario);
                        cmd.Parameters.AddWithValue("@ID_Estado", compra.ID_Estado);
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
        public int insertarid (Compra compra)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "INSERT INTO Compras (ID_Compra,ID_Estado) " +
                                        "VALUES (@ID_Compra,@ID_Estado)";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Compra", compra.ID_Compra);
                        cmd.Parameters.AddWithValue("@ID_Estado", compra.ID_Estado);
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
        public int RegistrarDetalleCompra(DetalleCompra detalleCompra)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "INSERT INTO DetalleCompras (ID_Compra, ID_Producto, Cantidad, PrecioUnitario) " +
                                   "VALUES (@ID_Compra, @ID_Producto, @Cantidad, @PrecioUnitario)";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Compra", detalleCompra.ID_Compra);
                        cmd.Parameters.AddWithValue("@ID_Producto", detalleCompra.ID_Producto);
                        cmd.Parameters.AddWithValue("@Cantidad", detalleCompra.Cantidad);
                        cmd.Parameters.AddWithValue("@PrecioUnitario", detalleCompra.PrecioUnitario);
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

        public Tuple<int, Exception> paraverQuepasa(DetalleCompra detalleCompra)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string QueryDatosValidos = "insert into DetalleCompras ([ID_Compra])"
                         + "values ('" + detalleCompra.ID_Compra + "')";
                    using (SqlCommand cmd = new SqlCommand(QueryDatosValidos, cnn))
                    {
                        //cmd.Parameters.AddWithValue("@ID_Compra", detalleCompra.ID_Compra);
                        cmd.ExecuteNonQuery();
                        return Tuple.Create(1, (Exception)null); // Éxito, sin excepción
                    }
                }
            }
            catch (Exception ex)
            {
                // Devolver el código de error y la excepción
                return Tuple.Create(-1, ex);
            }
        }


        public int CambiarEstadoCompra(long ID_Compra, int nuevoEstado)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "UPDATE Compras SET ID_Estado = @nuevoEstado WHERE ID_Compra = @ID_Compra;";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Compra", ID_Compra);
                        cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
                        cmd.ExecuteNonQuery();
                    }
                }
                return 1; // Cambio de estado completado correctamente
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Manejar la excepción de manera adecuada
                return -1; // Error al cambiar el estado
            }
        }

        public int EliminarDetalleCompra(long idCompra, int idProducto)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "DELETE FROM DetalleCompras WHERE ID_Compra = @ID_Compra AND ID_Producto = @ID_Producto";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Compra", idCompra);
                        cmd.Parameters.AddWithValue("@ID_Producto", idProducto);
                        cmd.ExecuteNonQuery();
                    }
                }
                return 1; // Eliminado correctamente
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1; // Error al eliminar
            }
        }

        public List<DetalleCompra> ObtenerDetallesCompra(long idCompra)
        {
            List<DetalleCompra> detalles = new List<DetalleCompra>();

            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = @"SELECT dc.ID_Compra, dc.ID_Producto, p.Nombre AS NombreProducto, dc.Cantidad, dc.PrecioUnitario
                             FROM DetalleCompras dc
                             JOIN Productos p ON dc.ID_Producto = p.ID_Producto
                             WHERE dc.ID_Compra = @ID_Compra";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Compra", idCompra);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DetalleCompra detalle = new DetalleCompra
                                {
                                    ID_Compra = reader.GetInt64(0),
                                    ID_Producto = reader.GetInt32(1),
                                    NombreProducto = reader.GetString(2),
                                    Cantidad = reader.GetInt32(3),
                                    PrecioUnitario = reader.GetDecimal(4)
                                };
                                detalles.Add(detalle);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Manejar la excepción de manera adecuada
            }

            return detalles;
        }



    }
}
