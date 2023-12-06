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
    public partial class FormInfoCompra : Form
    {
        private int Rol;
        private int DNI;
        public FormInfoCompra(int rol, int dNI)
        {
            InitializeComponent();
            this.Rol = rol;
            this.DNI = dNI;
        }

        private void FormInfoCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trabajoDeDiplomaDataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.trabajoDeDiplomaDataSet.Compras);

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                // Establecer el color del texto en las celdas de encabezado a negro
                e.CellStyle.ForeColor = Color.Black;
            }
            else
            {
                // Establecer el color del texto en las celdas de datos a negro
                e.CellStyle.ForeColor = Color.Black;
            }
        }
    }
}
