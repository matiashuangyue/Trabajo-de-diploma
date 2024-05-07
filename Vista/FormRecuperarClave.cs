using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using COMUN;
using Entidades;

namespace Vista
{
    public partial class FormRecuperarClave : Form
    {
        private int DNI;
        //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
        //contra gmail :area uroj yyri bvwb
        public FormRecuperarClave(int DNI)
        {
            InitializeComponent();
            this.DNI = DNI;
            
        }
        
        private void CargarDatos()
        {
            if(DNI != -1)
            {
                txtDNI.Text = DNI.ToString();
            }
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnSolicitarCodigo_Click(object sender, EventArgs e)
        {
           
            StringBuilder cuerpoMail = new StringBuilder();
            cuerpoMail.AppendLine("Aquí puedes escribir el cuerpo del correo electrónico.");

            string remitente = "Yue1786812727@gmail.com"; // Remitente del correo electrónico
            string destinatario = txtMail.Text; // Dirección de correo electrónico del destinatario
            try
            {
                MetodosComunes.EnviarMail(cuerpoMail, remitente, destinatario);

                MessageBox.Show("Se ha enviado un correo electrónico con el código de verificación.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo electrónico: " + ex.Message);
            }

        }
    }
}
