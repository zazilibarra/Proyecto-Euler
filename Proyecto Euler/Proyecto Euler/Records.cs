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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void Records_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu formMenu = new Menu();
            formMenu.ShowDialog();
        }

        private void Records_Load(object sender, EventArgs e)
        {

        }
    }
}
