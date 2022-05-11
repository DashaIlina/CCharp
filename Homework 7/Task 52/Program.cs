// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
public class task52
{
    static void Main(string[] args)
    {

        int[,] array = new int[3, 4];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine("Среднее арифметическое столбцов: ");
        ArithmeticMeanColumns(array);

        void ArithmeticMeanColumns(int[,] array)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < array.GetLength(0); i++) sum += array[i, j];
                
                Console.Write(string.Format("{0:G3}"+ "\t", sum / array.GetLength(0)));
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
