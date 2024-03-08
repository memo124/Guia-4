using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo___4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado miEmpleado = new Empleado();
            try 
            { 
                miEmpleado.carnet = int.Parse(txtcarnet.Text); 
                miEmpleado.Nombre = txtnombre.Text; 
                miEmpleado.Edad = int.Parse(txtedad.Text); 
            } catch (Exception x) 
            { 
                MessageBox.Show(x.Message); 
                txtcarnet.Text = ""; 
                txtnombre.Text = ""; 
                txtedad.Text = ""; 
                txtcarnet.Focus(); 
                return; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
