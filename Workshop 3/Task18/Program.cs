// по номеру четверти, показывает диапозон возможных координат точек в этой четверти (10 точек)
public class task18
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номер четверти");
        int number = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int[] arrayX = new int[10];
        int[] arrayY = new int[10];
        int chetv = rnd.Next(1, 5);

        int x_mod = 1;
        int y_mod = 1;

        if (chetv == 2)
        {
            x_mod = -1;
        }
        if (chetv == 3)
        {
            x_mod = -1;
            y_mod = -1;
        }
        if (chetv == 3)
        {
            y_mod = -1;
        }
        for (int i = 0; i < 10; i++)
        {
            arrayX[i] = x_mod * rnd.Next(1, 63);
            arrayY[i] = y_mod * rnd.Next(1, 63);
            Console.WriteLine(" Координаты точки " + (i + 1) + " ( " + arrayX[i] + ";" + arrayY[i] + " ) ");
        }

    }



}

