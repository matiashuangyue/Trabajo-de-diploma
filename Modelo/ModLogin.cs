﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;


namespace Modelo
{
    public class ModlLogin : ConexionSQL
    {
        public bool login(Usuario usuario)
        {
            try
            {

                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Mail , Contra  FROM Usuario where Mail ='" + usuario.Mail + "'AND Contra='" + usuario.Password + "'", cnn))
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

    }
}
