using System.Linq.Expressions;
using System.Globalization;

Console.WriteLine("------------------- EJERCICIO 3 -----------------------\n");
Console.WriteLine("------------------- CALCULADORA V2 -----------------------\n");

string s1;
string s2;
double num1;
double num2;
int eleccion;
bool SecCheck;
double resultado;

do
{
    Console.WriteLine("Ingrese el numero a operar: ");
    s1 = Console.ReadLine();
    SecCheck = double.TryParse(s1, CultureInfo.InvariantCulture, out num1);
    if(!SecCheck)
    {
        Console.WriteLine("Eso no es un numero. \nPor favor, ingrese un numero valido.\n");
    } 
} while (!SecCheck);

do
{
    Console.WriteLine("¿Qué operacion desea realizar en el número?\n1.valor absoluto\n2.cuadrado\n3.raíz cuadrada\n4.seno\n5.coseno\n6.la parte entera de un tipo float\n");
    s2 = Console.ReadLine();
    SecCheck = int.TryParse(s2, out eleccion) && eleccion >= 1 && eleccion <= 6;
    if(!SecCheck)
        {
            Console.WriteLine("Opcion no valida. \nPor favor, ingrese un numero del 1 al 6.\n");
        }
} while(!SecCheck);


switch (eleccion)
{
    case 1:
        resultado = Math.Abs(num1);
        Console.WriteLine($"----------------- Resultado: {resultado} --------------------\n"); 
    break;

    case 2:
        resultado = num1 * num1;
        Console.WriteLine($"----------------- Resultado: {resultado} --------------------\n");
    break;

    case 3:
        if(num1 >= 0)
        {
            resultado = Math.Sqrt(num1);
            Console.WriteLine($"----------------- Resultado: {resultado} --------------------\n");
        } else
        {
            Console.WriteLine("No se permiten raices negativas. Intente solo con numeros positivos.");
        }
    break;

    case 4:
    resultado = Math.Sin(num1);
    Console.WriteLine($"----------------- Resultado: {resultado} --------------------\n");
    break;

    case 5:
    resultado = Math.Cos(num1);
    Console.WriteLine($"----------------- Resultado: {resultado} --------------------\n");
    break;

    case 6:
    int resultadoEntero = (int)num1;
    Console.WriteLine($"----------------- Resultado: {resultadoEntero} --------------------\n");
    break;
}

Console.WriteLine("------------------- ¿CUAL ES EL MAYOR Y CUAL EL MENOR? -----------------------\n");

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
} while (!SecCheck);

double mayor = Math.Max(num1, num2);
double menor = Math.Min(num1, num2);
Console.WriteLine($"El numero mayor es: {mayor}\nEl numero menor es: {menor}");