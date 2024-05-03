// 13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario. 
Console.WriteLine("INGRESE UN NÚMERO: ");
int num1 = int.Parse(Console.ReadLine());

for (int i = 1; i <= 12; i++)
{
    int resultado = num1 * i;   
    Console.WriteLine(num1 + " x " +  i + " = " + resultado);
}
Console.ReadLine();
