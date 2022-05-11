/* На вход подаются год, номер месяца и день рождения человека,
 Определить возраст человека на момент 1 февраля 2022 года.*/
public class task15
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Какой сегодня год");
        int yearnow = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Какой сегодня месяц");
        int monthnow = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Какой сегодня день");
        int daynow = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите год рождения");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите месяц рождения");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите день рождения");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Age(yearnow, year, monthnow, month, daynow, day));
    }
    public static String Age(int y, int y2, int m, int m2, int d, int d2)
    {
        if (y > y2)
        {
            if (m > m2)
            {
                y -= y2;
                return y.ToString();
            }

            else if (m == m2)
            {
                if (d >= d2)
                {
                    y -= y2;
                    return y.ToString();
                }
                else
                {
                    y = (y - y2) - 1;
                    return y.ToString();
                }
            }
            else
            {
                y = (y - y2) - 1;
                return y.ToString();
            }
        }
        else if (y == y2)
        {
            if (m > m2)
            {
                y -= y2;
                return y.ToString();
            }

            else if (m == m2)
            {
                if (d >= d2)
                {
                    y -= y2;
                    return y.ToString();
                }
                else
                {
                    return "Еще не родился";
                }
            }
            else
            {
                return "Еще не родился";
            }
        }
        else
        {
            return "Еще не родился";
        }

    }

}



 /*else
            {
                y -= y2;
                return y.ToString();
            }*/