//6) Toma una cadena de texto y muestra su inversión. 
Console.WriteLine("INGRESE UN TEXTO: ");
string tex = Console.ReadLine();

string texInvertido = " ";
for (int i = tex.Length - 1; i >= 0; i--)
{
    texInvertido += tex[i];
}

Console.WriteLine("La cadena invertida es: " + texInvertido);

Console.ReadLine();

