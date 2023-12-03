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
using Controladora;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtDNI != null)
            {
                if (txtPassword != null)
                {
                    Usuario usuario = new Usuario
                    {
                        DNI = int.Parse(txtDNI.Text),
                        Password = txtPassword.Text,
                    };

                    ControlUsuario User = new ControlUsuario();
                    var LoginValido = User.Validar(usuario);
                    if (LoginValido)
                    {
                        int RoleID = User.GetRoleID(usuario);
                        cambiarformulario(RoleID);
                    }
                    else
                    {
                        MessageBox.Show("El Usuario o Contrasena es invalido");
                    }
                }
            }
        }

        public void cambiarformulario(int RoleID)
        {
            HomePage pantalla1 = new HomePage(RoleID);
            pantalla1.Show();
            this.Hide();
        }

    }
}
