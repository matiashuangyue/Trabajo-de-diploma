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
        private decimal precioCompra=0;
        private decimal precioVenta=0;
        private ControlPedido controlPedido=new ControlPedido();
        private ControlUsuario controlUsuario=new ControlUsuario();
        private bool validarCliente;
        private decimal VentaTotal;
        private decimal NetosTotal;
        private int DNIrol;

        public FormVenta(int RoleID, int DNI)
        {
            InitializeComponent();
            this.RoleID = RoleID;
            vaciarTextbox();
            txtPorcentaje.Text = "0,4";
            txtCliente.Text = "0";
            btnCerrarVenta.Visible = false;
            lblCliente.Visible = true;
            txtCliente.Visible = true;
            this.DNIrol = DNI;
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {

            permiso();
            dgvDetalles .Columns[0].DefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);


            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                        txtNombre.Text = productoEncontrado.Name;
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

        private void ValidacionCliente()
        {
            if (btnCerrarVenta.Visible == false)
            {
                Usuario usuario = new Usuario
            {
                DNI=int.Parse(txtCliente.Text),
            };
            validarCliente = controlUsuario.Validar(usuario);
            if(validarCliente == false)
            {
               
            }
            else
            {
                MessageBox.Show("error cliente");
            }
            }
        }
        private void btnAgregarDetallePedido_Click(object sender, EventArgs e)
        {
            ValidacionCliente();
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCodigoDetalle.Text) || string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(txtPorcentaje.Text)||validarCliente==true)
            {
                MessageBox.Show("Por favor, busca un producto  antes de agregar.");
                return;
            }
            else
            {

                if (btnCerrarVenta.Visible == false)
                {
                    ValidacionCliente();
                    IDPedido = ObtenerIDPedidoActual();//aca esta error
                    Pedido nuevoPedido = new Pedido
                      {
                    ID_Pedido = IDPedido,
                    ID_Cliente=int.Parse(txtCliente.Text),
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
                        VentaTotal += nuevoDetalle.CantidadPrecio;
                        NetosTotal += precioCompra*cantidad;
                        MessageBox.Show("Detalle agregado exitosamente a la compra.");
                        vaciarTextbox();
                        btnCerrarVenta.Visible = true;
                        lblCliente.Visible = false;
                         txtCliente.Visible = false;
                        try
                        {
                        PasarDatos(nuevoDetalle);
                           // CargarDatos(nuevoDetalle);     no uso mas por que no comple bien la funcion
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

        private void PasarDatos(DetallePedido detallePedido)
        {
            int n= dgvDetalles.Rows.Add();

            dgvDetalles.Rows[n].Cells[0].Value = detallePedido.ID_Pedido;
            dgvDetalles.Rows[n].Cells[1].Value = detallePedido.ID_Producto;
            dgvDetalles.Rows[n].Cells[2].Value = detallePedido.Cantidad;
            dgvDetalles.Rows[n].Cells[3].Value = detallePedido.PrecioVenta;
            dgvDetalles.Rows[n].Cells[4].Value = detallePedido.CantidadPrecio;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarDatos(DetallePedido detallePediddo)                         //tengo que borrarlo
        {
            //dgwDetalles.DataSource = controlPedido.ObtenerDetallePedido(detallePediddo);
            DataTable dataTable = controlPedido.ObtenerDetallePedido(detallePediddo);

            // Suscribir el evento CellFormatting
            dgvDetalles.CellFormatting += (sender, e) =>
            {
                if (e.Value == DBNull.Value)
                {
                    e.Value = "Nulo"; // O el valor que desees mostrar para DBNull
                    e.FormattingApplied = true;
                }
            };

            dgvDetalles.DataSource = dataTable;
        }

        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas cerrar la Venta?",
                                                            "Confirmar Finalización",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Guarda la compra actual en la base de datos

                    MessageBox.Show("venta cerrada y registrada correctamente.");
                    Pedido cerrarPedido = new Pedido
                    {
                        ID_Pedido = IDPedido,
                        Fecha = DateTime.Now,
                        Importe = VentaTotal,
                        Netos = NetosTotal,
                        ID_Vendedor = DNIrol,
                        ID_Cliente = int.Parse(txtCliente.Text),
                        ID_Estado = 1,
                    };
                    int cerrarExito = controlPedido.cerrarPedido(cerrarPedido);
                    if (cerrarExito == 1)
                    {
                        btnCerrarVenta.Visible=false;
                        lblCliente.Visible=true;
                        txtCliente.Visible = true;
                        vaciarTextbox();
                        VentaTotal = 0;
                        NetosTotal = 0;
                        dgvDetalles.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("error al cerra compra");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Maneja la excepción de manera adecuada
            }
        }

        private void dgwDetalles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = Color.Black;

            if (e.RowIndex != -1 && e.Value == DBNull.Value)
            {
                e.Value = "Nulo"; // O el valor que desees mostrar para DBNull
                e.FormattingApplied = true;
            }
        }

        private void panelDetalle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
