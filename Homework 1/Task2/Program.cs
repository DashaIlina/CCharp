public class Task2
{
    public static void Main(string[] args)
    {
        //"Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        Console.WriteLine("Введите 2 числа");
        Console.WriteLine("Введите первое число");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int m = Convert.ToInt32(Console.ReadLine());

        if (n > m) { Console.WriteLine(n + " больше " + m); }
        else if (n == m) { Console.WriteLine(n + " равно " + m); }
        else { Console.WriteLine(m + " больше " + n); }


    }
}