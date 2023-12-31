﻿using System;
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
   
    public partial class FormCompra : Form
    {
        private int RoleID;
        private ControlUsuario controlUsuario = new ControlUsuario();
        private int DNIEncontrado;
        private int CodigoEncontrado;
        private Compra compraActual = CompraActualContext.ObtenerCompraActual();
        private long IDCompra;
        private ControlCompra controlCompra = new ControlCompra();
        private decimal precioCantidad;
        private decimal sumaTotal;
        private int DNIrol;


        public FormCompra(int RoleID,int DNI)
        {
            InitializeComponent();
            this.RoleID = RoleID;
            this.DNIrol = DNI;
            cambiarForm(1);
           
        }
        

       

        private void FormCompra_Load(object sender, EventArgs e)
        {

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
            txtCantidad.Text = string.Empty;
            txtPrecioDetalle.Text = string.Empty;
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

                ControlProducto controlProducto = new ControlProducto();
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
                DetalleCompra nuevoDetalle = new DetalleCompra
                {
                    ID_Compra = IDCompra, // Asigna el ID de la compra actual
                    ID_Producto = CodigoEncontrado, // Implementa tu lógica para obtener el ID del producto
                    Cantidad = cantidad,
                    PrecioUnitario = Convert.ToDecimal(txtPrecioDetalle.Text),
                };
                int seAgrego =controlCompra.AddDetalle(nuevoDetalle);
                if (seAgrego==1)
                {
                    calcularPrecioCantidad(nuevoDetalle.Cantidad, nuevoDetalle.PrecioUnitario);
                    MessageBox.Show("Detalle agregado exitosamente a la compra.");
                    vaciarTextbox();
                }
                else
                {
                    MessageBox.Show("error al insertar datos.");
                }

            }
            else
            {
                MessageBox.Show("Completa los campos porfavor");
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
        

    }
}
