using System.Linq.Expressions;
using System.Globalization;


string s1;
string s2;
double num1;
double num2;
int eleccion;
bool SecCheck;
double resultado;

Console.WriteLine("------------------- CALCULADORA EN C# -----------------------\n");
Console.WriteLine("SELECCIONE LA CANTIDAD DE NUMEROS A TRABAJAR: ");
Console.WriteLine("\n1.1 NUMERO\n2.2 NUMEROS\n3.EL MAYOR Y EL MENOR ENTRE 2 NUMEROS");
do
{
    s1 = Console.ReadLine();
    SecCheck = int.TryParse(s1, out eleccion);
    if(!SecCheck)
    {
        Console.WriteLine("Eso no es un numero valido. \nPor favor, ingrese un numero valido.\n");
    } 
} while (!SecCheck);

if(eleccion >= 1 && eleccion <= 3)
{
    switch(eleccion)
    {
        case 1:
            Console.WriteLine("------------------- CALCULADORA 1 NUMERO -----------------------\n");

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
        break;

        case 2:
            Console.WriteLine("------------------- CALCULADORA 2 NUMEROS -----------------------\n");

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
            string s3 = Console.ReadLine();
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
                resultado = num1 / num2;
                Console.WriteLine($"----------------- Resultado: {resultado} --------------------\n");

            } else if (eleccion == 4)
            {
                resultado = num1 * num2;
                Console.WriteLine($"----------------- Resultado: {resultado} --------------------\n");
            }
        break;

        case 3:
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
        break;
    }
} else
{
    Console.WriteLine("Error, ingrese un numero valido.\n");
}