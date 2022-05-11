/* Напишите программу, 
которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/
public class task13
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int n = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine (ThirdDigit(n));
    }

    public static String ThirdDigit(int number)
    {
        if (number >= 100)
        {
            while (number > 999)
            {
                number /= 10;

            }
            number %= 10;
            return number.ToString();
        }
        else
        {
            return " Третьей цифры нет ";
        }
    }

}