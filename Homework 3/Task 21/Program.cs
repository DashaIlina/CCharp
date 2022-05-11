// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
public class task21
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; ++i)
        {
            string text = "--------+-------+--------\n";
            text = text + "| " + i + " \t| " + i * i + " \t| "+ i * i * i + "\t|";
            Console.WriteLine(text);
        
        }

        Console.WriteLine("--------+-------+--------");
    }
}
