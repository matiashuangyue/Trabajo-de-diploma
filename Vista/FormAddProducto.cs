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
    public partial class FormAddProducto : Form
    {
        private int RoleID;
        private int DNI;
        private ControlAuditoria controlAuditoria = ControlAuditoria.Instance;
        private ControlProducto controlProducto = ControlProducto.Instance;
        public FormAddProducto(int RoleID,int DNi)
        {
            InitializeComponent();
            this.RoleID = RoleID;
            this.DNI = DNI;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {

        }

        public void btnAddProducto_Click(object sender, EventArgs e)
        {
            if (txtCodProducto != null && !string.IsNullOrWhiteSpace(txtCodProducto.Text) &&
               txtNombProducto != null && !string.IsNullOrWhiteSpace(txtNombProducto.Text) &&
               txtDescripcion != null && !string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                Producto ProductoActual = new Producto();
                {
                    ProductoActual.Codigo = int.Parse(txtCodProducto.Text);
                    ProductoActual.Name = txtNombProducto.Text;
                    ProductoActual.Descripcion=txtDescripcion.Text;
                    ProductoActual.Price = 0;
                    ProductoActual.Stock = 0;
                    ProductoActual.ID_Estado = 1;
                }
                int registrarse = controlProducto.AddProducto(ProductoActual);
                if (registrarse == 1)
                {

                    MessageBox.Show("Ha Agregado nuevo producto con existo");

                    controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, DNI , "Gestionar Producto");
                }
                else if (registrarse == -1)
                {
                    MessageBox.Show("ya existe codigo de producto en base de datos");
                }
                else if (registrarse == -2)
                {
                    MessageBox.Show("error al insertar datos en sql");
                }
            }
            else
            {
                MessageBox.Show("¡Por favor, completa todos los campos!");
            }

        }
    }
}
