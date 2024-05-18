using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modelo
{
    public abstract class ConexionSQL
    {
        private readonly string cnn;
        public ConexionSQL()
        {
            cnn = "Data Source =DESKTOP-2F4NVAS\\YUESERVER; Initial Catalog = TrabajoDeDiploma; Integrated Security= True";
            //conecxion Aorus
            //cnn = "Data Source = LAPTOP-PJ5NR8U8\\SQLEXPRESS; Initial Catalog = TrabajoDeDiploma; Integrated Security= True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(cnn);
        }
    }
}
