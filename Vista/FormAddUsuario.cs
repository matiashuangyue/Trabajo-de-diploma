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
            if (txtDNI != null && !string.IsNullOrWhiteSpace(txtDNI.Text) &&
                txtName != null && !string.IsNullOrWhiteSpace(txtName.Text) &&
                txtMail != null && !string.IsNullOrWhiteSpace(txtMail.Text) &&
                txtTelefono != null && !string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                txtDireccion != null && !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                txtPassword != null && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                
                long telefono;
                if (long.TryParse(txtTelefono.Text, out telefono))
                {
                    if (rol != 1)
                    {

                        Usuario UserActual = new Usuario
                        {
                            DNI = int.Parse(txtDNI.Text),
                            Name = txtName.Text,
                            Mail = txtMail.Text,
                            Telefono = telefono,
                            Direccion = txtDireccion.Text,
                            Password = txtPassword.Text,
                            ID_Rol = 0,
                            ID_Estado = 1,
                        };
                        Controladora.ControlUsuario User = new Controladora.ControlUsuario();

                        int registrarse = User.RegistrarCuenta(UserActual);
                        if (registrarse == 1)
                        {

                            MessageBox.Show("Ha creado nuevo usuario");

                            ControlAuditoria controlAuditoria = new ControlAuditoria();
                            controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, DNI, "Gestionar Usuario");
                        }
                        else if (registrarse == -1)
                        {
                            MessageBox.Show("error al inserta datos en sql");
                        }
                        else if (registrarse == -2)
                        {
                            MessageBox.Show("tu DNI ya existe en base de datos, cheque porfavor");
                        }
                        else if (registrarse == -3)
                        {
                            MessageBox.Show("Mail es invalido");
                        }
                    }
                    else
                    {
                        asignarRol();
                        Usuario UserActual = new Usuario
                        {
                            DNI = int.Parse(txtDNI.Text),
                            Name = txtName.Text,
                            Mail = txtMail.Text,
                            Telefono = telefono,
                            Direccion = txtDireccion.Text,
                            Password = txtPassword.Text,
                            ID_Rol = NewRoleID,
                            ID_Estado = 1,
                        };
                        Controladora.ControlUsuario User = new Controladora.ControlUsuario();
                        int registrarse = User.RegistrarCuenta(UserActual);
                        if (registrarse == 1)
                        {
                            MessageBox.Show("Ha creado nuevo usuario");
                        }
                        else if (registrarse == -1)
                        {
                            MessageBox.Show("error al inserta datos en sql");
                        }
                        else if (registrarse == -2)
                        {
                            MessageBox.Show("tu DNI ya existe en base de datos, cheque porfavor");
                        }
                        else if (registrarse == -3)
                        {
                            MessageBox.Show("Mail es invalido");
                        }
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
            if (rol != 1)
            {
                lblRol.Visible = false;
                cmbRol.Visible = false;
            }
            else
            {
                if (rol == 1)
                {
                    lblRol.Visible = true;
                cmbRol.Visible = true;
                }
            } 
        }

        private void asignarRol()
        {
            selectedItem = cmbRol.SelectedItem.ToString();
            if (selectedItem == "Admin")
            {
                NewRoleID = 1;
            }
            else if (selectedItem == "Empleado")
            {
                NewRoleID = 2;
            }
            else if (selectedItem == "Proveedor")
            {
                NewRoleID = 3;
            }
            else if (selectedItem == "Usuario")
            {
                NewRoleID = 0;
            }
            else
            {
                MessageBox.Show("porfavor selecciona un rol");
            }
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
