// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
public class task24
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int n = Convert.ToInt32(Console.ReadLine());
        int summ = 0;
        for (int i = 1; i <= n; i++)
        {
            summ += i;

        }
        Console.WriteLine(summ + " это сумма чисел от 1 до " + n);
    }

}
