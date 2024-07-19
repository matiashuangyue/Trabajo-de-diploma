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


namespace Vista
{
    public partial class FormBusquedaProducto : Form
    {

        public Producto ProductoSeleccionado { get; private set; }
        private ControlProducto controlProducto;
        public FormBusquedaProducto()
        {
            InitializeComponent();
        }

        private void FormBusquedaProducto_Load(object sender, EventArgs e)
        {
            controlProducto = new ControlProducto();
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Producto> resultados = new List<Producto>();

            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                if (int.TryParse(txtCodigo.Text, out int codigo))
                {
                    Producto productoBuscado = new Producto { Codigo = codigo };
                    Producto productoEncontrado = controlProducto.BuscarProductoPorCodigo(productoBuscado);
                    if (productoEncontrado != null)
                    {
                        resultados.Add(productoEncontrado);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                resultados = controlProducto.BuscarProductosPorNombre(txtNombre.Text);
                
            }
            else 
            {
                MessageBox.Show("¡Por favor, ingrese un código o un nombre para buscar!");
                return;
            }
            dgvProductos.DataSource = resultados;
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e);
                e.Handled = true;  // Para evitar el sonido de error al presionar Enter
                e.SuppressKeyPress = true;
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e);
                e.Handled = true;  // Para evitar el sonido de error al presionar Enter
                e.SuppressKeyPress = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                ProductoSeleccionado = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Seleccione un producto.");
            }
        }
    }
}
