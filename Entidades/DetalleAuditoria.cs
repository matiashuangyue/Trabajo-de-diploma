using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleAuditoria
    {
        // ATRIBUTOS PRIVADOS
        //
        private int idDetalleAuditoria;
        private long idAuditoria;
        private int idOperacion;
        private DateTime fechaOperacion;

        // PROPIEDADES PÚBLICAS 
        //
        public int ID_DetalleAuditoria { get; set; }
        public long ID_Auditoria { get; set; }
        public int ID_Operacion { get; set; }// Nuevo campo para el ID de la operación, viene de la tabla de permisos
        public DateTime FechaOperacion { get; set; }


    }
}
