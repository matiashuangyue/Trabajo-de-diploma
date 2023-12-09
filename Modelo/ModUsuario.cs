using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;


namespace Modelo
{
    public class ModUsuario : ConexionSQL
    {
        public bool login(Usuario usuario)
        {
            try
            {

                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT DNI , Contra  FROM Usuarios where DNI ='" + usuario.DNI + "'AND Contra='" + usuario.Password + "'", cnn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            cnn.Close();
                            return true;
                        }
                        else
                        {
                            cnn.Close();
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool IsValidMail(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Mail))
                return false;

            try
            {
                // Normalize the domain
                usuario.Mail = Regex.Replace(usuario.Mail, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(usuario.Mail,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public bool IsValidID(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.DNI.ToString()))
                return false;

            try
            {

                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT DNI FROM Usuarios where DNI ='" + usuario.DNI + "'", conn))
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

        public int GetRoleId(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.DNI.ToString()))
            {
                return -1; // Valor que indica que no se pudo obtener el ID_Rol
            }

            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ID_Rol FROM Usuarios WHERE DNI = @DNI", conn))
                    {
                        cmd.Parameters.AddWithValue("@DNI", usuario.DNI);
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            int idRol = Convert.ToInt32(dr["ID_Rol"]);
                            conn.Close();
                            return idRol;
                        }
                        else
                        {
                            conn.Close();
                            return -1; // Valor que indica que no se encontró el usuario
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return -1; // Valor que indica un error durante la ejecución
            }
        }

        public int GetDNIPorNombre(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return -1; // Valor que indica que no se pudo obtener el ID_Rol
            }

            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT DNI FROM Usuarios WHERE Nombre = @Nombre", conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", name);
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            int DNI = Convert.ToInt32(dr["DNI"]);
                            conn.Close();
                            return DNI;
                        }
                        else
                        {
                            conn.Close();
                            return -1; // Valor que indica que no se encontró el usuario
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return -1; // Valor que indica un error durante la ejecución
            }
        }


        public int Registrar(Usuario usuario)
        {
            try
            {
                if (IsValidID(usuario) && IsValidMail(usuario))
                {
                    using (var cnn = GetConnection())
                    {
                        cnn.Open();
                        string query = "INSERT INTO Usuarios (DNI, Nombre, Mail, Telefono, Direccion, Contra, ID_Rol, ID_Estado) " +
                                       "VALUES (@DNI, @Nombre, @Mail, @Telefono, @Direccion, @Contra, @ID_Rol,@ID_Estado)";

                        using (SqlCommand cmd = new SqlCommand(query, cnn))
                        {
                            cmd.Parameters.AddWithValue("@DNI", usuario.DNI);
                            cmd.Parameters.AddWithValue("@Nombre", usuario.Name);
                            cmd.Parameters.AddWithValue("@Mail", usuario.Mail);
                            cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                            cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                            cmd.Parameters.AddWithValue("@Contra", usuario.Password);
                            cmd.Parameters.AddWithValue("@ID_Rol", usuario.ID_Rol);
                            cmd.Parameters.AddWithValue("@ID_Estado", usuario.ID_Estado);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return 1; // Completo correctamente
                }
                else
                {
                    return IsValidID(usuario) ? -3 : -2;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Manejar la excepción de manera adecuada
                return -1; // Error en insertar datos
            }
        }




        public Usuario BuscarUsuarioPorDNI(int dni)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string queryBuscarPorDNI = "SELECT * FROM Usuarios WHERE DNI = @DNI";
                    using (SqlCommand cmd = new SqlCommand(queryBuscarPorDNI, cnn))
                    {
                        cmd.Parameters.AddWithValue("@DNI", dni);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Usuario
                                {
                                    DNI = Convert.ToInt32(reader["DNI"]),
                                    Name = reader["Nombre"].ToString(),
                                    Mail = reader["Mail"].ToString(),
                                    Telefono = Convert.ToInt64(reader["Telefono"]),
                                    Direccion = reader["Direccion"].ToString(),
                                    Password = reader["Contra"].ToString(),
                                    ID_Rol = Convert.ToInt32(reader["ID_Rol"]),
                                    ID_Estado = Convert.ToInt32(reader["ID_Estado"]),
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                Console.WriteLine($"Error en la búsqueda por DNI: {ex.Message}");
            }

            return null; // Devolver null si no se encuentra el usuario
        }


        public int modificarUsuario(Usuario usuario)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    String queryDatosValidos = "UPDATE Usuarios SET " +
                                                "Nombre = @Nombre, " +
                                                "Mail = @Mail, " +
                                                "Telefono = @Telefono, " +
                                                "Direccion = @Direccion, " +
                                                "Contra = @Contra, " +
                                                "ID_Rol = @ID_Rol, " +
                                                "ID_Estado = @ID_Estado " +
                                                "WHERE DNI = @DNI";

                    using (SqlCommand cmd = new SqlCommand(queryDatosValidos, cnn))
                    {
                        // Utiliza parámetros para evitar la inyección de SQL
                        cmd.Parameters.AddWithValue("@Nombre", usuario.Name);
                        cmd.Parameters.AddWithValue("@Mail", usuario.Mail);
                        cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                        cmd.Parameters.AddWithValue("@Contra", usuario.Password);
                        cmd.Parameters.AddWithValue("@ID_Rol", usuario.ID_Rol);
                        cmd.Parameters.AddWithValue("@ID_Estado", usuario.ID_Estado);
                        cmd.Parameters.AddWithValue("@DNI", usuario.DNI);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            cnn.Close();
                            return 1; // se ha modificado el usuario correctamente
                        }
                        else
                        {
                            cnn.Close();
                            return -1; // no se encontró el usuario con el DNI dado
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar usuario: {ex.Message}");
                return -2; // error al modificar datos en SQL
            }
        }
    }
}
