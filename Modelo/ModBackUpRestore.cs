using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Modelo
{
    public class ModBackUpRestore : ConexionSQL
    {
        public int RealizarBackUp(string Ruta)
        {
            try
            {

                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    string nombre_Copia = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + " StarCG BackUp.bak");

                    string query = "BACKUP DATABASE [TrabajoDeDiploma] TO  DISK = N'"+Ruta+"\\" + nombre_Copia + " ' WITH NOFORMAT, NOINIT,  NAME = N'TrabajoDeDiploma-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
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

        public int RealizarRestore(string Ruta)
        {
            try
            {
                using (var cnn = GetConnection())
                {
                    cnn.Open();
                    // Switch to the master database before performing the restore
                    using (SqlCommand switchCmd = new SqlCommand("USE master;", cnn))
                    {
                        switchCmd.ExecuteNonQuery();
                    }

                    string query = @"
ALTER DATABASE [TrabajoDeDiploma] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
RESTORE DATABASE [TrabajoDeDiploma] FROM DISK = N'" + Ruta + @"' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10;
ALTER DATABASE [TrabajoDeDiploma] SET MULTI_USER;";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return 1; // Completed successfully
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Handle the exception appropriately
                return -1; // Error while restoring
            }
        }


    }
}
