using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using Entidades;
using static Controladora.ControlAuditoria;

namespace Vista
{
   
    public partial class FormCompra : Form
    {
        private int RoleID;
        private int DNIEncontrado;
        private int CodigoEncontrado;
        private Compra compraActual = CompraActualContext.ObtenerCompraActual();
        private long IDCompra;
        private decimal precioCantidad;
        private decimal sumaTotal;
        private int DNIrol;
        private ControlUsuario controlUsuario = ControlUsuario.Instance;
        private ControlCompra controlCompra = ControlCompra.Instance;
        private ControlAuditoria controlAuditoria = ControlAuditoria.Instance;
        private ControlProducto controlProducto = ControlProducto.Instance;


        public FormCompra(int RoleID,int DNI)
        {
            InitializeComponent();
            this.RoleID = RoleID;
            this.DNIrol = DNI;
            cambiarForm(1);
            iniciartextbox();

        }
        
        private void iniciartextbox()
        {
            txtCantidad.Text = "1";
            lblCant.Text = "0";
            lblTotal.Text = "$ 0";
        }
       

        private void FormCompra_Load(object sender, EventArgs e)
        {
            InicializarDgv();
            CargarDetallesCompra();
           
        }
        private void CargarDetallesCompra()
        {
            List<DetalleCompra> detalles = controlCompra.ObtenerDetallesCompra(IDCompra);

            foreach (var detalle in detalles)
            {
                PasarDatos(detalle);
            }

            lblCant.Text = detalles.Count.ToString();
            sumaTotal = detalles.Sum(d => d.PrecioTotal);
            lblTotal.Text = sumaTotal.ToString("C");
        }

        private void InicializarDgv()
        {
            dgvDetalles.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dgvDetalles.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.DefaultCellStyle.ForeColor = Color.Black;

            // Asegúrate de que las columnas están configuradas correctamente
            dgvDetalles.Columns.Clear();
            dgvDetalles.Columns.Add("ID_Producto", "ID Producto");
            dgvDetalles.Columns.Add("NombreProducto", "Nombre del Producto");
            dgvDetalles.Columns.Add("Cantidad", "Cantidad");
            dgvDetalles.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvDetalles.Columns.Add("PrecioTotal", "Precio Total");
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDNI.Text, out int dni))
            {
                Usuario usuarioEncontrado = controlUsuario.BuscarUsuarioPorDNI(dni);

                if (usuarioEncontrado != null)
                {
                    if (usuarioEncontrado.ID_Estado == 1|| RoleID==1)
                    {
                        if (usuarioEncontrado.ID_Rol == 3)
                        {
                            // Mostrar información del usuario encontrado en tu formulario
                            // Puedes usar los TextBox u otros controles según tus necesidades
                            DNIEncontrado = usuarioEncontrado.DNI;
                         txtName.Text = usuarioEncontrado.Name;
                          txtMail.Text = usuarioEncontrado.Mail;
                        txtDireccion.Text = usuarioEncontrado.Direccion;
                         txtTelefono.Text = usuarioEncontrado.Telefono.ToString();
                    // ... (otros campos)
                        }
                          else
                         {
                                MessageBox.Show("Usuario no es un proveedor, porfavor chequea de vuelta ");
                            }

                    }
                    else
                    {
                        MessageBox.Show("usuario esta en estado baja, porfavor comunicarse con el admin");
                    }
                   
                    
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado en la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.");
            }
        }

