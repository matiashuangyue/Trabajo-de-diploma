using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Entidades;
using Controladora;

namespace Vista
{
    public partial class HomePage : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private FormCompra formCompra;

        public int rol;
        public int UserDNI;
        public HomePage(int RoleID,int DNI)
        {

            InitializeComponent();
            customizeDesign();
            this.rol = RoleID;
            this.UserDNI = DNI;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            IdentificarRol();
        }
        //para submenu
        private void customizeDesign()
        {
            panelControlSubmenu.Visible = false;
            panelProductoSubmenu.Visible = false;
            panelUsuarioSubmenu.Visible = false;
            panelInformeSubmenu.Visible = false;
        } 
     

  

        private void hideSubmenu()
        {
            if (panelUsuarioSubmenu.Visible == true)
            {
                panelUsuarioSubmenu.Visible=false;
            }
            if (panelProductoSubmenu.Visible == true)
            {
                panelProductoSubmenu.Visible = false;
            }
            if (panelControlSubmenu.Visible == true)
            {
                panelControlSubmenu.Visible = false;
            }
            if(panelInformeSubmenu.Visible == true)
            {
                panelInformeSubmenu.Visible = false;
            }
        }
        private void showSubmenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible=false;
            }
        }

        //identificar que rol
        public void IdentificarRol()
        {
            if(rol == -1)
            {
                lblRol.Text = "QUIEN SOS";
            }
            if (rol == 1)
            {
                lblRol.Text = "ADMIN";
            }
            if (rol == 2)
            {
                lblRol.Text = "Empleado";
            }
            if (rol == 3)
            {
                lblRol.Text = "Proveedor";
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(60, 120, 180);
            public static Color color2 = Color.FromArgb(220, 120, 10);
            public static Color color3 = Color.FromArgb(40, 75, 200);
            public static Color color4 = Color.FromArgb(200, 50, 100);
            public static Color color5 = Color.FromArgb(15, 130, 220);
            public static Color color6 = Color.FromArgb(150, 40, 200);
            public static Color color7 = Color.FromArgb(64, 168, 70);
        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(95, 158, 160);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor= color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign=ContentAlignment.MiddleRight;
                // Left border
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location= new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon current Chid Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(85, 148, 150);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
       

        private void OpenChidForm(Form childForm)
        {
            if(currentChildForm!= null)
            {
                // open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }



       

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChidForm(new FormProveedor(rol));
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChidForm(new FormControlStock(rol));
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChidForm(new FormAddUsuario(rol));
        }

        private void btnBaseDeDatos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChidForm(new FormInforme(rol));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();

        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.House;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            lblTitleChildForm.Text = "Home";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    private void btnVenta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChidForm(new FormVenta(rol));
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChidForm(new FormCompra(rol));
        }
    
  private void btnProducto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            showSubmenu(panelProductoSubmenu);
            
        }
        #region submenuProducto



        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            OpenChidForm(new FormAddProducto(rol));
            hideSubmenu();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            OpenChidForm(new FormModificacionesProducto(rol));
            hideSubmenu();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        #endregion

    private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            showSubmenu(panelUsuarioSubmenu);
        }
        #region submenuUsuario

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            OpenChidForm(new FormAddUsuario(rol));
            hideSubmenu();

        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            OpenChidForm(new FormModificacionesUsuario(rol,UserDNI));
            hideSubmenu();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
#endregion
     


        private void btnControlStock_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            showSubmenu(panelControlSubmenu);
        }
        #region submenuControlStock
        private void button4_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        #endregion


        private void btnInforme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            showSubmenu(panelInformeSubmenu);
        }
        #region submenuInforme
        private void btnInfo_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        #endregion

    }
}
