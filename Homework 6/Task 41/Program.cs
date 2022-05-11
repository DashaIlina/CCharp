// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
public class task41
{
    static void Main(string[] args)
    {
        Console.Write("Количество чисел: ");
        int numbers = Convert.ToInt32(Console.ReadLine());
        int numbers_pos = 0;
        for (int i = 0; i < numbers; i++)
        {
            Console.Write("Введите числа: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0) numbers_pos++;

        }
        Console.WriteLine(numbers_pos + " чисел больше 0");

    }
}
