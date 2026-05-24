# Respuestas al Cuestionario de C# - Clase 5

### 1. ¿String es un tipo por valor o un tipo por referencia?
El tipo `string` (o su equivalente de la plataforma `String`) es un **tipo por referencia**.

* **Basado en el PDF:** En la sección donde se detallan los tipos de datos en C#, el documento clasifica explícitamente a `string` dentro del grupo de **"Tipos de referencia"** (junto con las clases, interfaces y arrays), siendo un alias para la clase del sistema `System.String`. 
* **Comportamiento:** A diferencia de los tipos de valor (como `int` o `bool`), las variables de tipo de referencia almacenan la dirección de memoria donde se encuentran los datos reales, y no el valor en sí mismo.

---

### 2. ¿Qué secuencias de escape tiene el tipo string?
El documento de la materia hace una mención sumamente específica sobre el manejo de caracteres especiales dentro de una cadena de texto:

* **`\0` (Carácter nulo):** El texto indica textualmente que en C# las cadenas no finalizan en un carácter nulo (como ocurre en otros lenguajes como C++), pero añade que una cadena puede contener cualquier número de caracteres nulos incrustados mediante la secuencia de escape `"\0"`.

*(Nota: Aunque el lenguaje C# soporta de forma nativa otras secuencias comunes como `\n` para salto de línea o `\t` para tabulación, el carácter nulo `\0` es la única secuencia de escape que el material de lectura detalla explícitamente en este apartado).*

---

### 3. ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Según lo establecido en los ejemplos de código y las explicaciones sobre la sintaxis de las cadenas de texto en el material:

* **El carácter `$` (Interpolación de cadenas):** Activa la función de interpolación. Al anteponer el signo `$`, el compilador de C# interpreta las llaves `{}` dentro del texto como contenedores de código en lugar de texto plano, lo que permite incrustar variables o expresiones directamente dentro de la cadena (por ejemplo: `$"Resultado: {resultado}"`).
* **El carácter `@` (Cadenas literales o Verbatim):** Se introduce mediante la referencia directa a la sección oficial de "Cadenas y literales de cadena" adjunta en la bibliografía. Al anteponer el signo `@`, se le indica al compilador que procese la cadena de forma literal (*verbatim*). Esto significa que se ignoran las secuencias de escape (permitiendo usar barras invertidas `\` de forma segura, ideal para rutas de archivos) y se habilitan cadenas multilínea directamente en el editor sin necesidad de concatenar.