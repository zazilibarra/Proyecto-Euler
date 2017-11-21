using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

            #region WRITE
            try
            {
                string[] lines = { "First line", "Second line", "Third line" };

                using (StreamWriter file = new StreamWriter(@"Files\WriteLines.txt"))
                {
                    foreach (string line in lines)
                    {
                        //if (!line.Contains("Second"))
                        file.WriteLine(line);
                    }
                }

                using (StreamWriter file = new StreamWriter(@"Files\WriteLines.txt", true))
                {
                    file.WriteLine("Fourth line");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            #endregion

            #region READ
            try
            {
                int counter = 0;
                string oneline;

                // Read the file and display it line by line.  
                StreamReader fileRead = new StreamReader(@"Files\WriteLines.txt");
                while ((oneline = fileRead.ReadLine()) != null)
                {
                    MessageBox.Show(oneline);
                    counter++;
                }

                fileRead.Close();
                MessageBox.Show("There were " + counter + " lines.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            #endregion
        }
    }
}
