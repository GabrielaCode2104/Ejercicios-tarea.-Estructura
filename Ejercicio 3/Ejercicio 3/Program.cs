// 03 Pide la base y la altura de un triángulo al usuario y calcula su área. 

double baseTri1, altTri1, areaTri;

Console.WriteLine("Escriba la base del triangulo: ");
baseTri1 = double.Parse(Console.ReadLine());
Console.WriteLine("Escriba la altura del triangulo: ");
altTri1 = double.Parse(Console.ReadLine());

//Resolución

areaTri = (baseTri1 * altTri1) / 2;

//Resultado

Console.WriteLine($"El área del triangulo es: {areaTri}");

Console.ReadLine();

