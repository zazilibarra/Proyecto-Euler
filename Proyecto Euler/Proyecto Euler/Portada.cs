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
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void Portada_Load(object sender, EventArgs e)
        {

        }

        private void Portada_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu formMenu = new Menu();
            formMenu.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
