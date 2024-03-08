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

namespace _02032024_guia4
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda 
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtnumeros.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtletras_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static bool validaremail(string email)
        {
            //cadena o expresion regular que verifica a un formato de correo electrónico
            string expresion = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            //verifica que el email ingresado corresponda con la expresion válida
            if (Regex.IsMatch(email, expresion))
            {//verifica que la direccion corresponda y que la longitud de la cadena no                 esté vacía
                    if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (validaremail(txtemail.Text))
            {
                //si es correcto no debe hacer nada
            }
            else
            {/*sino es correcto que envíe este mensaje y se posicione para 
                verificar recuerde que se activará la validación al dar click en otro textbox o 
                simplemente dejar o salir de esa casilla de email*/
                MessageBox.Show("Dirección de correo no válida");
                txtemail.SelectAll(); //selecciona todo lo de la casilla
                txtemail.Focus(); //se posiciona ahí de nuevo
            }
        }
    }
}
