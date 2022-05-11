//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
public class task56
{
    static void Main(string[] args)
    {
        int[,] array1 = new int[2, 5];
        int[,] array2 = new int[5, 4];
        FillArray(array1); 
        PrintArray(array1);
        Console.WriteLine(" ");
        FillArray(array2);
        PrintArray(array2);
        Console.WriteLine(" ");
        SumArray(array1, array2);

        void SumArray(int[,] array1, int[,] array2)
        {
            if (array1.GetLength(1) == array2.GetLength(0))
            {
                int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    for (int j = 0; j < array2.GetLength(1); j++)
                    {
                        for (int k = 0; k < array2.GetLength(0); k++)
                        {
                            array3[i, j] += array1[i, k] * array2[k, j];
                        }
                    }
                }
                PrintArray(array3);

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

                Console.WriteLine(" ");
            }

        }
    }
}


