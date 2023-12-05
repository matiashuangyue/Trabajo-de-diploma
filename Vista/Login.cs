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
        private ControlUsuario controlUsuario = new ControlUsuario();
        private int IDEstado;
        private int IDRol;
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
                        ChequearEstado(usuario.DNI);
                        if(IDEstado == 1 || IDRol==1 )
                        {
                        int RoleID = User.GetRoleID(usuario);
                        int DNI= usuario.DNI;
                        cambiarformulario(IDRol,DNI);
                        }
                        else
                        {
                            MessageBox.Show("su cuenta esta dado de baja, porfavor comunicate con administrador");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Usuario o Contrasena es invalido");
                    }
                }
            }
        }

        public void cambiarformulario(int RoleID,int DNI)
        {
            HomePage pantalla1 = new HomePage(RoleID,DNI);
            pantalla1.Show();
            this.Hide();
        }
        private void ChequearEstado(int DNI)
        {
            Usuario usuarioEncontrado = controlUsuario.BuscarUsuarioPorDNI(DNI);
            IDEstado = usuarioEncontrado.ID_Estado;
            IDRol= usuarioEncontrado.ID_Rol;
        }

    }
}
