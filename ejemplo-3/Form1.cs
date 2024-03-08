using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float numera = float.Parse(txtdividendo.Text); 
                float denomina = float.Parse(txtdivisor.Text);
                float resultado = numera / denomina;
                txtresultado.Text = Convert.ToString(resultado);
            } 
            //si no pudiera hacerlo entonces verificará cual es el error y nos los mostrará
            catch (Exception error)
            { 
                MessageBox.Show("El problema es: " + error.Message); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdividendo.Clear(); 
            txtdivisor.Clear(); 
            txtdividendo.Focus();
        }
    }
}
