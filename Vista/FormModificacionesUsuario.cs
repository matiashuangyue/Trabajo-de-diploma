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
        private int NewEstadoID;
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
            perfilUsuario(UserDNI);
            if (RoleID != 1)
            {   
                lblRol.Visible = false;
                cmbRol.Visible = false;
                lblEstado.Visible = false;
                cmbEstado.Visible = false;
                btnBuscar.Visible = false;
                txtDNI.Enabled = false;
                

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
            IdentificarEstado(usuarioEncontrado.ID_Estado);
            IdentificarRol(usuarioEncontrado.ID_Rol);
        }

        private void obtenerRol()
        {
            if (cmbRol.SelectedItem == "Admin")
            {
                NewRoleID = 1;
            }else if(cmbRol.SelectedItem == "Empleado")
            {
                NewRoleID = 2;
            }else if (cmbRol.SelectedItem == "Proveedor")
            {
                NewRoleID=3;
            }else if (cmbRol.SelectedItem == "Usuario")
            {
                NewRoleID = 0;
            }
        }

        private void obtenerEstado()
        {
            if (cmbEstado.SelectedItem == "Alta")
            {
                NewEstadoID = 1;
            }
            else
            {
                NewEstadoID = 0;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            obtenerRol();
            obtenerEstado();

            // Verifica que los campos numéricos no estén vacíos y contengan valores válidos
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, complete los campos numéricos.");
                return;
            }

            // Verifica que los campos numéricos contengan valores válidos
            if (!int.TryParse(txtDNI.Text, out int dni) ||
                !int.TryParse(txtTelefono.Text, out int telefono))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
                return;
            }

            Usuario usuarioModificado = new Usuario
            {
                DNI = dni,
                Name = txtName.Text,
                Mail = txtMail.Text,
                Telefono = telefono,
                Direccion = txtDireccion.Text,
                Password = txtPassword.Text,
                ID_Rol = NewRoleID,
                ID_Estado = NewEstadoID,
            };

            // Llama a la función de modificarUsuario en la controladora
            ControlUsuario controlUsuario = new ControlUsuario();
            int resultado = controlUsuario.ModificarUsuario(usuarioModificado);

            // Maneja el resultado según tus necesidades (por ejemplo, muestra mensajes)
            if (resultado == 1)
            {
                MessageBox.Show("Usuario modificado correctamente.");
            }
            else if (resultado == -1)
            {
                MessageBox.Show("No se encontró un usuario con el DNI dado.");
            }
            else if (resultado == -2)
            {
                MessageBox.Show("Error al modificar datos en la base de datos.");
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
       

}

