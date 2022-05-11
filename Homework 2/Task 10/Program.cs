// Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число.
public class task10
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Введите число ");
        int n = Convert.ToInt32(Console.ReadLine());
        //int m = 0;
        if (n >= 100 && n < 1000)
        {
            /*int digit3 = n % 10;
            n /= 10;
            int digit2 = n % 10;
            n /= 10;
            int digit1 = n % 10;
            int m = (digit3 * 100) + (digit2 * 10) + digit1;
            System.Console.WriteLine(m);*/
            while (n > 0)
            {
                System.Console.Write(n % 10);
                n /= 10;
            }

        }
        else Console.WriteLine(" Напишите трехзначное число ");
        
    }
}

