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
    public partial class Form2 : Form
    {
        private string carnet;
        private string nombres;
        private DateTime fechaNacimiento;
        private string correoElectronico;
        private string responsables;

        public Form2(string carnet, string nombres, DateTime fechaNacimiento, string correoElectronico, string responsables)
        {
            InitializeComponent();

            this.carnet = carnet;
            this.nombres = nombres;
            this.fechaNacimiento = fechaNacimiento;
            this.correoElectronico = correoElectronico;
            this.responsables = responsables;

            lblEstudiante.Text = $"Estudiante: {nombres} ({carnet})";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (!float.TryParse(txtNotaPeriodo1.Text, out float nota))
                {
                    MessageBox.Show($"La nota del período {1} no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (nota < 0 || nota > 10)
                {
                    MessageBox.Show($"La nota del período {1} debe estar entre 0 y 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!float.TryParse(txtNotaPeriodo2.Text, out float nota2))
                {
                    MessageBox.Show($"La nota del período {1} no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (nota2 < 0 || nota2 > 10)
                {
                    MessageBox.Show($"La nota del período {1} debe estar entre 0 y 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!float.TryParse(txtNotaPeriodo3.Text, out float nota3))
                {
                    MessageBox.Show($"La nota del período {1} no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (nota3 < 0 || nota3 > 10)
                {
                    MessageBox.Show($"La nota del período {1} debe estar entre 0 y 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!float.TryParse(txtNotaPeriodo4.Text, out float nota4))
                {
                    MessageBox.Show($"La nota del período {1} no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (nota4 < 0 || nota4 > 10)
                {
                    MessageBox.Show($"La nota del período {1} debe estar entre 0 y 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            // Calcular promedio
            float promedio = (float.Parse(txtNotaPeriodo1.Text) + float.Parse(txtNotaPeriodo2.Text) +
                            float.Parse(txtNotaPeriodo3.Text) + float.Parse(txtNotaPeriodo4.Text)) / 4;

            txtPromedio.Text = $"El promedio es: {promedio.ToString("F2")}";
        }
    }
}
