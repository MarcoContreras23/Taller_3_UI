
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Taller_3
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Variables
            DateTime ini, fin;
            System.TimeSpan dur;
            bool esPrimo = false;
            long num =long.Parse(numericUpDown1.Text);
            //9223372036854775783
            Thread[] tr = new Thread[3];
            ini = DateTime.Now;
            esPrimo = NumberPrime.isPrime(num);
            fin = DateTime.Now;
            dur = fin.Subtract(ini);


            tr[0] = new Thread(() => NumberPrime.firstDivGreaterThan(num));
            tr[1] = new Thread(() => NumberPrime.firstDivMiddle(num));
            tr[2] = new Thread(() => NumberPrime.isPrime(num));

            foreach (var thread in tr)
            {
                thread.Start();
                thread.Join();
            }

            if (esPrimo)
            {
                string numero = num.ToString();
                string rta = numero + " Es primo";
                label2.Text = rta;
                string tiempo = dur.ToString();
                label3.Text = tiempo;
            }
            else
            {
                string numero = num.ToString();
                string rta = numero + " No es primo";
                label2.Text = rta;
                string tiempo = dur.ToString();
                label3.Text = tiempo;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
