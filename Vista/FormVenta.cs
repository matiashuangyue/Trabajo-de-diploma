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
    public partial class FormVenta : Form
    {
        private int RoleID;
        private int CodigoEncontrado;
        private long IDPedido;
        private decimal porcentaje;
        private decimal precioCompra;
        private decimal precioVenta;
        private ControlPedido controlPedido=new ControlPedido();
        private decimal sumaTotal;

        public FormVenta(int RoleID)
        {
            InitializeComponent();
            this.RoleID = RoleID;
            vaciarTextbox();
            txtPorcentaje.Text = "0,4";
            btnCerrarVenta.Visible = false;
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            permiso();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            vaciarTextbox();
            if (string.IsNullOrEmpty(txtCodigoDetalle.Text))
            {
                MessageBox.Show("Ingresar código de producto deseado por favor.");
            }
            else
            {
                int codigoProducto;
                if (!int.TryParse(txtCodigoDetalle.Text, out codigoProducto))
                {
                    MessageBox.Show("Por favor, ingresar un código de producto válido.");
                    return;
                }

                ControlProducto controlProducto = new ControlProducto();
                Producto productoBuscado = new Producto { Codigo = codigoProducto };

                Producto productoEncontrado = controlProducto.BuscarProductoPorCodigo(productoBuscado);

                if (productoEncontrado != null)
                {
                    if (productoEncontrado.ID_Estado != 0 || RoleID == 1)
                    {// Mostrar la información del producto en los controles correspondientes
                        porcentaje=decimal.Parse(txtPorcentaje.Text);
                        precioCompra = Convert.ToDecimal( productoEncontrado.Price);
                        CodigoEncontrado = int.Parse(txtCodigoDetalle.Text);
                        txtNombDetalle.Text = productoEncontrado.Name;
                        precioVenta = precioCompra * (1 + porcentaje);
                        txtPrecioDetalleVenta.Text = (Math.Round(precioVenta, 2, MidpointRounding.AwayFromZero).ToString());
                        // Establecer la variable de estado a true si se encontró el producto
                    }
                    else
                    {
                        MessageBox.Show("Producto Buscado esta dado de baja, porfavor comunicarse con el admin ");
                        vaciarTextbox();

                    }

                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
        }

        private long ObtenerIDPedidoActual()
        {
            // Utilizar la fecha y hora actual para generar un identificador único
            // Puedes ajustar el formato según tus necesidades
            string formatoID = "yyyyMMddHHmmss";
            string idCompra = DateTime.Now.ToString(formatoID);

            // Convertir el ID a un valor numérico (opcional, dependiendo de tu implementación en la base de datos)
            if (long.TryParse(idCompra, out long resultado))
            {
                return resultado;
            }
            else
            {
                // Manejar el caso en el que la conversión no sea exitosa
                // Podrías lanzar una excepción, retornar un valor predeterminado, etc.
                return 0; // Valor predeterminado, ajusta según tu lógica
            }
        }

        private void vaciarTextbox()
        {
            txtCantidad.Text=String.Empty;
            txtNombDetalle.Text = string.Empty;
            txtPrecioDetalleVenta.Text = string.Empty;
        }




        private void permiso()
        {
            if (RoleID == 1)
            {
                lblPorcentaje.Visible = true;
                txtPorcentaje.Visible =true;
            }
            else
            {
                lblPorcentaje.Visible = false;
                txtPorcentaje.Visible = false;
                
            }
        }

        private void btnAgregarDetallePedido_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombDetalle.Text) || string.IsNullOrEmpty(txtCodigoDetalle.Text) || string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(txtPorcentaje.Text))
            {
                MessageBox.Show("Por favor, busca un producto  antes de agregar.");
                return;
            }
            else
            {
                if (btnCerrarVenta.Visible == false)
                {  
                    IDPedido = ObtenerIDPedidoActual();//aca esta error
                    Pedido nuevoPedido = new Pedido
                      {
                    ID_Pedido = IDPedido,
                    ID_Estado = 0,
                        };
                int seRegistro = controlPedido.inserID(nuevoPedido);
                    if(seRegistro == 1)
                    {
                        IDPedido = nuevoPedido.ID_Pedido;
                    }
                    else
                    {
                        MessageBox.Show("error al insertar IDPedido al Pedidos.");
                    }
                }
              
                
               
                   
                    int cantidad = int.Parse(txtCantidad.Text);
                    DetallePedido nuevoDetalle = new DetallePedido
                    {
                        ID_Pedido = IDPedido, // Asigna el ID de la compra actual
                        ID_Producto = CodigoEncontrado, // Implementa tu lógica para obtener el ID del producto
                        Cantidad = cantidad,
                        PrecioVenta = Convert.ToDecimal(txtPrecioDetalleVenta.Text),
                        CantidadPrecio = cantidad * precioVenta,
                    };
                    int seAgrego = controlPedido.registrarDetalles(nuevoDetalle);
                    if (seAgrego == 1)
                    {

                        MessageBox.Show("Detalle agregado exitosamente a la compra.");
                        vaciarTextbox();
                        btnCerrarVenta.Visible = true;
                        try
                        {
                            CargarDatos(nuevoDetalle);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            MessageBox.Show("no es posible de cargar la tabla");
                        }
                    }
                    else
                    {
                        MessageBox.Show("error al insertar detallepedidos  ");
                    }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarDatos(DetallePedido detallePediddo)
        {
            dgwDetalles.DataSource = controlPedido.ObtenerDetallePedido(detallePediddo);
        }
    }
}
