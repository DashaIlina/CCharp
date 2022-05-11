/* Написать программу, которая определяет, 
является ли треугольник со сторонами a, b, c равнобедренным.*/
public class task1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите длину стороны a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите длину стороны b");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите длину стороны c");
        int c = Convert.ToInt32(Console.ReadLine());
        Triangle(a, b, c);

    }
    public static void Triangle(int num, int num2, int num3)
    {
        if (num + num2 >= num3 && num2 + num3 >= num && num3 + num >= num2)
        {
            ViewsTriangle(num, num2, num3);
        }
        else
        {
            Console.Write("Не является треугольником");
        }
    }
        public static void ViewsTriangle(int num, int num2, int num3)
    {
        if (num == num2 || num2 == num3 || num3 == num)
        {
            Console.Write("Треугольник равнобедренный");
        }
        else if (num == num2 && num2 == num3)
        {
            Console.Write("Треугольник равносторонний");
        }
        else
        {
            Console.Write("Треугольник разносторонний");
        }
    }

}