// 4) Crea una función que calcule la factorial de un número. 
 
//DECLARACIÓN

Console.WriteLine("Ingrese un número entero: ");
int n = int.Parse(Console.ReadLine());
int factorial = 1;

//RESOLUCION

if (n == 0)
{
    factorial = 1;
}
else 
{
    for (int i = 1; i <= n; i++)
    {
        factorial *= i;
    }
}

// RESULTADOS

Console.WriteLine($"El factorial del número {n} es: {factorial}");
Console.ReadLine();
