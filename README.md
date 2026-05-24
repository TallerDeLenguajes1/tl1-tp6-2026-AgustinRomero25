# Respuestas al Cuestionario de C#

### 1. ¿String es un tipo por valor o un tipo por referencia?
El tipo `string` (o su equivalente `String`) es un **tipo por referencia**.

* **Explicación:** En C#, la palabra clave `string` es un alias para la clase del sistema `System.String`. Al pertenecer a la categoría de tipos de referencia, la variable no almacena el texto directamente dentro de su propio espacio de memoria, sino que guarda un puntero o dirección que apunta a la ubicación real de los datos en el *heap* (la memoria dinámica).

---

### 2. ¿Qué secuencias de escape tiene el tipo string?
Las cadenas en C# admiten diversas secuencias de escape estándar para representar caracteres especiales. Una de las más particulares y destacadas en el lenguaje es:

* **`\0` (Carácter nulo):** A diferencia de otros lenguajes como C o C++, las cadenas en C# no terminan automáticamente con un carácter nulo para marcar el final del texto. Sin embargo, el lenguaje permite insertar manualmente cualquier cantidad de caracteres nulos dentro de una cadena utilizando la secuencia de escape `"\0"`.

*(Nota: C# también soporta las secuencias tradicionales de escape como `\n` para saltos de línea, `\t` para tabulaciones o `\\` para incluir barras invertidas de forma explícita).*

---

### 3. ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Estos caracteres modifican la forma en que el compilador de C# interpreta y procesa el texto que escribimos, sirviendo para dos propósitos completamente distintos:

* **El carácter `$` (Interpolación de cadenas):** Activa la interpolación de texto. Al colocarlo antes de las comillas, le indicamos al programa que procese las llaves `{}` como contenedores de código en lugar de texto plano. Esto nos permite meter variables, cálculos o expresiones directamente dentro de la cadena de una forma mucho más limpia y legible (por ejemplo: `$"Resultado: {resultado}"`).
* **El carácter `@` (Cadenas literales o Verbatim):** Le indica al compilador que lea la cadena de forma literal, exactamente como está escrita. Tiene dos ventajas principales: deshabilita por completo las secuencias de escape (lo que permite escribir rutas de archivos con barras invertidas `\` sin que tire error) y nos permite hacer saltos de línea presionando *Enter* directamente en el editor sin tener que andar concatenando texto con signos `+`.