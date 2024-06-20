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
    public partial class FormAddUsuario : Form
    {
        public int rol;
        private int NewRoleID;
        private string selectedItem;
        private int DNI;
        private ControlUsuario controlUsuario = new ControlUsuario();
        public FormAddUsuario(int RoleID, int DNI)
        {
            InitializeComponent();
            this.rol = RoleID;
            this.DNI = DNI;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (CamposCompletados())
            {
                if (long.TryParse(txtTelefono.Text, out long telefono))
                {
                    if (rol != 1)
                    {
                        RegistrarUsuario(0, telefono);
                    }
                    else
                    {
                        asignarRol();
                        RegistrarUsuario(NewRoleID, telefono);
                    }
                }
                else
                {
                    MessageBox.Show("¡El teléfono debe ser un número!");
                }
            }
            else
            {
                MessageBox.Show("¡Por favor, completa todos los campos!");
            }

        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void CargarRoles()
        {
            var roles = controlUsuario.ObtenerIDyRoles();
            cmbRol.DataSource = new BindingSource(roles, null);
            cmbRol.DisplayMember = "Value";
            cmbRol.ValueMember = "Key";
        }

        private void asignarRol()
        {
            if (cmbRol.SelectedItem is KeyValuePair<int, string> selectedRole)
            {
                NewRoleID = selectedRole.Key;
            }
            else
            {
                MessageBox.Show("Por favor selecciona un rol válido.");
            }
        }


        private void RegistrarUsuario(int rolID, long telefono)
        {
            Usuario UserActual = new Usuario
            {
                DNI = int.Parse(txtDNI.Text),
                Name = txtName.Text,
                Mail = txtMail.Text,
                Telefono = telefono,
                Direccion = txtDireccion.Text,
                Password = txtPassword.Text,
                ID_Rol = rolID,
                ID_Estado = 1,
            };

            ControlUsuario User = new ControlUsuario();
            int registrarse = User.RegistrarCuenta(UserActual);

            if (registrarse == 1)
            {
                MessageBox.Show("Ha creado nuevo usuario");
                ControlAuditoria controlAuditoria = new ControlAuditoria();
                controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, DNI, "Gestionar Usuario");
            }
            else if (registrarse == -1)
            {
                MessageBox.Show("Error al insertar datos en la base de datos.");
            }
            else if (registrarse == -2)
            {
                MessageBox.Show("El DNI ya existe en la base de datos, por favor verifique.");
            }
            else if (registrarse == -3)
            {
                MessageBox.Show("El correo electrónico es inválido.");
            }
        }


        private bool CamposCompletados()
        {
            return !string.IsNullOrWhiteSpace(txtDNI.Text) &&
                   !string.IsNullOrWhiteSpace(txtName.Text) &&
                   !string.IsNullOrWhiteSpace(txtMail.Text) &&
                   !string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                   !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                   !string.IsNullOrWhiteSpace(txtPassword.Text);
        }





        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
