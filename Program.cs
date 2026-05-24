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

