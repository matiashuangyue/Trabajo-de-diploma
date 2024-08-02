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
using static Controladora.ControlAuditoria;

namespace Vista
{
    public partial class FormModificacionesUsuario : Form
    {
        private int RoleID;
        private int UserDNI;
        private int NewEstadoID;
        private int NewRoleID;
        private ControlUsuario controlUsuario = ControlUsuario.Instance;
        private ControlAuditoria controlAuditoria = ControlAuditoria.Instance;

        public FormModificacionesUsuario(int rol, int DNI)
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
        }

        private void IdentificarRol(int rol)
        {
            foreach (var item in cmbRol.Items)
            {
                if (item is KeyValuePair<int, string> kvp && kvp.Key == rol)
                {
                    cmbRol.SelectedItem = item;
                    break;
                }
            }
        }

        private void IdentificarEstado(int estado)
        {
            foreach (var item in cmbEstado.Items)
            {
                if (item is KeyValuePair<int, string> kvp && kvp.Key == estado)
                {
                    cmbEstado.SelectedItem = item;
                    break;
                }
            }
        }

        private void FormModificacionesUsuario_Load(object sender, EventArgs e)
        {
            permiso();
            CargarRoles();
            CargarEstados();
        }

        private void CargarRoles()
        {
            var roles = controlUsuario.ObtenerIDyRoles();
            cmbRol.DataSource = new BindingSource(roles, null);
            cmbRol.DisplayMember = "Value";
            cmbRol.ValueMember = "Key";
        }

        private void CargarEstados()
        {
            var estados = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "Alta"),
                new KeyValuePair<int, string>(0, "Baja")
            };

            cmbEstado.DataSource = new BindingSource(estados, null);
            cmbEstado.DisplayMember = "Value";
            cmbEstado.ValueMember = "Key";
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDNI.Text, out int dni))
            {
                Usuario usuarioEncontrado = controlUsuario.BuscarUsuarioPorDNI(dni);

                if (usuarioEncontrado != null)
                {
                    // Mostrar información del usuario encontrado en tu formulario
                    txtName.Text = usuarioEncontrado.Name;
                    txtMail.Text = usuarioEncontrado.Mail;
                    txtDireccion.Text = usuarioEncontrado.Direccion;
                    txtPassword.Text = usuarioEncontrado.Password;
                    txtTelefono.Text = usuarioEncontrado.Telefono.ToString();
                    IdentificarEstado(usuarioEncontrado.ID_Estado);
                    IdentificarRol(usuarioEncontrado.ID_Rol);
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
            NewRoleID = ((KeyValuePair<int, string>)cmbRol.SelectedItem).Key;
        }

        private void obtenerEstado()
        {
            NewEstadoID = ((KeyValuePair<int, string>)cmbEstado.SelectedItem).Key;
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
            int resultado = controlUsuario.ModificarUsuario(usuarioModificado);

            // Maneja el resultado según tus necesidades (por ejemplo, muestra mensajes)
            if (resultado == 1)
            {
                MessageBox.Show("Usuario modificado correctamente.");
                controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, UserDNI, "Gestionar Usuario");
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
            // Este método está vacío, podrías eliminarlo si no es necesario
        }
    }
}
