// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
public class task30
{
    public static void Main(string[] args)
    {

        int[] a = new int[8];
        Random random = new Random();
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = random.Next(-100, 100);
            Console.Write(a[i] + "\t");
        }
        Console.WriteLine(" ");
        Sort(a);
        Console.WriteLine(" ");
        PrintArray(a);
    }

    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minPosition = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (Math.Abs(array[j]) < Math.Abs(array[minPosition]))
                {
                    minPosition = j;
                }
            }
            int temp = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temp;
        }
        
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");

        }
        Console.WriteLine(" ");
    }
}



