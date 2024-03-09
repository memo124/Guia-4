using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatchFinally
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            int dividendo;
            int divisor;
            double resultado = 0;

            try
            {
                dividendo = int.Parse(txtDividendo.Text);
                divisor = int.Parse(txtDivisor.Text);

                // Intenta realizar la división
                resultado = dividendo / divisor;
                MessageBox.Show($"El resultado de la división es: {resultado}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir entre cero.");
            }
            finally
            {
                // Esto siempre se ejecutará, independientemente de si se produce una excepción o no
                txtDividendo.Clear();
                txtDivisor.Clear();
            }
        }
    }
}



/*
 * La diferencia entre try-catch y 
 * try-catch-finally en C# es que try-catch se utiliza para manejar excepciones sin importar si ocurren o no, 
 * mientras que try-catch-finally se utiliza para manejar excepciones y garantizar que cierto código
 * se ejecute independientemente de si se produce una excepción o no.
 * 
 * 
 * 
 * CADENAS PARA EXPRESIONES REGULARES COMO:
 * 
 * 
Número de teléfono (formato USA):
Expresión Regular: ^\(?(\d{3})\)?[\s-]?(\d{3})[\s-]?(\d{4})$
Ejemplo válido: (123) 456-7890 o 123-456-7890
 * 
Dirección de correo electrónico:
Expresión Regular: ^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$
Ejemplo válido: usuario@example.com

URL de sitio web:
Expresión Regular: ^(https?://)?(www\.)?([a-zA-Z0-9-]+\.){1,2}[a-zA-Z]{2,}(\/[a-zA-Z0-9-._~:/?#[\]@!$&'()*+,;=]*)?$
Ejemplo válido: http://www.example.com o https://example.com/path


Dirección IP (IPv4):
Expresión Regular: ^(\d{1,3}\.){3}\d{1,3}$
Ejemplo válido: 192.168.1.1


Fecha en formato (dd/mm/yyyy):
Expresión Regular: ^(0?[1-9]|[12][0-9]|3[01])/(0?[1-9]|1[0-2])/\d{4}$
Ejemplo válido: 25/12/2023
 *
*/
