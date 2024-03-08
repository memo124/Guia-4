using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //limpia cualquier mensaje de error de alguna corrida previa
            BorrarMesaje();
            //llamamos al método para validar campos, el de nombre y apellido
            if (validarCampos())
            {
                MessageBox.Show("Los datos se ingresaron correctamente");
            }
            //verificamos la fecha de nacimiento que nos den
            //DateTimePicker se llama dtpFechaNacimiento
            DateTime fechaNacimiento = txtfecha.Value;
            //verificamos la fecha del sistema (solo calculamos con los años
            int anios = System.DateTime.Now.Year - fechaNacimiento.Year;
            /*verificamos aparte del año si ya pasamos la fecha de nacimiento de este año o nos 
           faltan días*/
            if (System.DateTime.Now.Subtract(fechaNacimiento.AddYears(anios)).TotalDays < 0)
                //si nos faltan días para cumplir años al cálculo le resta uno
                txtedad.Text = Convert.ToString(anios - 1);
            else
                //si ya pasó nuestra fecha de nacimiento manda el valor correspondiente
                txtedad.Text = Convert.ToString(anios);

        }
        private bool validarCampos()
        {
            //variable que verifica si algo ha sido validado
            bool validado = true;
            if (txtnombre.Text == "") //vefica que no quede vacío el campo
            {
                validado = false; //si está vacío validado es falso
                errorProvider1.SetError(txtnombre, "Ingresar nombre");
                //por lo tanto manda a llamar a errorprovider
                //en los parámetros de setError se identifica a quién estoy validando y el mensaje que deseo mandar
            }
            if (txtfecha.Text != "")
            {
                DateTime fechaActual = DateTime.Now;

                DateTime fechaIngresada = DateTime.Parse(txtfecha.Text);
                if (fechaIngresada.CompareTo(fechaActual) > 0)
                {
                    validado = false;
                    errorProvider1.SetError(txtfecha, "La fecha no puede ser mayor a la fecha actual");
                }
            }
            //verifico la casilla de apellido
            if (txtapellido.Text == "")
            {
                validado = false;
                //digo que verifico a txtapellido y si no cumple mando ese mensaje
                errorProvider1.SetError(txtapellido, "Ingrese apellido");
            }
            return validado;
        }
        private void BorrarMesaje()
        {
            //borra los mensajes para que no se muestren y pueda limpiar
            errorProvider1.SetError(txtnombre, "");
            errorProvider1.SetError(txtapellido, "");
        }


    }
}
