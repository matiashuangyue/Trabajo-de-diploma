using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormPago : Form
    {

        public decimal MontoTotal { get; set; }
        public decimal MontoRecibido { get; private set; }
        public string MetodoPago { get; private set; }
        public bool PagoConfirmado { get; private set; }
        public decimal Cambio { get; private set; }

        public FormPago(decimal montoTotal)
        {
            InitializeComponent();
            this.Load += new System.EventHandler( this.FormPago_Load);
            this.CenterToScreen();
            MontoTotal = montoTotal;
            txtTotal.Text = $"Total: ${montoTotal}";
            PagoConfirmado = false;
        }

        private void FormPago_Load(object sender, EventArgs e)
        {
            txtSubtotal.Text = "$0.00";
            txtOfertas.Text = "$0.00";
            txtTotal.Text = $"$ {MontoTotal}";
            txtRestante.Text = $"$ {MontoTotal}";
            txtCambio.Text = "$0.00";
            txtEntrega.Focus();
          
            txtEntrega.KeyPress += AllowOnlyNumbers;
            
        }
        private void AllowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!rbEfectivo.Checked && !rbDebito.Checked && !rbCredito.Checked && !rbOtros.Checked)
            {
                MessageBox.Show("Seleccione un método de pago.");
                return;
            }

            if (rbEfectivo.Checked)
            {
                MetodoPago = "Efectivo";
            }
            else if (rbDebito.Checked)
            {
                MetodoPago = "Tarjeta de Débito";
            }
            else if (rbCredito.Checked)
            {
                MetodoPago = "Tarjeta de Crédito";
            }
            else if (rbOtros.Checked)
            {
                MetodoPago = "Otros";
            }
            if (string.IsNullOrEmpty(txtEntrega.Text))
            {
               txtEntrega.Text = MontoTotal.ToString();
               
            }
            if ( !decimal.TryParse(txtEntrega.Text, out decimal montoRecibido) || montoRecibido < MontoTotal)
            {
                MessageBox.Show("Ingrese un monto válido que sea mayor o igual al monto total.");
                return;
            }

            MontoRecibido = montoRecibido;
            Cambio = montoRecibido - MontoTotal;
            PagoConfirmado = true;
            Close();
        }

        private void txtEntrega_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtEntrega.Text, out decimal montoRecibido))
            {
                txtCambio.Text = $"Cambio: ${montoRecibido - MontoTotal}";
            }
            else
            {
                txtCambio.Text = "Cambio: $0.00";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PagoConfirmado = false;
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEntrega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();
            }
        }
    }
}
