//02 Solicita un número al usuario y determina si es par o impar
Console.WriteLine("Ingrese un número: ");
double num = double.Parse(Console.ReadLine());

//Resolución

if (num % 2 == 0)
{
    Console.WriteLine("Es par");
}
else
{
    Console.WriteLine("El número es impar");
}

Console.ReadLine();
