﻿using System;
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

        public string GetPasswordPorDniYMail(int dni, string mail)
        {
            if (dni <= 0 || string.IsNullOrWhiteSpace(mail))
            {
                return string.Empty; // Valor que indica que no se pudo obtener la contraseña
            }

            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Contra FROM Usuarios WHERE DNI = @DNI AND Mail = @Mail", conn))
                    {
                        cmd.Parameters.AddWithValue("@DNI", dni);
                        cmd.Parameters.AddWithValue("@Mail", mail);
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            string password = dr["Contra"].ToString();
                            conn.Close();
                            return password;
                        }
                        else
                        {
                            conn.Close();
                            return string.Empty; // Valor que indica que no se encontró el usuario
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                // Console.WriteLine(ex.Message);
                return string.Empty; // Valor que indica un error durante la ejecución
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

        public int CrearNuevoRol(string nombreRol)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();

                    // Obtener el último ID de la tabla Roles
                    int ultimoId = ObtenerUltimoIdRol(cnn);

                    // Incrementar el ID para el nuevo rol
                    int nuevoId = ultimoId + 1;

                    // Insertar el nuevo rol en la tabla Roles
                    string query = "INSERT INTO Roles (ID, Rol) VALUES (@Id, @NombreRol)";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Id", nuevoId);
                        cmd.Parameters.AddWithValue("@NombreRol", nombreRol);
                        cmd.ExecuteNonQuery();
                        return nuevoId;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear nuevo rol: {ex.Message}");
                return -1; // Retornar un valor negativo para indicar un error
            }
        }

        public int CrearNuevoPermiso(string nombrePermiso)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    // Obtener el último ID de la tabla Roles
                    int ultimoId = ObtenerUltimoIdPermiso(cnn);

                    // Incrementar el ID para el nuevo permiso
                    int nuevoId = ultimoId + 1;


                    string sql = "INSERT INTO Permisos (ID,Permiso) VALUES (@Id, @nombrePermiso)";

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Id", nuevoId);
                        cmd.Parameters.AddWithValue("@nombrePermiso", nombrePermiso);
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // Verificar si se insertó correctamente el nuevo permiso
                        if (filasAfectadas > 0)
                        {
                            return nuevoId; // Se creó el nuevo permiso con éxito
                        }
                        else
                        {
                            return -1; // No se pudo crear el nuevo permiso
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                Console.WriteLine($"Error al crear nuevo permiso: {ex.Message}");
                return -1; // No se pudo crear el nuevo permiso
            }
        }



        private int ObtenerUltimoIdRol(SqlConnection cnn)
        {
            // Consulta para obtener el último ID de la tabla Roles
            string query = "SELECT MAX(ID) FROM Roles";

            // Ejecutar la consulta y obtener el último ID
            using (SqlCommand cmd = new SqlCommand(query, cnn))
            {
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return 0; // Si no hay registros en la tabla, se devuelve 0
                }
            }
        }

        private int ObtenerUltimoIdPermiso(SqlConnection cnn)
        {
            // Consulta para obtener el último ID de la tabla Roles
            string query = "SELECT MAX(ID) FROM Permisos";

            // Ejecutar la consulta y obtener el último ID
            using (SqlCommand cmd = new SqlCommand(query, cnn))
            {
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return 0; // Si no hay registros en la tabla, se devuelve 0
                }
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


        //PERMISOS

        public int ObtenerIdRolPorNombre(string nombreRol)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string sql = "SELECT ID FROM Roles WHERE Rol = @NombreRol";

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@NombreRol", nombreRol);

                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            // Si el rol no existe, puedes decidir qué hacer, por ejemplo, lanzar una excepción
                            throw new InvalidOperationException("El rol especificado no existe en la base de datos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener ID del rol: {ex.Message}");
                // Manejar la excepción según tus necesidades
                return -1; // Retornar un valor negativo para indicar un error
            }
        }



        public List<string> ObtenerPermisosPorRol(int rol)
        {
            List<string> permisos = new List<string>();

            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string sql = @"
                SELECT p.Permiso 
                FROM Permisos p 
                JOIN Roles_Permisos rp ON p.ID = rp.ID_Permiso 
                JOIN Roles r ON rp.ID_Rol = r.ID 
                WHERE r.ID = @RolID";

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@RolID", rol);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                permisos.Add(reader["Permiso"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                Console.WriteLine($"Error al obtener permisos: {ex.Message}");
            }

            return permisos;
        }

        public List<string> ObtenerPermisos()
        {
            List<string> permisos = new List<string>();

            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string sql = " SELECT Permiso FROM Permisos ";
                
               

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                permisos.Add(reader["Permiso"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                Console.WriteLine($"Error al obtener permisos: {ex.Message}");
            }

            return permisos;
        }

        
        public List<string> ObtenerRoles()
        {
            List<string> roles = new List<string>();

            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string sql = " SELECT Rol FROM Roles ";



                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                roles.Add(reader["Rol"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                Console.WriteLine($"Error al obtener roles: {ex.Message}");
            }

            return roles;
        }

        public void AgregarPermisoARol(int idRol, string permiso)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();

                    // Consulta para insertar el permiso asociado al rol en la tabla Roles_Permisos
                    string query = "INSERT INTO Roles_Permisos (ID_Rol, ID_Permiso) VALUES (@ID_Rol, @ID_Permiso)";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Rol", idRol);

                        // Supongamos que tienes una tabla "Permisos" donde almacenas los permisos y sus respectivos IDs
                        // Aquí buscas el ID del permiso en base a su nombre
                        int idPermiso = ObtenerIdPermiso(permiso);

                        cmd.Parameters.AddWithValue("@ID_Permiso", idPermiso);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar permiso al rol: {ex.Message}");
                // Manejar la excepción según tus necesidades
            }
        }

        public void ActualizarPermisosPorRol(int idRol, List<string> permisos)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();

                    // Iniciamos una transacción para garantizar la integridad de los datos
                    using (SqlTransaction transaction = cnn.BeginTransaction())
                    {
                        try
                        {
                            // Eliminamos todos los permisos asociados a este rol
                            string deleteQuery = "DELETE FROM Roles_Permisos WHERE ID_Rol = @ID_Rol";
                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, cnn, transaction))
                            {
                                deleteCmd.Parameters.AddWithValue("@ID_Rol", idRol);
                                deleteCmd.ExecuteNonQuery();
                            }

                            // Insertamos los nuevos permisos
                            string insertQuery = "INSERT INTO Roles_Permisos (ID_Rol, ID_Permiso) VALUES (@ID_Rol, @ID_Permiso)";
                            foreach (string permiso in permisos)
                            {
                                // Obtener el ID del permiso
                                int idPermiso = ObtenerIdPermiso(permiso);
                                if (idPermiso != -1)
                                {
                                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, cnn, transaction))
                                    {
                                        insertCmd.Parameters.AddWithValue("@ID_Rol", idRol);
                                        insertCmd.Parameters.AddWithValue("@ID_Permiso", idPermiso);
                                        insertCmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"El permiso '{permiso}' no se encontró en la base de datos.");
                                }
                            }

                            // Confirmamos la transacción
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // En caso de error, revertimos la transacción
                            Console.WriteLine($"Error en la transacción: {ex.Message}");
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar permisos del rol: {ex.Message}");
                // Manejar la excepción según tus necesidades
            }
        }






        // Método para obtener el ID del permiso en base a su nombre
        private int ObtenerIdPermiso(string permiso)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();

                    // Consulta para obtener el ID del permiso en base a su nombre
                    string query = "SELECT ID FROM Permisos WHERE Permiso = @Permiso";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Permiso", permiso);

                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            // Si el permiso no existe, puedes decidir qué hacer, por ejemplo, lanzar una excepción
                            throw new InvalidOperationException("El permiso especificado no existe en la base de datos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener ID del permiso: {ex.Message}");
                // Manejar la excepción según tus necesidades
                return -1; // Retornar un valor negativo para indicar un error
            }
        }

        public List<KeyValuePair<int, string>> ObtenerIDyRoles()
        {
            List<KeyValuePair<int, string>> roles = new List<KeyValuePair<int, string>>();
            string query = "SELECT ID, Rol FROM [TrabajoDeDiploma].[dbo].[Roles]";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        roles.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                    }
                }
            }
            return roles;
        }




    }
}
