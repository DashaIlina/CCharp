/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/
 public class task36
{
    public static void Main(string[] args)
    {
        int[] a = new int[8];
        
        Console.WriteLine(" ");
        FillArray(a);
        PrintArray(a);
        Console.WriteLine(" ");
        SumNumMas(a);
        Console.WriteLine(" ");


    }
    public static void SumNumMas(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sum}");
    }
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");

        }
        Console.WriteLine(" ");
    }
    public static void FillArray(int[] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(10);
        }
    }

}
