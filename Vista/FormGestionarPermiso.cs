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
using System.Runtime.CompilerServices;
using static Controladora.ControlAuditoria;

namespace Vista
{
    public partial class FormGestionarPermiso : Form
    {
        private ControlUsuario controlUsuario = ControlUsuario.Instance;
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
            txtNombRol.TextChanged += txtNombRol_TextChanged;
            cbRoles.SelectedIndexChanged += cbRoles_SelectedIndexChanged;
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
                        dgvPermisosSegunRol.Rows.Add(false, permiso);
                        lsbPermisos.Items.Add(permiso);
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
            acomodardgv();
            esconderdgv();
        }
        private void acomodardgv()
        {
            dgvPermisos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPermisosSegunRol.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvPermisosSegunRol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void esconderdgv()
        {
            if (string.IsNullOrEmpty(txtNombRol.Text))
            {
                lblPermiso.Visible = false;
                dgvPermisos.Visible = false;
            }
            else
            {
                lblPermiso.Visible = true;
                dgvPermisos.Visible = true;
            }
        }

        private void LimpiarSeleccion()
        {
            // Desmarcar todas las casillas de verificación en el DataGridView
            foreach (DataGridViewRow fila in dgvPermisos.Rows)
            {
                fila.Cells[0].Value = false;
            }

            // Vaciar la lista de permisos seleccionados
            permisosSeleccionados.Clear();
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

         private void btnCrearNuevoRol_Click(object sender, EventArgs e)
          {
            // Verificar si se ingresó un nombre de rol
            if (!string.IsNullOrEmpty(txtNombRol.Text))
            {
                // Obtener el nombre del nuevo rol
                string nombreRol = txtNombRol.Text;

                // Mostrar un mensaje de confirmación al usuario
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea crear el nuevo rol?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar si el usuario confirmó la acción
                if (resultado == DialogResult.Yes)
                {
                    // Crear el nuevo rol en la base de datos
                    
                    int idRol = controlUsuario.CrearNuevoRol(nombreRol);

                    if (idRol > 0)
                    {
                        // Recorrer las filas del DataGridView para obtener los permisos seleccionados
                        foreach (DataGridViewRow fila in dgvPermisos.Rows)
                        {
                            // Verificar si la casilla de verificación está marcada en la fila actual
                            if (Convert.ToBoolean(fila.Cells[0].Value))
                            {
                                // Obtener el permiso de la segunda columna en la misma fila
                                string permiso = fila.Cells[1].Value?.ToString();

                                // Asociar el permiso seleccionado al nuevo rol en la base de datos
                                if (!string.IsNullOrEmpty(permiso))
                                {
                                    controlUsuario.AgregarPermisoARol(idRol, permiso);
                                }
                            }
                        }

                        // Limpiar la caja de texto y recargar los roles
                        txtNombRol.Clear();
                        CargarRoles();

                        // Limpiar la selección en el DataGridView
                        LimpiarSeleccion();

                        // Mostrar un mensaje de éxito
                        MessageBox.Show("Se ha creado el nuevo rol correctamente y se han asignado los permisos seleccionados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ControlAuditoria controlAuditoria = new ControlAuditoria();
                        controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, DNI, "Gestionar Permisos");
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el nuevo rol. Por favor, inténtalo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre para el nuevo rol.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombPermiso.Text))
            {
                // Obtener el nombre del nuevo permiso
                string nombrePermioso = txtNombPermiso.Text;

                // Mostrar un mensaje de confirmación al usuario
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea crear el nuevo permiso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado==DialogResult.Yes)
                {
                    int idPermiso = controlUsuario.CrearPermiso(nombrePermioso);
                    if (idPermiso > 0)
                    {
                        MessageBox.Show("Se ha creado el nuevo permiso correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPermisos();
                        ControlAuditoria controlAuditoria = new ControlAuditoria();
                        controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, DNI, "Gestionar Permisos");
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el nuevo perwmiso. Por favor, inténtalo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un nombre para el nuevo permiso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lblPermiso_Click(object sender, EventArgs e)
        {

        }

        private void txtNombRol_TextChanged(object sender, EventArgs e)
        {
            esconderdgv();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {// Obtener el rol seleccionado en cbRoles
            string rolSeleccionado = cbRoles.SelectedItem?.ToString();

            // Verificar que se haya seleccionado un rol
            if (!string.IsNullOrEmpty(rolSeleccionado))
            {
                // Obtener el ID del rol seleccionado
                int idRol = controlUsuario.ObtenerRolID(rolSeleccionado);

                // Verificar que se haya encontrado el ID del rol
                if (idRol != -1)
                {
                    // Obtener la lista de permisos asociados al rol seleccionado
                    List<string> permisos = ControlUsuario.ObtenerPermisosPorRol(idRol);

                    // Recorrer las filas de dgvPermisoSegunRol
                    foreach (DataGridViewRow fila in dgvPermisosSegunRol.Rows)
                    {
                        // Obtener el permiso de la segunda columna en la misma fila
                        string permiso = fila.Cells[1].Value?.ToString();

                        // Verificar si el permiso está en la lista de permisos asociados al rol seleccionado
                        bool tienePermiso = permisos.Contains(permiso);

                        // Actualizar la casilla de verificación en la primera columna según tenga el permiso o no
                        fila.Cells[0].Value = tienePermiso;
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID del rol seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificarPermisoDeRol_Click(object sender, EventArgs e)
        {
            // Obtener el rol seleccionado en cbRoles
            string rolSeleccionado = cbRoles.SelectedItem?.ToString();

            // Verificar que se haya seleccionado un rol
            if (!string.IsNullOrEmpty(rolSeleccionado))
            {
                // Obtener el ID del rol seleccionado
                int idRol = controlUsuario.ObtenerRolID(rolSeleccionado);

                // Verificar que se haya encontrado el ID del rol
                if (idRol != -1)
                {
                    // Crear una lista para almacenar los permisos asociados al rol
                    List<string> permisos = new List<string>();

                    // Recorrer las filas de dgvPermisosSegunRol
                    foreach (DataGridViewRow fila in dgvPermisosSegunRol.Rows)
                    {
                        // Obtener el permiso de la segunda columna en la misma fila
                        string permiso = fila.Cells[1].Value?.ToString();

                        // Verificar si el checkbox está marcado en la primera columna
                        bool tienePermiso = (bool)fila.Cells[0].Value;

                        // Si el checkbox está marcado, agregar el permiso a la lista
                        if (tienePermiso)
                        {
                            permisos.Add(permiso);
                        }
                        else
                        {
                            // Si el checkbox está desmarcado, eliminar el permiso de la lista si existe
                            permisos.Remove(permiso);
                        }
                    }

                    // Actualizar los permisos del rol en la base de datos
                    controlUsuario.ActualizarPermisosPorRol(idRol, permisos);
                    
                    MessageBox.Show("Los permisos del rol se han actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ControlAuditoria controlAuditoria = new ControlAuditoria();
                    controlAuditoria.RegistrarOperacion(AuditoriaGlobal.AuditoriaId, DNI, "Gestionar Permisos");
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID del rol seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un rol.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }



}
