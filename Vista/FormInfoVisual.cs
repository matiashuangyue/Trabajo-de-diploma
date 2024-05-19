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
    public partial class FormInfoVisual : Form
    {
        private int Rol;
        private int DNI;
        public FormInfoVisual(int dni, int rol)
        {
            InitializeComponent();
            this.Rol = rol;
            this.DNI = dni;
        }

        private void FormInfoVisual_Load(object sender, EventArgs e)
        {

        }
    }
}
