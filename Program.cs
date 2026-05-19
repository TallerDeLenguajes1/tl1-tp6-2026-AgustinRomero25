Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;

Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

Console.WriteLine("------------------- EJERCICIO 1 ----------------\n");
Console.WriteLine("Ingrese un numero mayor a 0: ");
string entry = Console.ReadLine();
int num1;
bool stringaint = int.TryParse(entry, out num1);
Console.WriteLine($"El numero ingresado es: {num1}");

if (num1 > 0)
{
    int resto = 0;
    int invertido = 0;
    while (num1 != 0)
    {
        resto = num1 % 10;
        invertido = (invertido * 10) + resto;
        num1 = num1 / 10;
    }
    Console.WriteLine($"El numero invertido es: {invertido}");
}