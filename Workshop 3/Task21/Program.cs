/* Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве*/
public class task21
{
    public static void Main(string[] args)
    {
        Random rand = new Random();

        int a_x = rand.Next(-30, 30);
        int a_y = rand.Next(-30, 30);
        int b_x = rand.Next(-30, 30);
        int b_y = rand.Next(-30, 30);

        Console.WriteLine("Точка А - (" + a_x + ";" + a_y + ")");
        Console.WriteLine("Точка B - (" + b_x + ";" + b_y + ")");
        double result = Math.Sqrt((a_x-b_x)*(a_x-b_x)+(a_y-b_y)*(a_y-b_y));
        Console.WriteLine("Длина отрезка : " + result);

    }
}
