// На вход координаты x и y, причем x не равен 0 и y не равен 0 и выдает номер четверти плоскости, в которой находится эта точка

public class task17
{
    public static void Main(string[] args)
    {
        int[] mass = new int[2];
        Console.WriteLine("Введите координаты x");
        mass[0] = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты y");
        mass[1] = int.Parse(Console.ReadLine());
        Plane(mass[0], mass[1]);
        /*Console.WriteLine("Введите координаты x");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты y");
        int y = int.Parse(Console.ReadLine());
        Plane(x, y);*/

        void Plane(int numx, int numy)
        {
            if (numx > 0 && numy > 0) Console.Write("Точка находится в 1 четверти");
            if (numx < 0 && numy > 0) Console.Write("Точка находится в 2 четверти");
            if (numx < 0 && numy < 0) Console.Write("Точка находится в 3 четверти");
            if (numx > 0 && numy < 0) Console.Write("Точка находится в 4 четверти");
        }
    }
}
