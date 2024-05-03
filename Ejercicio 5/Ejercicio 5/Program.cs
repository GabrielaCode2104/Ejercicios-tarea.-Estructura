//5) Verifica si un número ingresado por el usuario es primo o no. 

//DECLARACIÓN

Console.WriteLine("INGRESE UN NÚMERO ENTERO: ");
int num1 = int.Parse(Console.ReadLine());

// RESOLUCION

if (num1 <= 0)
{
    Console.WriteLine("El número no es primo");
}
else
{
    bool es_primo = true;
    for (int i = 2; i < num1; i++)
    { 
        if (num1 % i == 0) 
        {
            es_primo = false;
            break;
        }
     }
    if (es_primo)
    {
        Console.WriteLine("El número es primo");
    }
    else
    {
        Console.WriteLine("El número no es primo");
    }
}

// RESULTADOS
Console.ReadLine();
