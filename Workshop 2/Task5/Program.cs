public class task4
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Напишите число ");

        int n = int.Parse(Console.ReadLine());
        int oldnumber = n;
        int newnumber = 0;

        int temp;
        while (n > 0)
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
}
