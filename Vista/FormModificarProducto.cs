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
    public partial class FormModificarProducto : Form
    {
        public FormModificarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodProducto.Text))
            {
                MessageBox.Show("ingresar codigo de producto deseado porfavor");
            }
            else
            {
                int codigoProducto;
                if (!int.TryParse(txtCodProducto.Text, out codigoProducto))
                {
                    MessageBox.Show("Por favor, ingresar un código de producto válido.");
                    return;
                }

                ControlProducto controlProducto = new ControlProducto();
                Producto productoBuscado = new Producto { Codigo = codigoProducto };

                Producto productoEncontrado = controlProducto.BuscarProductoPorCodigo(productoBuscado);

                if (productoEncontrado != null)
                {
                    // Mostrar la información del producto en los controles correspondientes
                    txtNombProducto.Text = productoEncontrado.Name;
                    txtDescripcion.Text = productoEncontrado.Descripcion;
                    txtPrecio.Text = productoEncontrado.Price.ToString();
                    txtStock.Text = productoEncontrado.Stock.ToString();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
        }
    }
}
