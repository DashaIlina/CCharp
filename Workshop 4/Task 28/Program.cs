// : Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

public class task28
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int n = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;

        }
        Console.WriteLine(factorial + " это произведение чисел от 1 до " + n);
        /* int number = 5;
        for ( int i = number; i > 1; i++) number *= (i - 1);
        Console.WriteLine(number);*/
    }


}