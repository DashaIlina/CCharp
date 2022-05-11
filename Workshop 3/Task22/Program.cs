/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N..*/
public class task22
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; ++i)
        {
            string text = "--------+--------\n";
            text = text + "| " + i + " \t| " + i * i + "\t|";
            Console.WriteLine(text);
        
        }

        Console.WriteLine("--------+--------");
    }
}
