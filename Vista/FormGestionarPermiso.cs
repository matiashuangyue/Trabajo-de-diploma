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
        
        public FormGestionarPermiso(int dni, int  rol)
        {
            
            InitializeComponent();
            CargarPermisos();
            CargarRoles();
            this.Rol = rol;
            this.DNI = dni;
            

        }
        private void defaut()
        {
          
            for (int i = 0; i < clbPermisos.Items.Count; i++)
            {
                clbPermisos.SetItemChecked(i, false);
            }
           
        }
        
        private void CargarPermisos()
        {
            // Limpiar los elementos existentes en el CheckedListBox
            clbPermisos.Items.Clear();

            // Obtener los permisos disponibles desde la base de datos
            List<string> permisos = ControlUsuario.ObtenerPermisos ();

            // Agregar los permisos al checkedListBoxPermisos
            foreach (string permiso in permisos)
            {
                clbPermisos.Items.Add(permiso);
                
              
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
            // Verificar si se ingresó un nombre de rol
            if (!string.IsNullOrEmpty(txtNombRol.Text))
            {
                // Crear el nuevo rol en la base de datos
                string nombreRol = txtNombRol.Text;
                ControlUsuario controlUsuario = new ControlUsuario();
                int idRol = controlUsuario.CrearNuevoRol(nombreRol);

                if (idRol > 0)
                {
                    // Obtener los permisos seleccionados
                    List<string> permisosSeleccionados = new List<string>();
                    foreach (var item in clbPermisos.CheckedItems)
                    {
                        permisosSeleccionados.Add(item.ToString());
                    }

                    // Asociar los permisos seleccionados al nuevo rol en la base de datos
                    foreach (string permiso in permisosSeleccionados)
                    {
                        controlUsuario.AgregarPermisoARol(idRol, permiso);
                    }

                    MessageBox.Show("Se ha creado el nuevo rol correctamente y se han asignado los permisos seleccionados.");
                }
                else
                {
                    MessageBox.Show("Error al crear el nuevo rol. Por favor, inténtalo nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre para el nuevo rol.");
            }
        }
    }
}
