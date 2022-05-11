/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
*/
public class task15
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номер дня недели ");

        int numday = Convert.ToInt32(Console.ReadLine());

        Console.Write(CaseNumberDay(numday)); ;
    }

    public static String Numberday(int number)
    {
        if (number == 6 || number == 7)
        {
            return "Выходной";
        }
        else if (number >= 1 && number <= 5)
        {
            return " Будни ";
        }
        else
        {
            return " Дня недели с таким номером нет ";
        }
    }

    public static String CaseNumberDay(int number)
    {
        switch (number)
        {
            case 1:
                return " Будни ";
            case 2:
                return " Будни ";
            case 3:
                return " Будни ";
            case 4:
                return " Будни ";
            case 5:
                return " Будни ";
            case 6:
                return " Выходной ";
            case 7:
                return " Выходной ";
            default:
                return " Дня недели с таким номером нет ";

        }
    }
    public static String CaseNumberDay2(int number)
    {
        switch (number)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                return " Будни ";
            case 6:
            case 7:
                return " Выходной ";
            default:
                return " Дня недели с таким номером нет ";

        }
    }

}
