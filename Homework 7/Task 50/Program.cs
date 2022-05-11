// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
public class task50
{
    static void Main(string[] args)
    {

        int[,] array = new int[8, 8];
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        FillArray(array);
        PrintArray(array);
        PrintValue(array);

        void PrintValue(int[,] array)
        {
            int i = a;
            int j = b;
            if (i < array.GetLength(0) && j < array.GetLength(1)) Console.WriteLine($"Значение элемента в заданной позиции: {array[i, j]}");
            else Console.WriteLine("Такой позиции нет в массиве");
        }
        void FillArray(int[,] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-10, 10);
                }
            }
        }

        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}