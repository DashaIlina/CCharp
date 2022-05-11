// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
public class task36
{
    public static void Main(string[] args)
    {
        double[] a = new double[8];

        Console.WriteLine(" ");
        FillArray(a);
        PrintArray(a);
        Console.WriteLine(" ");
        DifMaxMin(a);
        Console.WriteLine(" ");

    }
    public static void DifMaxMin(double[] array)
    {
        double maxnum = array[0];
        double minnum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxnum) maxnum = array[i];

            if (array[i] < minnum) minnum = array[i];

        }
        double resalt = maxnum - minnum;
        Console.WriteLine($" Максимальный элемент: {maxnum.ToString("0.000")} ");
        Console.WriteLine($" Минимальный элемент: {minnum.ToString("0.000")} ");

        Console.WriteLine($" {maxnum.ToString("0.000")} - {minnum.ToString("0.000")} = {resalt.ToString("0.000")}");
    }

    public static void PrintArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i].ToString("0.000") + "\t");
        }
        Console.WriteLine(" ");
    }
    public static void FillArray(double[] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.NextDouble() * 10;
        }
    }

}
