/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/
public class task34
{
    public static void Main(string[] args)
    {
        int[] a = new int[8];
        
        Console.WriteLine(" ");
        FillArray(a);
        PrintArray(a);
        Console.WriteLine(" ");
        MathPosNum(a);
        Console.WriteLine(" ");


    }
    public static void MathPosNum(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {

            if (array[i] % 2 == 0)  count++;
            
        }
        Console.WriteLine($"Количество четных чисел массива: {count}");
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
            array[i] = rnd.Next(100, 999);
        }
    }

}