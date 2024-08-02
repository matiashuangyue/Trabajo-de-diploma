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
    public partial class FormResguardoyRestauracion : Form
    {
        private int Rol;
        private int DNI;
        private ControlBackUp controlBackUp = new ControlBackUp();
        private ControlAuditoria controlAuditoria = ControlAuditoria.Instance;
        public FormResguardoyRestauracion(int dni, int rol)
        {
            InitializeComponent();
            this.Rol = rol;
            this.DNI = dni;
            txtRuta.Text= "D:\\BackUp-TrabajoDeDiploma";
        }

        private void btnResguardo_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Se realizará el resguardo de la base de datos. Por favor, Confirma sus accion.", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // User clicked Yes
                    string Ruta = txtRuta.Text;
                    int exito = controlBackUp.RealizarBackUp(Ruta);
                    string posicion = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + " StarCG BackUp");
                    if (exito == 1)
                    {

                        MessageBox.Show("Resguardo realizado correctamente. En: " + Ruta + posicion);
                        controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, DNI, "Resguardo y Restauracion");
                    }
                    else
                    {
                        MessageBox.Show("Error al realizar el resguardo de la base de datos.");

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar el resguardo de la base de datos: " + ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                // User clicked No
                MessageBox.Show("Operación cancelada.");
            }


          
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog1.SelectedPath;
                txtRuta.Text = folderPath;
                // Use folderPath as needed
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                txtArchivo.Text = file;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtArchivo.Text))
            {
                MessageBox.Show("Por favor, seleccione un archivo para realizar la restauración de la base de datos.");
                return;
            }
            DialogResult firstConfirmation = MessageBox.Show("Se realizará el RESTORE de la base de datos. Por favor, confirme su acción.", "Primera Confirmación", MessageBoxButtons.YesNo);
            if (firstConfirmation == DialogResult.Yes)
            {
                DialogResult secondConfirmation = MessageBox.Show("¿Está seguro que desea continuar con el RESTORE de la base de datos?", "Segunda Confirmación", MessageBoxButtons.YesNo);
                if (secondConfirmation == DialogResult.Yes)
                {
                    DialogResult thirdConfirmation = MessageBox.Show("¿Ya realizaste el BACKUP de la base de datos Actual?", "Ultima Confirmación", MessageBoxButtons.YesNo);
                    if (thirdConfirmation == DialogResult.Yes)
                    {
                        try
                        {
                            string rutaArchivo = txtArchivo.Text;
                            int exito = controlBackUp.RealizarRestore(rutaArchivo);
                            if (exito == 1)
                            {
                                MessageBox.Show("Restauración realizada correctamente.");
                                controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, DNI, "Resguardo y Restauracion");
                            }
                            else
                            {
                                MessageBox.Show("Error al realizar la restauración de la base de datos.");
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al realizar el RESTORE de la base de datos: " + ex.Message);
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Por favor, realice el BACKUP de la base de datos antes de continuar.");
                    }
                }
                else
                {
                    MessageBox.Show("Operación cancelada.");
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }

        }
    }
}
