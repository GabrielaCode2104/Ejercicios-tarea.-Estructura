// 10 Genera los primeros 10 números de la serie Fibonacci. 

Console.WriteLine("LOS 10 PRIMEROS NUMEROS DE LA SERIE FIBONACCI SON: ");
int num1 = 0;
int num2 = 1;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(num1 + " ");
    int temp = num1;
    num1 = num2;
    num2 = temp + num1;
}
Console.ReadLine();
