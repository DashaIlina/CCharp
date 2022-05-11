// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая построчно выведет элементы и их индексы.
public class task56
{
    static void Main(string[] args)
    {
        int[,,] array1 = new int[2, 5, 2];

        FillArray(array1);
        PrintArray(array1);
        Console.WriteLine(" ");

        
        void FillArray(int[,,] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)

                {
                    for (int z = 0; z < array.GetLength(2); z++)
                    {
                        array[i, j, z] = rand.Next(10,100);
                    }
                }
            }
        }

        void PrintArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)

                {
                    for (int z = 0; z < array.GetLength(2); z++)
                    {
                        Console.Write(array[i, j, z] + "\t");
                    }
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
