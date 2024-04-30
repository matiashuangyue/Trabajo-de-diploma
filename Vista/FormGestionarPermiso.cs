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
using System.Data;

namespace Vista
{
    public partial class FormGestionarPermiso : Form
    {
        public Button BtnGuardarDetalle;
        private int Rol;
        private int DNI;
        private int Estado;
        // Declara una variable para almacenar los permisos seleccionados
        private List<string> permisosSeleccionados = new List<string>();
        public FormGestionarPermiso(int dni, int  rol)
        {
            
            InitializeComponent();
            CargarPermisos();
            CargarRoles();
            this.Rol = rol;
            this.DNI = dni;
            

        }
       

        private void CargarPermisos()
        {
            try
            {
                // Limpiar los datos existentes en el DataGridView
                dgvPermisos.Rows.Clear();
                
                // Obtener los permisos directamente desde la tabla en la base de datos
                List<string> permisos = ControlUsuario.ObtenerPermisos();

                // Verificar que la lista de permisos no esté vacía
                if (permisos != null && permisos.Count > 0)
                {
                    // Agregar los permisos al DataGridView
                    foreach (string permiso in permisos)
                    {
                        dgvPermisos.Rows.Add(false,permiso);
                       
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron permisos disponibles en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los permisos desde la base de datos: " + ex.Message);
            }
        }


       

        private void CargarRoles()
        {
            cbRoles.Items.Clear(); // Limpiar los elementos existentes en el ComboBox

            List<string> roles = ControlUsuario.ObtenerRoles(); // Obtener los roles disponibles desde la base de datos

            // Agregar los roles al ComboBox
            foreach (string rol in roles)
            {
                
                cbRoles.Items.Add(rol);
                
                lsbRoles.Items.Add(rol);
            }
        }

        private void btnGuardarDetalle_Click(object sender, EventArgs e)
        {
           
        }

        private void FormGestionarPermiso_Load(object sender, EventArgs e)
        {
          
        }

        private void btnCrearNuevoRol_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { // Verificar si la celda clicada es la columna de selección y si la fila es válida
            if (e.ColumnIndex == 0 && e.RowIndex >= 0 && e.RowIndex < dgvPermisos.Rows.Count)
            {
                // Obtener la celda correspondiente a la columna de selección en la fila clicada
                DataGridViewCell cell = dgvPermisos.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Verificar si la celda es una DataGridViewCheckBoxCell
                if (cell != null && cell is DataGridViewCheckBoxCell)
                {
                    DataGridViewCheckBoxCell checkBoxCell = cell as DataGridViewCheckBoxCell;

                    // Invertir el valor de la celda (marcar/desmarcar)
                    checkBoxCell.Value = !(bool)checkBoxCell.Value;

                    // Obtener el nombre del permiso de la celda siguiente en la misma fila
                    string permiso = dgvPermisos.Rows[e.RowIndex].Cells[1].Value?.ToString();

                    // Verificar si se ha seleccionado un permiso
                    if (!string.IsNullOrEmpty(permiso))
                    {
                        // Si la celda está marcada, agrega el permiso a la lista de permisos seleccionados
                        if ((bool)checkBoxCell.Value)
                        {
                            permisosSeleccionados.Add(permiso);
                        }
                        else
                        {
                            // Si la celda está desmarcada, remueve el permiso de la lista de permisos seleccionados
                            permisosSeleccionados.Remove(permiso);
                        }
                    }
                }
            }
        }
    }
}
