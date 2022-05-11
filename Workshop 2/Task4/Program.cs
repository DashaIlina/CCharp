public class task3
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Напишите пятизначенное число ");

        int n = int.Parse(Console.ReadLine());
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
                Console.WriteLine(oldnumber + " палиндром");
            else
                Console.WriteLine(oldnumber + " не палиндром");
        }
        else
            Console.WriteLine(" Напишите пятизначенное число ");
    }
}
