using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Modelo
{
    public class ModInforme : ConexionSQL
    {
        public DataTable ObtenerProductosMasVendidos()
        {
            DataTable dataTable = new DataTable();
            string query = @"
                SELECT 
                    P.Codigo,
                    P.Nombre,
                    SUM(DP.Cantidad) AS CantidadTotalVendida,
                    SUM(DP.Cantidad * DP.PrecioVenta) AS PrecioTotalVendido
                FROM 
                    [TrabajoDeDiploma].[dbo].[DetallePedidos] DP
                JOIN 
                    [TrabajoDeDiploma].[dbo].[Productos] P ON DP.ID_Producto = P.Codigo
                JOIN 
                    [TrabajoDeDiploma].[dbo].[Pedidos] PD ON DP.ID_Pedido = PD.ID_Pedido
                GROUP BY 
                    P.Codigo, P.Nombre
                ORDER BY 
                    CantidadTotalVendida DESC;
            ";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable ObtenerVentasPorVendedor()
        {
            DataTable dataTable = new DataTable();
            string query = @"
                    SELECT 
                        U.Nombre,
                        SUM(PD.Importe) AS VentasTotales
                    FROM 
                        [TrabajoDeDiploma].[dbo].[Pedidos] PD
                    JOIN
                        [TrabajoDeDiploma].[dbo].[Usuarios] U ON PD.ID_Vendedor = U.DNI
                    WHERE
                        U.ID_Rol = 2
                    GROUP BY 
                        U.Nombre
                    ORDER BY 
                        VentasTotales DESC;
                ";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable ObtenerVentasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dataTable = new DataTable();
            string query = @"
        SELECT 
            DATEPART(month, PD.Fecha) AS Mes,
            SUM(PD.Importe) AS VentasTotales
        FROM 
            [TrabajoDeDiploma].[dbo].[Pedidos] PD
        WHERE
            PD.Fecha BETWEEN @FechaInicio AND @FechaFin
        GROUP BY 
            DATEPART(month, PD.Fecha)
        ORDER BY 
            Mes;
    ";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@FechaFin", fechaFin);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }





    }
}
