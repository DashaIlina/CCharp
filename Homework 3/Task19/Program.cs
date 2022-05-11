// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
public class task19
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Напишите пятизначенное число ");
        int number = int.Parse(Console.ReadLine());
        Palindrom(number);
        void Palindrom(int n)
        {
            int oldnumber = n;
            int newnumber = 0;

            if (n >= 10000 && n < 100000) // 12345
            {
                int temp;
                for (int i = 0; i < 5; i++)
                {
                    newnumber *= 10;
                    temp = n % 10;
                    newnumber += temp;
                    n /= 10;
                }
                if (newnumber == oldnumber)
                    Console.WriteLine(" число " + oldnumber + " палиндром");
                else
                    Console.WriteLine(" число " + oldnumber + " не палиндром");
            }
            else
                Console.WriteLine(" Напишите пятизначенное число ");
        }

    }
}
