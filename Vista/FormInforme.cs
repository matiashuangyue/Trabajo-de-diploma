﻿using System;
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
    public partial class FormInforme : Form
    {
        private int RoleID;
        public FormInforme(  int RoleID)
        {
            InitializeComponent();
            RoleID=this.RoleID;
        }
    }
}
