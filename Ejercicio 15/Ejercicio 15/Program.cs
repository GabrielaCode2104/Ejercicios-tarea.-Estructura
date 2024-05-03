// 15) Toma un número entero y calcula la suma de sus dígitos. 

int num2 = 35243;

int sumDig = CalcularSumDig(num2);

Console.WriteLine($"La suma de los dígitos de {num2} es: {sumDig}");
static int CalcularSumDig ( int num )
{
    int suma = 0;
    while (num > 0)
    {
        int digito = num % 10;
        suma += digito;
        num /= 10;
    }
    return suma;
        }
Console.ReadLine();