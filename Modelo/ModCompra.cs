using System;
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
        public int RegistrarCompra(Compra compra)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "INSERT INTO Compras (ID_Compra,Fecha, ImporteTotal, ID_Proveedor, DNI_Usuario, ID_Estado) " +
                                   "VALUES (@ID_Compra,@Fecha, @ImporteTotal, @ID_Proveedor, @DNI_Usuario, @ID_Estado); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Fecha",compra.ID_Compra);
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
                return -1; // Error en insertar datos
            }
        }
        public int insertarid (Compra compra)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string query = "INSERT INTO Compras (ID_Compra) " +
                                        "VALUES (@ID_Compra)";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Compra", compra.ID_Compra);
                        
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
                    string query = "INSERT INTO DetalleCompras (ID_Compra,ID_Producto,Cantidad,PrecioUnitario) " +
                                        "VALUES (@ID_Compra,@ID_Producto,@Cantidad,@PrecioUnitario)";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {

                        cmd.Parameters.AddWithValue("@ID_Compra", detalleCompra.ID_Compra);
                        cmd.Parameters.AddWithValue("@ID_Producto", detalleCompra.ID_Producto);
                        cmd.Parameters.AddWithValue("@Cantidad", detalleCompra.Cantidad);
                        cmd.Parameters.AddWithValue("@PrecioUnitario", detalleCompra.PrecioUnitario);
                        cmd.ExecuteNonQuery();
                        return 1;
                       
                    }
                    cnn.Close();
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






    }
}
