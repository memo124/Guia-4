using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración del MaskedTextBox para aceptar solo números
            maskedTextBox1.Mask = "(503) 000-0000";
            maskedTextBox1.PromptChar = ' '; // Para que el prompt character sea un espacio en blanco en lugar de "_"
            maskedTextBox1.KeyPress += new KeyPressEventHandler(maskedTextBox1_KeyPress); // Asociar el evento KeyPress
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si el MaskedTextBox contiene un valor válido
            if (maskedTextBox1.MaskFull && !maskedTextBox1.Text.Contains("_"))
            {
                MessageBox.Show("Número ingresado: " + maskedTextBox1.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si el formato está en uso y el carácter introducido es una letra, cancelar la entrada
            if (maskedTextBox1.MaskFull && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}


/* COMO FUNCIONA MASKEDTEXTBOX
 * Para definir una máscara, puedes establecer la propiedad Mask del MaskedTextBox. La máscara utiliza caracteres especiales para definir el formato deseado. Por ejemplo:

0 - Solo números.
9 - Números opcionales.
L - Letras.
A - Letras o números.
. - Carácter literal, como un punto o un guion.
\ - Carácter de escape para incluir caracteres literales como parte de la máscara.
Por ejemplo, si quieres una máscara para un número de teléfono en El Salvador, podrías usar: (503) 000-0000.
 * Cuando el usuario interactúa con el MaskedTextBox, 
 * solo puede ingresar caracteres que coincidan con la máscara definida. 
 * Por ejemplo, si la máscara especifica un número de teléfono, el usuario solo podrá ingresar números y los caracteres de formato ((, ), -) se agregarán automáticamente.
 * El control valida automáticamente la entrada del usuario conforme esta es ingresada, lo que significa que no necesitas escribir código adicional para validar el formato de entrada.
 */
