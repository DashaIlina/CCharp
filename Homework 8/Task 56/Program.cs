// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
public class task56
{
    static void Main(string[] args)
    {

        int[,] array = new int[3, 5];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine(" ");
        SmallSumRow(array);

        void SmallSumRow(int[,] array)
        {
            int minsum = int.MaxValue;
            int minposition = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
                if (sum < minsum)
                {
                    minsum = sum;
                    minposition = i;
                }
            }
            Console.WriteLine($" Наименьшая сумма элементов: {minsum} в {minposition + 1} строке");
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



