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
    public partial class FormModificacionesProducto : Form
    {
        // Variable global para rastrear si se ha buscado un producto
        private bool ProductoHaEncontrado = false;
        private int RoleID;
        private int EstadoID;
        public FormModificacionesProducto(int RoleID)
        {
            InitializeComponent();
            this.RoleID = RoleID;
        }

        private void vaciarTextbox()
        {
            txtNombProducto.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            vaciarTextbox();

            if (string.IsNullOrEmpty(txtCodProducto.Text))
            {
                MessageBox.Show("Ingresar código de producto deseado por favor.");
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
                    if(productoEncontrado.ID_Estado != 0 )
                    {// Mostrar la información del producto en los controles correspondientes
                    txtNombProducto.Text = productoEncontrado.Name;
                    txtDescripcion.Text = productoEncontrado.Descripcion;
                    txtPrecio.Text = productoEncontrado.Price.ToString();
                    txtStock.Text = productoEncontrado.Stock.ToString();
                     cmbEstado.SelectedItem = "Alta";
                    // Establecer la variable de estado a true si se encontró el producto
                    ProductoHaEncontrado = true;
                    }
                    else
                    {
                        if ( RoleID == 1)
                        {
                            txtNombProducto.Text = productoEncontrado.Name;
                            txtDescripcion.Text = productoEncontrado.Descripcion;
                            txtPrecio.Text = productoEncontrado.Price.ToString();
                            txtStock.Text = productoEncontrado.Stock.ToString();
                            // Asignar el valor correspondiente al cmbEstado (alta o baja)
                            cmbEstado.SelectedItem = "Baja";
                        }
                        else
                        {
                            MessageBox.Show("Producto Buscado esta dado de baja, porfavor comunicarse con el admin ");
                            vaciarTextbox();
                           
                        }
                        
                    }

                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (CamposCompletados())
            {
                int codigoProducto;
                if (!int.TryParse(txtCodProducto.Text, out codigoProducto))
                {
                    MessageBox.Show("Por favor, ingresar un código de producto válido.");
                    return;
                }  
                // Modificar el producto usando la controladora
                ControlProducto controlProducto = new ControlProducto();
                Producto productoModificado = new Producto
                {
                    Codigo = codigoProducto,
                    Name = txtNombProducto.Text,
                    Descripcion = txtDescripcion.Text,
                    Price = Convert.ToDecimal(txtPrecio.Text),
                    Stock = Convert.ToInt32(txtStock.Text),
                    ID_Estado = EstadoID,
                };

                int resultado = controlProducto.ModificarProducto(productoModificado);

                if (resultado == 1)
                {
                    MessageBox.Show("Producto modificado correctamente.");
                }
                else if (resultado == -1)
                {
                    MessageBox.Show("No se puede modificar porque el código no es válido.");
                }
                else if (resultado == -2)
                {
                    MessageBox.Show("Error al modificar datos en SQL.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos antes de intentar modificar el producto.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (CamposCompletados())
            {
                if (ProductoHaEncontrado)
            {
                if (!string.IsNullOrEmpty(txtCodProducto.Text))
                {
                    int codigoProducto;
                    if (!int.TryParse(txtCodProducto.Text, out codigoProducto))
                    {
                        MessageBox.Show("Por favor, ingresar un código de producto válido.");
                        return;
                    }

                    ControlProducto controlProducto = new ControlProducto();
                    Producto productoAEliminar = new Producto { Codigo = codigoProducto };

                    // Confirmación adicional antes de eliminar
                    DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?",
                                                                "Confirmar Eliminación",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Question);

                    if (confirmacion == DialogResult.Yes)
                    {
                        vaciarTextbox();
                        int resultado = controlProducto.EliminarProducto(productoAEliminar);

                        if (resultado == 1)
                        {
                            
                            MessageBox.Show("Producto eliminado correctamente.");
                        }
                        else if (resultado == -1)
                        {
                            MessageBox.Show("No se encontró un producto con el código dado.");
                        }
                        else if (resultado == -2)
                        {
                            MessageBox.Show("Error al eliminar datos en SQL.");
                        }
                    }
                    // Si el usuario elige "No" en la confirmación, no se realiza la eliminación.
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa el código del producto que deseas eliminar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, primero busca el producto que deseas eliminar.");
            }

            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos antes de intentar modificar el producto.");
            }
          
        }

        

        private void estadoProducto()
        {
            if(cmbEstado.SelectedItem == "Alta")
            {
                EstadoID = 1;
            }
            else
            {
                EstadoID = 0;
            }
        }
        private bool CamposCompletados()
        {
            // Verifica que todos los campos estén completados
            return !string.IsNullOrEmpty(txtCodProducto.Text) &&
                   !string.IsNullOrEmpty(txtNombProducto.Text) &&
                   !string.IsNullOrEmpty(txtDescripcion.Text) &&
                   !string.IsNullOrEmpty(txtPrecio.Text) &&
                   !string.IsNullOrEmpty(txtStock.Text);
        }

        private void FormModificarProducto_Load(object sender, EventArgs e)
        {
            permiso();
            estadoProducto();
        }

        private void permiso()
        {
           
            if (RoleID != 1)
            {
                txtPrecio.Enabled = false;
                txtStock.Enabled = false;
                btnEliminar.Visible = false;
                lblEstado.Visible = false;
                cmbEstado.Visible=false;
            }
            else
            {
                if (RoleID == 1)
                {

                    txtPrecio.Enabled = true;
                    txtStock.Enabled = true;
                    btnEliminar.Visible=true;
                    lblEstado.Visible=true;
                    cmbEstado.Visible=true;
                    
                }

            }
        }
    }
}