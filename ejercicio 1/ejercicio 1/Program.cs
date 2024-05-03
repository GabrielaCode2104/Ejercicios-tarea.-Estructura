//1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 

double n, n2, suma, resta, multiplicacion, division;
Console.WriteLine("Ingrese un número: ");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un número: ");
n2 = int.Parse(Console.ReadLine());


// RESOLUCION

suma = n + n2;
resta = n - n2;
multiplicacion = n * n2;

if (n2 != 0)
{
    division = n / n2;
}
else
{
    Console.WriteLine("No se puede dividir entre cero");
    division = 0;
}

//RESULTADOS

Console.WriteLine($"La suma es:  {suma}");
Console.WriteLine($"La resta es: {resta}");
Console.WriteLine($"La multiplicación es: {multiplicacion}");
Console.WriteLine($"La división es: {Math.Round(division, 1)}");

Console.ReadLine();
