// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Все четные числа от 0 до " + n);
int i = 0;
while (i < n) 
{
    if (i % 2 == 0)
    {
           Console.WriteLine(i + " ");
    }
    i++;
}