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
    public partial class FormAddProducto : Form
    {
        private int RoleID;
        public FormAddProducto(int RoleID)
        {
            InitializeComponent();
            this.RoleID = RoleID;
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
                }
                Controladora.ControlProducto Product = new  Controladora.ControlProducto();
                int registrarse = Product.AddProducto(ProductoActual);
                if (registrarse == 1)
                {

                    MessageBox.Show("Ha Agregado nuevo producto con existo");
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
