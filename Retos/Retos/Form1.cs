using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //triplete();
        }

        public void determinaPrimos()
        {
            int limite = 100;
            int aux;
            int sum = 0;
            for (int i = 1; i < limite + 1; i++)
            {
                aux = 0;
                for (int j = 1; j < i + 1; j++)
                {
                    if (i % j == 0)
                    {
                        aux++;
                    }
                }
                if (aux == 2)
                {
                    listBox1.Items.Add(i);
                    sum += i;
                }
            }
            MessageBox.Show("La suma de los numeros primos hasta " + limite + " es: " + sum);
        }

        public void multiplos()
        {
            int limite = 100;
            int sum = 0;
            for (int i = 1; i < limite; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    listBox1.Items.Add(i);
                    sum += i;
                }
            }
            MessageBox.Show("La suma de los numeros multiplos de 3 y 5 hasta " + limite + " es: " + sum);
        }

        public void fibonacci()
        {
            int limite = 100;
            int aux = 0;
            int a = 0;
            int b = 1;
            int sum = 0;
            for (int i = 0; b < limite; i++)
            {
                if (b % 2 == 0)
                {
                    sum += b;
                    listBox1.Items.Add(b);
                }
                aux = a;
                a = b;
                b = aux + a;
            }
            MessageBox.Show("La suma de los numeros pares de la serie Fibonacci hasta " + limite + " es: " + sum);
        }

        public void divisor()
        {
            int limite = 20;
            int aux = 0;
            int i = 1;
            for (; ; i++)
            {
                aux = 0;
                for (int j = 1; j < limite + 1; j++)
                {
                    if (i % j == 0)
                    {
                        aux++;
                    }
                }
                if (aux == limite)
                {
                    break;
                }
            }
            MessageBox.Show(i.ToString());
        }

        //public void triplete()
        //{
        //    int sum = 100;
        //    int a = 0;
        //    int b = 0;
        //    int c = 0;
        //    bool bandera = true;
        //    while (bandera)
        //    {
        //        a++;
        //        for()
        //    }
        //    MessageBox.Show(i.ToString());
        //}
    }
}
