using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Entidades;

namespace Controladora
{
    public class ControlAuditoria
    {
        private ModAuditoria modAuditoria = new ModAuditoria();

        public string RegistrarLogin(int dni)
        {
            return modAuditoria.RegistrarLogin(dni);

        }

        public void RegistrarLogout(string auditoriaId)
        {
            modAuditoria.RegistrarLogout(auditoriaId);
        }

        public void RegistrarOperacion(string auditoriaId, int dni, string operacion)
        {
            modAuditoria.RegistrarOperacion(auditoriaId, dni, operacion);
        }




        public static class AuditoriaGlobal
        {
            private static string auditoriaId;

            public static string AuditoriaId
            {
                get { return auditoriaId; }
                set { auditoriaId = value; }
            }

            public static void RegistrarLogin(int dni)
            {
                ControlAuditoria controlAuditoria = new ControlAuditoria();
                auditoriaId = controlAuditoria.RegistrarLogin(dni);
            }

            public static void RegistrarLogout()
            {
                if (!string.IsNullOrEmpty(auditoriaId))
                {
                    ControlAuditoria controlAuditoria = new ControlAuditoria();
                    controlAuditoria.RegistrarLogout(auditoriaId);
                    auditoriaId = null;
                }
            }
            public static void RegistrarOperacion(int dni, string operacionId)
            {
                if (!string.IsNullOrEmpty(auditoriaId))
                {
                    ControlAuditoria controlAuditoria = new ControlAuditoria();
                    controlAuditoria.RegistrarOperacion(auditoriaId,dni, operacionId);
                }
            }

        }


    }
}
