//7) Calcula la suma de los números pares en un rango especificado por el usuario.
Console.WriteLine("INGERSE EL NUMERO INICIAL DEL RANGO: ");
int numInicio = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL NUMERO FINAL DEL RANGO: ");
int numFinal = int.Parse(Console.ReadLine());

int sumaPares = 0;
for (int i = numInicio; i <= numFinal; i++)

{
    if (i % 2 == 0)
    {
        sumaPares += i;
    }
}

Console.WriteLine($"La suma de los números pares en el rango es: {sumaPares} ");
Console.ReadLine();

