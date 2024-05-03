// 14) Pide el radio de un círculo al usuario y calcula su área. 

double radio1, areaCirc;

Console.WriteLine("Escriba el radio del circulo: ");
radio1 = double.Parse(Console.ReadLine());

areaCirc = Math.PI * Math.Pow(radio1, 2);

Console.WriteLine($"El área del circulo es: {Math.Round(areaCirc,2)}");
Console.ReadLine();


