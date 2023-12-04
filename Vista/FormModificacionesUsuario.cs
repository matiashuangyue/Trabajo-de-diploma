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
using Entidades;

namespace Vista
{
    public partial class FormModificacionesUsuario : Form
    {
        private int RoleID;
        private int UserDNI;
        private int EstadoID;
        private int NewRoleID;
        
        private ControlUsuario controlUsuario = new ControlUsuario();
        public FormModificacionesUsuario(int rol,int DNI)
        {
            InitializeComponent();
            this.RoleID = rol;
            this.UserDNI = DNI;
        }

        private void vaciarTextbox()
        {
            txtName.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cmbRol.SelectedItem = null;
            cmbEstado.SelectedItem = null;
        }
        private void estadoUsuario()
        {
            if (cmbEstado.SelectedItem == "Alta")
            {
                EstadoID = 1;
            }
            else
            {
                EstadoID = 0;
            }
        }
        private bool CamposCompletados()
        {
            // Verifica que todos los campos estén completados
            return !string.IsNullOrEmpty(txtName.Text) &&
                   !string.IsNullOrEmpty(txtMail.Text) &&
                   !string.IsNullOrEmpty(txtTelefono.Text) &&
                   !string.IsNullOrEmpty(txtDireccion.Text) &&
                   !string.IsNullOrEmpty(txtPassword.Text);
        }

        private void permiso()
        {
            if (RoleID != 1)
            {   
                lblRol.Visible = false;
                cmbRol.Visible = false;
                lblEstado.Visible = false;
                cmbEstado.Visible = false;
                btnBuscar.Visible = false;
                txtDNI.Enabled = false;
                perfilUsuario(UserDNI);

            }
            else
            {
                if (RoleID == 1)
                {
                    lblRol.Visible = true;
                    cmbRol.Visible = true;
                    lblEstado.Visible = true;
                    cmbEstado.Visible = true;
                    btnBuscar.Visible=true;
                    txtDNI.Enabled = true;
                }
            }
        }

        private void IdentificarRol(int rol)
        {
            if(rol == 0)
            {
                cmbRol.SelectedItem = "Usuario";
            }
            else if (rol == 1)
            {
                cmbRol.SelectedItem = "Admin";
            }
            else if (rol == 2)
            {
                cmbRol.SelectedItem = "Empleado";
            }
            else if (rol == 3)
            {
                cmbRol.SelectedItem = "Proveedor";
            }
        }
        private void IdentificarEstado(int Estado)
        {
            if (Estado != 0)
            {
                cmbEstado.SelectedItem = "Alta";
            }
            else
            {
                cmbEstado.SelectedItem = "Baja";
            }
        }

        private void FormModificacionesUsuario_Load(object sender, EventArgs e)
        {
            permiso();
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtDNI.Text, out int dni))
            {
                Usuario usuarioEncontrado = controlUsuario.BuscarUsuarioPorDNI(dni);

                if (usuarioEncontrado != null)
                {
                    // Mostrar información del usuario encontrado en tu formulario
                    // Puedes usar los TextBox u otros controles según tus necesidades
                    txtName.Text = usuarioEncontrado.Name;
                    txtMail.Text = usuarioEncontrado.Mail;
                    txtDireccion.Text = usuarioEncontrado.Direccion;
                    txtPassword.Text = usuarioEncontrado.Password;
                    txtTelefono.Text = usuarioEncontrado.Telefono.ToString();
                    IdentificarEstado(usuarioEncontrado.ID_Estado);
                    IdentificarRol(usuarioEncontrado.ID_Rol);
                    // ... (otros campos)
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado en la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.");
            }
        }

        private void perfilUsuario(int DNI)
        {
            Usuario usuarioEncontrado = controlUsuario.BuscarUsuarioPorDNI(DNI);
            txtDNI.Text = DNI.ToString();
            txtName.Text = usuarioEncontrado.Name;
            txtMail.Text = usuarioEncontrado.Mail;
            txtDireccion.Text = usuarioEncontrado.Direccion;
            txtPassword.Text = usuarioEncontrado.Password;
            txtTelefono.Text = usuarioEncontrado.Telefono.ToString();
        }

    }
       

}

