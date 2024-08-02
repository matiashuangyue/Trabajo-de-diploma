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
    public partial class FormVenta : Form
    {
        private int RoleID;
        private int CodigoEncontrado;
        private long IDPedido;
        private decimal porcentaje;
        private decimal precioCompra = 0;
        private decimal precioVenta = 0;
        private ControlPedido controlPedido = new ControlPedido();
        private ControlUsuario controlUsuario = ControlUsuario.Instance;
        private ControlAuditoria controlAuditoria = ControlAuditoria.Instance;
        private ControlProducto controlProducto = ControlProducto.Instance;
        private bool validarCliente;
        private decimal VentaTotal;
        private decimal NetosTotal;
        private int DNIrol;

        private const string ClienteDefecto = "CONSUMIDOR FINAL(INGRESE ID USUARIO)";
        private List<Producto> productosEnVenta;

        public FormVenta(int RoleID, int DNI)
        {
            InitializeComponent();
            

            this.RoleID = RoleID;
            vaciarTextbox();
            txtPorcentaje.Text = "0.4";
            txtCantidad.Text = "1";
            txtCliente.Text = ClienteDefecto;
            lblCant.Text = "0";
            lblTotal.Text = "$ 0";
            lblCambio.Text = "Cambio: $0.00";
            btnCerrarVenta.Visible = false;
            btnEliminarDetalle.Visible = false;
            lblCliente.Visible = true;
            txtCliente.Visible = true;
            this.DNIrol = DNI;
            txtCodigoDetalle.KeyPress += AllowOnlyNumbers;
            txtCantidad.KeyPress += AllowOnlyNumbers;
            // Event handlers for txtCliente
            txtCliente.GotFocus += TxtCliente_GotFocus;
            txtCliente.LostFocus += TxtCliente_LostFocus;

            this.KeyPreview = true;

            productosEnVenta = new List<Producto>();
        }
     private void AllowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
        private void TxtCliente_GotFocus(object sender, EventArgs e)
        {
            if (txtCliente.Text == ClienteDefecto)
            {
                txtCliente.Text = string.Empty;
                txtCliente.ForeColor = Color.Black;
            }
        }

        private void TxtCliente_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                txtCliente.Text = "0";
                txtCliente.ForeColor = Color.Gray;
            }
        }

        private int CantidadTotal = 0;

        private void FormVenta_Load(object sender, EventArgs e)
        {
            dgvDetalles.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            permiso();


            txtCodigoDetalle.Focus();// Enfoca el textbox de código de producto al cargar el formulario
            // Opcionalmente, selecciona todo el texto
            txtCodigoDetalle.SelectAll();
        }

   

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            
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
                    vaciarTextbox();
                    return;
                }

                Producto productoBuscado = new Producto { Codigo = codigoProducto };

                Producto productoEncontrado = controlProducto.BuscarProductoPorCodigo(productoBuscado);

                if (productoEncontrado != null)
                {
                    if (productoEncontrado.ID_Estado != 0 || RoleID == 1)
                    {
                        porcentaje = decimal.Parse(txtPorcentaje.Text);
                        precioCompra = Convert.ToDecimal(productoEncontrado.Price);
                        CodigoEncontrado = int.Parse(txtCodigoDetalle.Text);
                        txtNombre.Text = productoEncontrado.Name;
                        precioVenta = precioCompra * (1 + porcentaje);
                        txtPrecioDetalleVenta.Text = (Math.Round(precioVenta, 2, MidpointRounding.AwayFromZero).ToString());
                    }
                    else
                    {
                        MessageBox.Show("Producto Buscado está dado de baja, por favor comuníquese con el admin.");
                        vaciarTextbox();
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                    vaciarTextbox();
                }
            }
          
        }

        private long ObtenerIDPedidoActual()
        {
            string formatoID = "yyyyMMddHHmmss";
            string idCompra = DateTime.Now.ToString(formatoID);

            if (long.TryParse(idCompra, out long resultado))
            {
                return resultado;
            }
            else
            {
                return 0;
            }
        }

        private void vaciarTextbox()
        {
            txtCantidad.Text = "1";
            txtNombDetalle.Text = string.Empty;
            txtCodigoDetalle.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrecioDetalleVenta.Text = string.Empty;

        }

        private void permiso()
        {
            if (RoleID == 1)
            {
                lblPorcentaje.Visible = true;
                txtPorcentaje.Visible = true;
            }
            else
            {
                lblPorcentaje.Visible = false;
                txtPorcentaje.Visible = false;
            }
            if(txtCliente.Visible == false)
            {
                lblCant.Text = "0";
                lblTotal.Text = "$ 0";
                lblCambio.Text = "Cambio: $0.00";
            }
            
        }

        private void ValidacionCliente()
        {
            if (btnCerrarVenta.Visible == false)
            {
                if(txtCliente.Text== ClienteDefecto)
                {
                    txtCliente.Text = "0";
                }
                Usuario usuario = new Usuario
                {
                    DNI = int.Parse(txtCliente.Text),
                };
                validarCliente = controlUsuario.Validar(usuario);
                if (validarCliente == false)
                {
                }
                else
                {
                    MessageBox.Show("Error cliente");
                }
            }
        }

        private void btnAgregarDetallePedido_Click(object sender, EventArgs e)
        {
            ValidacionCliente();
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCodigoDetalle.Text) || string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(txtPorcentaje.Text) || validarCliente == true)
            {
                MessageBox.Show("Por favor, busca un producto antes de agregar.");
                return;
            }
            else
            {
                if (btnCerrarVenta.Visible == false)
                {
                    ValidacionCliente();
                    IDPedido = ObtenerIDPedidoActual();
                    Pedido nuevoPedido = new Pedido
                    {
                        ID_Pedido = IDPedido,
                        ID_Cliente = int.Parse(txtCliente.Text),
                        ID_Estado = 0,
                    };
                    int seRegistro = controlPedido.inserID(nuevoPedido);
                    if (seRegistro == 1)
                    {
                        IDPedido = nuevoPedido.ID_Pedido;
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar IDPedido al Pedidos.");
                    }
                }

                int cantidad = int.Parse(txtCantidad.Text);
                decimal precioVenta = Convert.ToDecimal(txtPrecioDetalleVenta.Text);
                decimal cantidadPrecio = cantidad * precioVenta;

                DetallePedido nuevoDetalle = new DetallePedido
                {
                    ID_Pedido = IDPedido,
                    ID_Producto = Convert.ToInt32(txtCodigoDetalle.Text),
                    Cantidad = cantidad,
                    PrecioVenta = precioVenta,
                    CantidadPrecio = cantidadPrecio,
                };

                int seAgrego = controlPedido.registrarDetalles(nuevoDetalle);
                if (seAgrego == 1)
                {
                    nuevoDetalle.DetalleID = controlPedido.ObtenerUltimoDetalleID();

                    VentaTotal += nuevoDetalle.CantidadPrecio;
                    NetosTotal += precioCompra * cantidad;
                    CantidadTotal += nuevoDetalle.Cantidad;
                    MessageBox.Show("Detalle agregado exitosamente a la compra.");
                    vaciarTextbox();
                    btnCerrarVenta.Visible = true;
                    btnEliminarDetalle.Visible = true;
                    lblCliente.Visible = false;
                    txtCliente.Visible = false;

                    try
                    {
                        PasarDatos(nuevoDetalle);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("No es posible de cargar la tabla");
                    }

                    lblCant.Text = CantidadTotal.ToString();
                    lblTotal.Text = "$" + VentaTotal.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Error al insertar detallepedidos.");
                }
            }
        }


        private void PasarDatos(DetallePedido detallePedido)
        {
            int n = dgvDetalles.Rows.Add();

            dgvDetalles.Rows[n].Cells[0].Value = detallePedido.ID_Pedido;
            dgvDetalles.Rows[n].Cells[1].Value = detallePedido.ID_Producto;
            dgvDetalles.Rows[n].Cells[2].Value = detallePedido.Cantidad;
            dgvDetalles.Rows[n].Cells[3].Value = detallePedido.PrecioVenta;
            dgvDetalles.Rows[n].Cells[4].Value = detallePedido.CantidadPrecio;
            dgvDetalles.Rows[n].Cells[5].Value = detallePedido.DetalleID;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
                    FormPago formPago = new FormPago(VentaTotal);
                    formPago.ShowDialog();

                    if (!formPago.PagoConfirmado)
                    {
                        return;
                    }

                    // Actualizar ID del pedido según el método de pago
                    string metodoPago = formPago.MetodoPago;
                    decimal montoRecibido = formPago.MontoRecibido;

                    controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, DNIrol, "Venta");

                    Pedido cerrarPedido = new Pedido
                    {
                        ID_Pedido = IDPedido,
                        Fecha = DateTime.Now,
                        Importe = VentaTotal,
                        Netos = NetosTotal,
                        ID_Vendedor = DNIrol,
                        ID_Cliente = int.Parse(txtCliente.Text),
                        ID_Estado = 1,
                        MetodoPago = metodoPago // Guardar el método de pago
                    };

                    int cerrarExito = controlPedido.cerrarPedido(cerrarPedido);
                    if (cerrarExito == 1)
                    {
                        // Muestra el cambio en lblCambio
                        lblCambio.Text = $"Cambio: ${formPago.Cambio}";

                        MessageBox.Show($"Venta cerrada y registrada correctamente. Cambio: ${montoRecibido - VentaTotal}");

                        btnCerrarVenta.Visible = false;
                        btnEliminarDetalle.Visible = false;
                        lblCliente.Visible = true;
                        txtCliente.Visible = true;
                        vaciarTextbox();
                        CantidadTotal = 0;
                        VentaTotal = 0;
                        NetosTotal = 0;
                        dgvDetalles.Rows.Clear();
                        txtCliente.Text = ClienteDefecto;
                    }
                    else
                    {
                        MessageBox.Show("Error al cerrar la compra.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgwDetalles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = Color.Black;

            if (e.RowIndex != -1 && e.Value == DBNull.Value)
            {
                e.Value = "Nulo";
                e.FormattingApplied = true;
            }
        }

        private void panelDetalle_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCodigoDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDetalles.SelectedRows[0];
                long detalleID = Convert.ToInt64(selectedRow.Cells["DetalleID"].Value);

                int result = controlPedido.EliminarDetallePedido(detalleID);

                if (result > 0)
                {
                    dgvDetalles.Rows.Remove(selectedRow);
                    MessageBox.Show("Detalle del pedido eliminado exitosamente.");

                    ActualizarTotales();

                    if (lblCant.Text == "0")
                    {
                        ReiniciarPedido();
                    }
                }
                else
                {
                    MessageBox.Show("Error al eliminar el detalle del pedido.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un detalle del pedido para eliminar.");
            }
        }

        private void ActualizarTotales()
        {
            VentaTotal = 0;
            CantidadTotal = 0;
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                VentaTotal += Convert.ToDecimal(row.Cells[4].Value); // CantidadPrecio
                CantidadTotal += Convert.ToInt32(row.Cells[2].Value); // Cantidad
            }

            lblCant.Text = CantidadTotal.ToString();
            lblTotal.Text = "$" + VentaTotal.ToString("F2");
        }


        private void FormVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                AbrirFormularioBusqueda();
            }
            if(e.KeyCode == Keys.Space)
            {
                if(btnCerrarVenta.Visible == true)
                {
                    btnCerrarVenta_Click(this, EventArgs.Empty);
                }
            }
        }
        private void AbrirFormularioBusqueda()
        {
            FormBusquedaProducto formBusqueda = new FormBusquedaProducto();
            if (formBusqueda.ShowDialog() == DialogResult.OK)
            {
                Producto productoSeleccionado = formBusqueda.ProductoSeleccionado;
                if (productoSeleccionado != null)
                {
                    txtCodigoDetalle.Text = productoSeleccionado.Codigo.ToString();
                    txtNombre.Text = productoSeleccionado.Name;

                    decimal precioCompra = productoSeleccionado.Price ?? 0; // Usar 0 si el precio es null
                    decimal porcentaje = decimal.Parse(txtPorcentaje.Text);
                    decimal precioVenta = precioCompra * (1 + porcentaje);
                    txtPrecioDetalleVenta.Text = Math.Round(precioVenta, 2, MidpointRounding.AwayFromZero).ToString();

                    // Asegúrate de que todos los campos necesarios estén completos antes de agregar el detalle
                    if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtCodigoDetalle.Text) && !string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtPorcentaje.Text))
                    {
                        // Llama directamente al método de agregar detalle
                        btnAgregarDetallePedido_Click(this, EventArgs.Empty);
                    }
                }
            }
        }


        private void ReiniciarPedido()
        {
            btnCerrarVenta.Visible = false;
            btnEliminarDetalle.Visible = false;
            lblCliente.Visible = true;
            txtCliente.Visible = true;
            vaciarTextbox();
            CantidadTotal = 0;
            VentaTotal = 0;
            NetosTotal = 0;
            dgvDetalles.Rows.Clear();
            txtCliente.Text = ClienteDefecto;
            IDPedido = 0; // Reiniciar el ID del pedido
            lblCant.Text = "0";
            lblTotal.Text = "$ 0";
            lblCambio.Text = "Cambio: $0.00";

            // Opcional: si necesitas eliminar el pedido de la base de datos
            if (IDPedido != 0)
            {
                controlPedido.EliminarPedido(IDPedido);
                
            }
        }

        private void FormVenta_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (btnCerrarVenta.Visible == true)
            {
                ReiniciarPedido();
                controlPedido.EliminarPedidosInutiles();
                MessageBox.Show("Venta cancelada.");
            }

        }
    }
}
