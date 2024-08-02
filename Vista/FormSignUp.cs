using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormSignUp : Form
    {
        private ControlUsuario controlUsuario = ControlUsuario.Instance;
        public FormSignUp( )
        {
            InitializeComponent();
            
        }

        private void FormInforme_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RecuperarContra(-1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VolverALogin();
        }

        private void VolverALogin()
        {
            PanelSignUp.Controls.Clear();
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void RecuperarContra(int DNIRegistrado)
        {
            this.Close();
            Form FormRecuperarClave = new FormRecuperarClave(DNIRegistrado);///1 es el id del rol, aca hay que cambiarlo
            FormRecuperarClave.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDNI != null && !string.IsNullOrWhiteSpace(txtDNI.Text) &&
               txtName != null && !string.IsNullOrWhiteSpace(txtName.Text) &&
               txtMail != null && !string.IsNullOrWhiteSpace(txtMail.Text) &&
               txtTelefono != null && !string.IsNullOrWhiteSpace(txtTelefono.Text) &&
               txtDireccion != null && !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
               txtPassword != null && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {


                if (txtPassword.Text== txtCheckPassword.Text)
                {
                    long telefono;
                    if (long.TryParse(txtTelefono.Text, out telefono))
                    {
                        Usuario UserActual = new Usuario
                        {
                            DNI = int.Parse(txtDNI.Text),
                            Name = txtName.Text,
                            Mail = txtMail.Text,
                            Telefono = long.Parse(txtTelefono.Text),
                            Direccion = txtDireccion.Text,
                            Password = txtPassword.Text,
                            ID_Rol = 0,
                            ID_Estado = 1,
                        };

                        int registrarse = controlUsuario.RegistrarCuenta(UserActual);
                        if (registrarse == 1)
                        {
                            
                            MessageBox.Show("Ha creado nuevo usuario");
                            VolverALogin ();
                        }
                        else if (registrarse == -1)
                        {
                            MessageBox.Show("error al inserta datos en sql");
                        }
                        else if (registrarse == -2)
                        {
                            var confirmResult = MessageBox.Show("Tu DNI ya existe en la base de datos. ¿Deseas recuperar tu contraseña?", "DNI ya registrado", MessageBoxButtons.YesNo);
                            if (confirmResult == DialogResult.Yes)
                            {
                                RecuperarContra(int.Parse(txtDNI.Text));
                            }
                            else
                            {
                                MessageBox.Show("Chequea tu DNI por favor.");
                            }
                        }
                        else if (registrarse == -3)
                        {
                            MessageBox.Show("Mail es invalido");
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡El teléfono debe ser un número!");
                    }
                }
               else
                {
                   MessageBox.Show("¡Las contraseñas no coinciden!");
                }
            }
            else
            {
                MessageBox.Show("¡Por favor, completa todos los campos!");
            }

        }
    }
}
