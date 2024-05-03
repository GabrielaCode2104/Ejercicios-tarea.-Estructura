// 9) Cuenta el número de vocales en una cadena de texto. 
Console.WriteLine("Ingresa una cadena de texto: ");
string tex01 = Console.ReadLine();

int contVocal = contarVocales(texto);

int contador = 0;
string vocales = "aeiouAEIOU";

foreach (char vocal in cadena)
{
    if (vocal.Contains(vocal))
    { 
        contador++;
    }
}
return contador

Console.WriteLine($"El número de vocales en la cadena es: {contVocal}")


