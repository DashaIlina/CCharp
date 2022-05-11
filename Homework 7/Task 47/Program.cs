// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
public class task41
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Введите колличество строк ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Введите колличество столбцов ");
        int column = Convert.ToInt32(Console.ReadLine());
        double[,] real_array = new double[row, column];
        FillArray(real_array);
        PrintArray(real_array);

        void FillArray(double[,] real_array)
        {
            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    real_array[i, j] = rand.NextDouble() * 10 - 5;
                }
            }
        }

        void PrintArray(double[,] real_array)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(real_array[i, j] + "   ");
                }
                Console.WriteLine();
            }
                        
        }
    }
}