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
        public bool IsValidCodigo(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Codigo.ToString()))
                return false;

            try
            {

                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Codigo FROM Producto where Codigo ='" + producto.Codigo + "'", conn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            conn.Close();
                            return false;
                        }
                        else
                        {
                            conn.Close();
                            return true;
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
                    String queryBuscarPorCodigo = "select * from Producto where Codigo = '" + producto.Codigo + "'";
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
                                    Stock = Convert.ToInt32(reader["Stock"])
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


        public int agregarProducto(Producto producto)
        {
           
                if (IsValidCodigo(producto) == true)
                {
                    try
                    {
                        using (var cnn = GetConnection())
                        {
                            producto.Price = 0;
                            producto.Stock= 0;
                            cnn.Open();
                            String QueryDatosValidos = "insert into Producto ([Codigo],[Nombre],[Descripcion],[Precio],[Stock])"
                           + "values ('" + producto.Codigo + "','" + producto.Name + "','" + producto.Descripcion + "','" + producto.Price + "','" + producto.Stock + "')";
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
            if (IsValidCodigo(producto) == true)
            {
                try
                {
                    using (var cnn = GetConnection())
                    {
                        cnn.Open();
                        String QueryDatosValidos = "update Producto set " +
                                                  "Nombre = '" + producto.Name + "', " +
                                                  "Descripcion = '" + producto.Descripcion + "', " +
                                                  "Precio = '" + producto.Price + "', " +
                                                  "Stock = '" + producto.Stock + "' " +
                                                  "where Codigo = '" + producto.Codigo + "'";
                        using (SqlCommand cmd = new SqlCommand(QueryDatosValidos, cnn))
                        {
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


    }
}
