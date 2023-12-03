using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FormUsuario : Form
    {
        public int rol;
        private int NewRoleID;
        private string selectedItem;
        public FormUsuario(int RoleID)
        {
            InitializeComponent();
            RoleID = this.rol;
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
                
                
                if (rol != 1)
                {
                    Usuario UserActual = new Usuario
                    {
                        DNI = int.Parse(txtDNI.Text),
                        Name = txtName.Text,
                        Mail = txtMail.Text,
                        Telefono = 0,
                        Direction = txtDireccion.Text,
                        Password = txtPassword.Text,
                        ID_Rol = 0,
                };
                    MessageBox.Show("¡Completaste todos los campos para crear usuario!");
                    Controladora.ControlUsuario User = new Controladora.ControlUsuario();
                    var registrarse = User.RegistrarCuenta(UserActual);
                    if (registrarse)
                    {

                        MessageBox.Show("Ha creado nuevo usuario");
                    }
                    else
                    {
                        MessageBox.Show("El Usuario o Contrasena es invalido");
                    }

                }
                else
                {
                    Usuario UserActual = new Usuario
                    {
                        DNI = int.Parse(txtDNI.Text),
                        Name = txtName.Text,
                        Mail = txtMail.Text,
                        Telefono = 0,
                        Direction = txtDireccion.Text,
                        Password = txtPassword.Text,
                        ID_Rol = NewRoleID,
                    };
                    Controladora.ControlUsuario User = new Controladora.ControlUsuario();
                    var registrarse = User.RegistrarCuenta(UserActual);
                    if (registrarse)
                    {

                        MessageBox.Show("Ha creado nueva cuenta ");
                    }
                    else
                    {
                        MessageBox.Show("El Usuario o Contrasena es invalido");
                    }
                }
                
                

                
            }
            else
            {
                MessageBox.Show("¡Por favor, completa todos los campos!");
            }

            /*Controladora.ControlUsuario User = new Controladora.ControlUsuario();
            if (signUp.RegistrarCuenta(txtID.Text, txtName.Text, txtPassWord.Text, txtMail.Text) == false)
            {
                MessageBox.Show("chequea sus datos porfavor");
            }*/
            // Validaciones();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            MessageBox.Show(rol.ToString());
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
                selectedItem = cmbRol.SelectedItem.ToString();
                if (selectedItem == "Admin")
                {
                     NewRoleID= 1;
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

                }
                
            }
        }
    }
}
