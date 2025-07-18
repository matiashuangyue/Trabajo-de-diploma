using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auditoria
    {
        // ATRIBUTOS PRIVADOS
        //
        private long idAuditoria;
        private int dni;
        private DateTime timeLogin;
        private DateTime timeLogout;

        // PROPIEDADES PÚBLICAS
        //
        public long ID_Auditoria { get; set; }
        public int DNI { get; set; }
        public DateTime TimeLogin { get; set; }
        public DateTime TimeLogout { get; set; }


    }
}
