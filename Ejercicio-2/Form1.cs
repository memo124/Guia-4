using ejemplo_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCarnet(txtcarnet.Text))
            {
                MessageBox.Show("El carnet no tiene el formato UFG correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar nombres
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Debe ingresar los nombres del estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar fecha de nacimiento
            if (!DateTime.TryParse(txtfecha.Text, out DateTime fechaNacimiento))
            {
                MessageBox.Show("La fecha de nacimiento no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar correo electrónico
            if (!IsValidEmail(txtcorreo.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar responsables
            if (string.IsNullOrEmpty(txtresponsable.Text))
            {
                MessageBox.Show("Debe ingresar los nombres de los responsables del estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar formulario 2
            Form2 formulario2 = new Form2(txtcarnet.Text, txtnombre.Text, fechaNacimiento, txtcorreo.Text, txtresponsable.Text);
            formulario2.ShowDialog();
        }
        private bool ValidarCarnet(string carnet)
        {
            return Regex.IsMatch(carnet, "^[A-Z]{2}[0-9]{6}$");
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
        }

        private void txtcarnet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
