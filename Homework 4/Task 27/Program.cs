//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
public class task27
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(SumOfDigits(n) + " это сумма цифр числа " + n);

        int SumOfDigits(int number)
        {
            int summ = 0;
            while (number > 0)
            {
                summ += number % 10;
                number /= 10;
            }
            return summ;
        }

    }
}
