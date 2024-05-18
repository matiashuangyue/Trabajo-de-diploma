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
        private ControlUsuario controlUsuario = new ControlUsuario();
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
            // Obtener DNI y correo electrónico desde los TextBoxes
            if (int.TryParse(txtDNI.Text, out int dni))
            {
                string mail = txtMail.Text;


                // Obtener la contraseña
                string contraseña = controlUsuario.GetContra(dni, mail);

                if (!string.IsNullOrEmpty(contraseña))
                {
                    // Crear el cuerpo del correo electrónico
                    StringBuilder cuerpoMail = new StringBuilder();
                    cuerpoMail.AppendLine("Estimado/a usuario/a,");
                    cuerpoMail.AppendLine();
                    cuerpoMail.AppendLine("Hemos recibido una solicitud para recuperar su contraseña. A continuación, encontrará su contraseña actual:");
                    cuerpoMail.AppendLine();
                    cuerpoMail.AppendLine($"Contraseña: {contraseña}");
                    cuerpoMail.AppendLine();
                    cuerpoMail.AppendLine("Por favor, asegúrese de cambiar su contraseña una vez que haya iniciado sesión por motivos de seguridad.");
                    cuerpoMail.AppendLine();
                    cuerpoMail.AppendLine("Si no solicitó esta información, por favor contacte a nuestro soporte inmediatamente.");
                    cuerpoMail.AppendLine();
                    cuerpoMail.AppendLine("Saludos cordiales,");
                    cuerpoMail.AppendLine("El equipo de soporte");
                    string remitente = "Yue1786812727@gmail.com"; // Remitente del correo electrónico
                    string destinatario = mail; // Dirección de correo electrónico del destinatario

                    try
                    {
                        // Enviar el correo electrónico
                        MetodosComunes.EnviarMail(cuerpoMail, remitente, destinatario);
                        MessageBox.Show("Se ha enviado un correo electrónico con su contraseña.");

                        // Cerrar el formulario actual y abrir el formulario de login
                        this.Close();
                        Login login = new Login();
                        login.Show();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al enviar el correo electrónico: " + ex.Message);
                        txtDNI.Clear();
                        txtMail.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario o hubo un error.");
                    txtDNI.Clear();
                    txtMail.Clear();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.");
                txtDNI.Clear();
                txtMail.Clear();
            }
        }
    }
}
