// Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
public class Task4
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Введите 3 числа ");
        Console.WriteLine(" Введите первое число ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Введите второе число ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Введите третье число ");
        int l = Convert.ToInt32(Console.ReadLine());
        int max = int.MinValue;
        max = n;
        if (m > max) { max = m; }
        else { max = n; }
        if (l > max) { max = l; }
        Console.WriteLine(max + " большее из введенных чисел ");
        //Console.WriteLine(Math.Max(n, Math.Max(m, l)));
    }
}



