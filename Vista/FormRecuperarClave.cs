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
    public partial class FormRecuperarClave : Form
    {
        private int DNI;
        public FormRecuperarClave(int DNI)
        {
            InitializeComponent();
            this.DNI = DNI;
            
        }
        
        private void CargarDatos()
        {
            if(DNI != -1)
            {
                txtDNI.Text = DNI.ToString();
            }
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
