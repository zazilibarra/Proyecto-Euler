﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Euler
{
    public partial class Login : Form
    {
        string usuario;
        string password;

        public Login()
        {
            InitializeComponent();
            usuario = "";
            password = "";
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            usuario = tbUser.Text;
            password = tbUser.Text;
            

        }
    }
}