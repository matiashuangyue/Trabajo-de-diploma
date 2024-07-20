using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Modelo
{
    public class ModProducto: ConexionSQL
    {
        public bool NoExisteCodigo(Producto producto)
        {
           

            try
            {

                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Codigo FROM Productos where Codigo ='" + producto.Codigo + "'", conn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            conn.Close();
                            return false;//existe en base de datos
                        }
                        else
                        {
                            conn.Close();
                            return true;// no existe en base de datos
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Producto buscarProductoPorCodigo(Producto producto)
        {
            Producto productoEncontrado = null;
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    String queryBuscarPorCodigo = "select * from Productos where Codigo = '" + producto.Codigo + "'";
                    using (SqlCommand cmd = new SqlCommand(queryBuscarPorCodigo, cnn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productoEncontrado = new Producto
                                {
                                    Codigo = Convert.ToInt32(reader["Codigo"]),
                                    Name = reader["Nombre"].ToString(),
                                    Descripcion = reader["Descripcion"].ToString(),
                                    Price = Convert.ToDecimal(reader["Precio"]),
                                    Stock = Convert.ToInt32(reader["Stock"]),
                                    ID_Estado = Convert.ToInt32(reader["ID_Estado"]),
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Maneja la excepción según tus necesidades
            }

            return productoEncontrado;
        }

        public List<Producto> BuscarProductosPorNombre(string nombre)
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    String queryBuscarPorNombre = "SELECT * FROM Productos WHERE Nombre LIKE @Nombre";
                    using (SqlCommand cmd = new SqlCommand(queryBuscarPorNombre, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Producto producto = new Producto
                                {
                                    Codigo = Convert.ToInt32(reader["Codigo"]),
                                    Name = reader["Nombre"].ToString(),
                                    Descripcion = reader["Descripcion"].ToString(),
                                    Price = Convert.ToDecimal(reader["Precio"]),
                                    Stock = Convert.ToInt32(reader["Stock"]),
                                    ID_Estado = Convert.ToInt32(reader["ID_Estado"]),
                                };
                                productos.Add(producto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Maneja la excepción según tus necesidades
            }

            return productos;
        }


        public int agregarProducto(Producto producto)
        {
           
                if (NoExisteCodigo(producto) == true)
                {
                    try
                    {
                        using (var cnn = GetConnection())
                        {
                            cnn.Open();
                            String QueryDatosValidos = "insert into Productos ([Codigo],[Nombre],[Descripcion],[Precio],[Stock],[ID_Estado])"
                           + "values ('" + producto.Codigo + "','" + producto.Name + "','" + producto.Descripcion + "','" + producto.Price + "','" + producto.Stock + "','" + producto.ID_Estado + "')";
                            using (SqlCommand cmd = new SqlCommand(QueryDatosValidos, cnn))
                            {
                                cmd.ExecuteNonQuery();
                                cnn.Close();
                            }
                            return 1;// se ha añadido al sql correctamente
                        }
                    }
                    catch (Exception ex)
                    {
                        return -2;//error al insertar datos en sql
                    }
                }
                else { return -1; }//ya existe codigo de producto en base de datos
        }
       

        public int modificarProducto(Producto producto)
        {
            if (NoExisteCodigo(producto) == false)
            {
                try
                {
                    using (var cnn = GetConnection())
                    {
                        cnn.Open();
                        String queryDatosValidos = "update Productos set " +
                                                  "Nombre = @Nombre, " +
                                                  "Descripcion = @Descripcion, " +
                                                  "Precio = @Precio, " +
                                                  "Stock = @Stock ," +
                                                  "ID_Estado = @ID_Estado " +
                                                  "where Codigo = @Codigo";

                        using (SqlCommand cmd = new SqlCommand(queryDatosValidos, cnn))
                        {
                            // Utiliza parámetros para evitar la inyección de SQL
                            cmd.Parameters.AddWithValue("@Nombre", producto.Name);
                            cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                            cmd.Parameters.AddWithValue("@Precio", producto.Price);
                            cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                            cmd.Parameters.AddWithValue("@ID_Estado", producto.ID_Estado);
                            cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);

                            cmd.ExecuteNonQuery();
                            cnn.Close();
                        }
                        return 1; // se ha modificado en SQL correctamente
                    }
                }
                catch (Exception ex)
                {
                    return -2; // error al modificar datos en SQL
                }
            }
            else
            {
                return -1; // no se puede modificar porque el código no es válido
            }
        }

        public int eliminarProducto(Producto producto)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    String queryEliminarProducto = "UPDATE Productos SET ID_Estado = 0 WHERE Codigo = @Codigo";

                    using (SqlCommand cmd = new SqlCommand(queryEliminarProducto, cnn))
                    {
                        // Utiliza parámetros para evitar la inyección de SQL
                        cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            cnn.Close();
                            return 1; // se ha cambiado el estado del producto correctamente
                        }
                        else
                        {
                            cnn.Close();
                            return -1; // no se encontró el producto con el código dado
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return -2; // error al actualizar datos en SQL
            }
        }



    }
}
