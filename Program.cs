using System.Globalization;

Console.WriteLine("------------------- EJERCICIO 4 ----------------\n");
Console.WriteLine("Ingrese una cadena de caracteres:");

string cadena = Console.ReadLine();
int longCadena = cadena.Length;

Console.WriteLine($"La longitud de la cadena ingresada es: {longCadena}");

Console.WriteLine("Ahora ingrese una segunda cadena de caracteres:");
string cadena2 = Console.ReadLine();

string combo = cadena + ' ' + cadena2;

Console.WriteLine($"la suma entre ambas cadenas es igual a: {combo}");

string[] array = combo.Split(' ');
string SegundaPalabra = array[1];

Console.WriteLine($"la segunda palabra es {SegundaPalabra}");

Console.WriteLine("------------------- CALCULADORA 2 NUMEROS -----------------------\n");

string s1;
double num1;
string s2;
double num2;
string s3;
int eleccion;
bool SecCheck;
double resultado;

do
{
    Console.WriteLine("Ingrese el primer numero: ");
    s1 = Console.ReadLine();
    SecCheck = double.TryParse(s1, CultureInfo.InvariantCulture, out num1);
    if(!SecCheck)
    {
        Console.WriteLine("Eso no es un numero. \nPor favor, ingrese un numero valido.\n");
    } 
} while (!SecCheck);

do
{
    Console.WriteLine("Ingrese el segundo numero: ");
    s2 = Console.ReadLine();
    SecCheck = double.TryParse(s2, CultureInfo.InvariantCulture, out num2);
    if(!SecCheck)
    {
        Console.WriteLine("Eso no es un numero. \nPor favor, ingrese un numero valido.\n");
    } 
} while(!SecCheck);

do
{
Console.WriteLine("¿Qué operacion desea realizar?\n1.suma\n2.resta\n3.división\n4.multiplicación\n");
s3 = Console.ReadLine();
SecCheck = int.TryParse(s3, out eleccion) && eleccion >= 1 && eleccion <= 4;
if(!SecCheck)
    {
        Console.WriteLine("Opcion no valida. \nPor favor, ingrese un numero del 1 al 4.\n");
    } else if(eleccion == 3 && num2 == 0)
        {
            Console.WriteLine("No se puede dividir en 0, intente nuevamente.\n");
            SecCheck = false;
        }
} while(!SecCheck);

string snum1 = num1.ToString();
string snum2 = num2.ToString();
string sresultado;

if (eleccion == 1)
{
    resultado = num1 + num2;  
    sresultado = resultado.ToString(); 
    Console.WriteLine($"la suma de {snum1} y de {snum2} es igual a: {sresultado}\n"); 
} else if (eleccion == 2)
{
    resultado = num1 - num2;
    sresultado = resultado.ToString(); 
    Console.WriteLine($"la resta de {snum1} y de {snum2} es igual a: {sresultado}\n"); 

} else if (eleccion == 3)
{
    resultado = num1 / num2;
    sresultado = resultado.ToString(); 
    Console.WriteLine($"la division de {snum1} y de {snum2} es igual a: {sresultado}\n");

} else if (eleccion == 4)
{
    resultado = num1 * num2;
    sresultado = resultado.ToString(); 
    Console.WriteLine($"el producto de {snum1} y de {snum2} es igual a: {sresultado}\n");
}

