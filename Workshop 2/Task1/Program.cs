public class task1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Проверка числа на кратность 7 и 23");
        Console.WriteLine("_______________________________");
        Console.WriteLine("Введите число");
        

        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 7 == 0 && n % 23 == 0)
            Console.Write(" число кратно 7 и 23 ");
        else
            Console.Write(" число не кратно 7 и 23 ");
    }
}
