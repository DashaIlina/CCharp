// Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
public class task25
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        //double n = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень");
        //double a = Convert.ToInt32(Console.ReadLine());
        int a = Convert.ToInt32(Console.ReadLine());
        //double result = Math.Pow(n, a);
        //Console.WriteLine (n + " в степени " + a + " = " + result);
        int power = 1;
        for (int i = 1; i < a; i++)
        {
            power *= n;
        }
        Console.WriteLine(power);
    }
}