        private void cambiarForm(int form)
        {
            if(form == 1)
            {
                panelCompra.Show();
                panelDetalle.Hide();
            }
            else
            {
                panelDetalle.Show();
                panelCompra.Hide();

            }
        }
        private void vaciarTextbox()
        {
            txtDNI.Text = string.Empty;
            txtName.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text=string.Empty;
            txtNombDetalle.Text = string.Empty;
            txtDescripcionDetalle.Text = string.Empty;
            txtPrecioDetalle.Text = string.Empty;
            lblTotal.Text = "$ 0";
            lblCant.Text = "0";
            txtCantidad.Text = "1";
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, busca y selecciona un usuario proveedor antes de generar una nueva compra.");
                return;
            }
            else
            {
                IDCompra=ObtenerIDCompraActual();
                Compra nuevoCompra = new Compra
                {
                    ID_Compra = IDCompra,
                    ID_Estado = 0,
                };
                int seRegistro = controlCompra.insertID(nuevoCompra);
                if(seRegistro == 1)
                {
                    cambiarForm(2);
                    IDCompra = nuevoCompra.ID_Compra;
                    sumaTotal = 0;
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
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

                Producto productoBuscado = new Producto { Codigo = codigoProducto };

                Producto productoEncontrado = controlProducto.BuscarProductoPorCodigo(productoBuscado);

                if (productoEncontrado != null)
                {
                    if (productoEncontrado.ID_Estado != 0|| RoleID==1)
                    {// Mostrar la información del producto en los controles correspondientes
                        CodigoEncontrado = int.Parse(txtCodigoDetalle.Text);
                        txtNombDetalle.Text = productoEncontrado.Name;
                        txtDescripcionDetalle.Text = productoEncontrado.Descripcion;
                        txtPrecioDetalle.Text = productoEncontrado.Price.ToString();
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
        private long ObtenerIDCompraActual()
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

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                int cantidad = int.Parse(txtCantidad.Text);
                decimal precioUnitario = Convert.ToDecimal(txtPrecioDetalle.Text);
                decimal precioTotal = cantidad * precioUnitario;

                DetalleCompra nuevoDetalle = new DetalleCompra
                {
                    ID_Compra = IDCompra, // Asigna el ID de la compra actual
                    ID_Producto = CodigoEncontrado, // Implementa tu lógica para obtener el ID del producto
                    NombreProducto = txtNombDetalle.Text,
                    Cantidad = cantidad,
                    PrecioUnitario = precioUnitario,
                };

                int seAgrego = controlCompra.AddDetalle(nuevoDetalle);
                if (seAgrego == 1)
                {
                    calcularPrecioCantidad(nuevoDetalle.Cantidad, nuevoDetalle.PrecioUnitario);
                    MessageBox.Show("Detalle agregado exitosamente a la compra.");
                    vaciarTextbox();
                    PasarDatos(nuevoDetalle);

                    // Actualizar los labels
                    lblCant.Text = dgvDetalles.Rows.Count.ToString();
                    lblTotal.Text = sumaTotal.ToString("C");
                }
                else
                {
                    MessageBox.Show("Error al insertar datos.");
                }
            }
            else
            {
                MessageBox.Show("Completa los campos, por favor.");
            }
        }


        private void calcularPrecioCantidad(int cantidad,decimal precio)
        {
            precioCantidad = cantidad* precio;
            sumaTotal += precioCantidad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Realiza las validaciones necesarias antes de cerrar la compra (si es necesario)

                // Pregunta al usuario para confirmar el cierre de la compra
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas cerrar la compra?",
                                                            "Confirmar Finalización",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Guarda la compra actual en la base de datos
                    controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, DNIrol, "Compra");
                    MessageBox.Show("Compra cerrada y registrada correctamente.");

                    Compra CerrarCompra = new Compra
                    {
                        ID_Compra = IDCompra,
                        Fecha = DateTime.Now,
                        ImporteTotal = sumaTotal,
                        ID_Proveedor = DNIEncontrado,
                        DNI_Usuario = DNIrol,
                        ID_Estado = 0,
                    };
                    int cerrarExito = controlCompra.CerrarCompra(CerrarCompra);
                    if (cerrarExito == 1)
                    {
                        dgvDetalles.Rows.Clear();
                        cambiarForm(1);
                        vaciarTextbox();
                        sumaTotal = 0;
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
        private void ReiniciarFormulario()
        {
            // Limpia los campos del formulario y reinicia las variables necesarias
            vaciarTextbox();
            compraActual = new Compra(); // Crea una nueva instancia para la próxima compra
                                         // Puedes agregar más reinicializaciones según tus necesidades
        }

        private void PasarDatos(DetalleCompra detalleCompra)
        {
            int n = dgvDetalles.Rows.Add();

            dgvDetalles.Rows[n].Cells[0].Value = detalleCompra.ID_Producto;
            dgvDetalles.Rows[n].Cells[1].Value = detalleCompra.NombreProducto;
            dgvDetalles.Rows[n].Cells[2].Value = detalleCompra.Cantidad;
            dgvDetalles.Rows[n].Cells[3].Value = detalleCompra.PrecioUnitario;
            dgvDetalles.Rows[n].Cells[4].Value = detalleCompra.PrecioTotal;
        }



        private void panelDetalle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminarDetalleCompra_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDetalles.SelectedRows)
                {
                    long idCompra = IDCompra;
                    int idProducto = Convert.ToInt32(row.Cells["ID_Producto"].Value);
                    decimal precioTotal = Convert.ToDecimal(row.Cells["PrecioTotal"].Value);

                    int eliminado = controlCompra.EliminarDetalleCompra(idCompra, idProducto);

                    if (eliminado == 1)
                    {
                        sumaTotal -= precioTotal;
                        dgvDetalles.Rows.Remove(row);

                        // Actualizar los labels
                        lblCant.Text = dgvDetalles.Rows.Count.ToString();
                        lblTotal.Text = sumaTotal.ToString("C");

                        MessageBox.Show("Detalle eliminado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el detalle de la base de datos.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un detalle para eliminar.");
            }
        }

    }
}
