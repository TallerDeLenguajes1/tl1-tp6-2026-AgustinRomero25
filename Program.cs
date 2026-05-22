using System.Linq.Expressions;

Console.WriteLine("------------------- EJERCICIO 2 -----------------------\n");
Console.WriteLine("------------------- CALCULADORA V1 -----------------------\n");

float num1;
float num2;
int eleccion;
bool SecCheck;

do
{
    Console.WriteLine("Ingrese el primer numero: ");
    string s1 = Console.ReadLine();
    SecCheck = float.TryParse(s1, out num1);
    if(!SecCheck)
    {
        Console.WriteLine("Eso no es un numero. \nPor favor, ingrese un numero valido.\n");
    } 
} while (!SecCheck);

do
{
    Console.WriteLine("Ingrese el segundo numero: ");
    string s2 = Console.ReadLine();
    SecCheck = float.TryParse(s2, out num2);
    if(!SecCheck)
    {
        Console.WriteLine("Eso no es un numero. \nPor favor, ingrese un numero valido.\n");
    } 
} while(!SecCheck);

do
{
Console.WriteLine("¿Qué operacion desea realizar?\n1.suma\n2.resta\n3.división\n4.multiplicación\n");
string s3 = Console.ReadLine();
SecCheck = int.TryParse(s3, out eleccion) && eleccion >= 1 && eleccion <= 4;
if(!SecCheck)
    {
        Console.WriteLine("Opcion no valida. \nPor favor, ingrese un numero del 1 al 4.\n");
    }
} while(!SecCheck);

float resultado;

if (eleccion == 1)
{
    resultado = num1 + num2;   
    Console.WriteLine($"----------------- Resultado: {resultado} --------------------\n"); 
} else if (eleccion == 2)
{
    resultado = num1 - num2;
    Console.WriteLine($"----------------- Resultado: {resultado} --------------------\n");

} else if (eleccion == 3)
{
    if(num2 != 0)
    {
        resultado = num1 / num2;
        Console.WriteLine($"----------------- Resultado: {resultado} --------------------\n");

    } else
    {
        Console.WriteLine("No se puede dividir en 0, intente nuevamente.\n");
    }
} else if (eleccion == 4)
{
    resultado = num1 * num2;
    Console.WriteLine($"----------------- Resultado: {resultado} --------------------\n");
}