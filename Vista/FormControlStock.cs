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
    public partial class FormControlStock : Form
    {
        private int RoleID;
        public FormControlStock(int RoleID)
        {
            InitializeComponent();
            this.RoleID = RoleID;
        }

        private void FormControlStock_Load(object sender, EventArgs e)
        {

        }
    }
}
