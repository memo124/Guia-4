####Guia 4

##1. Investigación sobre MaskedTextBox y ejemplo:

MaskedTextBox es un control de formulario que permite al usuario ingresar datos en un formato específico. Este control es útil cuando se necesita validar la entrada del usuario en un formato particular, como números de teléfono, códigos postales, fechas, etc. El MaskedTextBox permite definir una "máscara" que especifica el formato en el que se deben ingresar los datos. La máscara consiste en una serie de caracteres que representan los caracteres permitidos en la entrada y los caracteres de formato. Por ejemplo, una máscara para un número de teléfono en los Estados Unidos podría ser "(###) ###-####", donde "#" representa un dígito numérico.

##2. Diferencias entre try-catch y try-catch-finally:

try-catch:

Se utiliza para manejar excepciones en C#.
En un bloque try, puedes colocar código que puede lanzar una excepción.
Si ocurre una excepción dentro del bloque try, el flujo del programa se desvía al bloque catch, donde puedes manejar la excepción.
El bloque catch permite capturar la excepción y manejarla de alguna manera, como mostrar un mensaje de error o tomar medidas correctivas.
El bloque try-catch no garantiza que se ejecute un código específico después de manejar la excepción.
try-catch-finally:

Es similar a try-catch, pero agrega un bloque finally.
El bloque finally se ejecutará siempre, ya sea que ocurra una excepción o no.
Se utiliza para limpiar recursos u ejecutar código que debe ejecutarse independientemente de si ocurre una excepción o no.
El bloque finally es opcional, pero es útil para la limpieza de recursos.

##3. Otras expresiones regulares comunes:

Teléfono (formato internacional):
Fragmento de código
^\+(?:[0-9] ?){6,14}[0-9]$

URL de sitio web:
^(https?|ftp):\/\/[^\s/$.?#].[^\s]*$

Dirección de correo electrónico:
^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$

Código postal (EE. UU.):
^\d{5}(-\d{4})?$

Fecha (formato YYYY-MM-DD):
^\d{4}-\d{2}-\d{2}$