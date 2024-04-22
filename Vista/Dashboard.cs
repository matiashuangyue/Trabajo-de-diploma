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
    public partial class Dashboard : Form
    {
        private int RoleID;
        public Dashboard(int RoleID)
        {
            InitializeComponent();
            this.RoleID = RoleID;
            panel1.Height = 186;
            panel1.Width = 577;
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
