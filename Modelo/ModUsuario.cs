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
                    using (SqlCommand cmd = new SqlCommand("SELECT DNI , Contra  FROM Usuario where DNI ='" + usuario.DNI + "'AND Contra='" + usuario.Password + "'", cnn))
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
                    using (SqlCommand cmd = new SqlCommand("SELECT DNI FROM Usuario where DNI ='" + usuario.DNI + "'", conn))
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
                    using (SqlCommand cmd = new SqlCommand("SELECT ID_Rol FROM Usuario WHERE DNI = @DNI", conn))
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

        public bool Registrar(Usuario usuario)
        {

            if (string.IsNullOrEmpty(usuario.Name) ||
            string.IsNullOrEmpty(usuario.Password)
            )
            {
                if (IsValidID(usuario) == true)
                {
                    if (IsValidMail(usuario) == true)
                    {
                        try
                        {
                            using (var cnn = GetConnection())
                            {
                                cnn.Open();
                                String QueryDatosValidos = "insert into Usuarios ([DNI],[Nombre],[Mail],[Telefono],[Direccion],[Contra],[ID_Rol])"
                               + "values ('" + usuario.DNI + "','" + usuario.Name + "','" + usuario.Mail + "','" + usuario.Telefono + "','" + usuario.Direction + "','" + usuario.Password + "','" + usuario.ID_Rol + "')";
                                using (SqlCommand cmd = new SqlCommand(QueryDatosValidos, cnn))
                                {
                                    cmd.ExecuteNonQuery();
                                    cnn.Close();
                                }
                                return true;
                            }
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }

                    }

                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }



    }
}
