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
        private int RoleID;
        public FormUsuario(int RoleID)
        {
            InitializeComponent();
            RoleID = this.RoleID;
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
                Usuario user = new Usuario
                {
                    DNI = int.Parse(txtDNI.Text),
                    Name = txtName.Text,
                    Mail = txtMail.Text,
                    Telefono = 0,
                    Direction=txtDireccion.Text,
                    Password = txtPassword.Text,
                };

                MessageBox.Show("¡Completaste todos los campos correctamente!");
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

        }
    }
}
