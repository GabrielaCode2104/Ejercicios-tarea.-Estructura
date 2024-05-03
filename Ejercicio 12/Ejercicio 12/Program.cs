// 12) Verifica si una palabra ingresada por el usuario es un palíndromo.
Console.WriteLine("Ingresa una palabra: ");
string palabra = Console.ReadLine().ToLower();

bool esPalindromo = EsPalindromo(palabra);

if (esPalindromo)
{
    Console.WriteLine("Es un palindromo.");

}
else
{
    Console.WriteLine("No es un palindromo");
}
Console.ReadLine();

static bool EsPalindromo(string palabra)
{
    int i = 0;
    int j = palabra.Length - 1;

    while (i < j)
    {
        if (palabra[i] != palabra[j])
        {
            return false;
        }
        i++;
        j--;
    }
    return true;
} 

