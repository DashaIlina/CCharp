// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
public class task54
{
    static void Main(string[] args)
    {

        int[,] array = new int[3, 4];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine(" ");
        DecreasingSortArray(array);
        PrintArray(array);

        void DecreasingSortArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int maxPosition = j;
                    {
                        for (int k = j + 1; k < array.GetLength(1); k++)
                        {
                            if (array[i, k] > array[i, maxPosition]) maxPosition = k;
                        }
                        int temp = array[i, j];
                        array[i, j] = array[i, maxPosition];
                        array[i, maxPosition] = temp;
                    }
                }
            }
        }

        void FillArray(int[,] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) array[i, j] = rand.Next(10);
            }
        }

        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + "\t");

                Console.WriteLine();
            }

        }

    }
}
