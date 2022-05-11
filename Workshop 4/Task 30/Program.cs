// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
public class task30
{
    public static void Main(string[] args)
    {
        
        int [] a = new int [8];
        Random random = new Random();
        for (int i = 0; i < a.Length - 1; i++)
        {
            a[i] = random.Next (0,2);
            Console.Write(a[i] + "\t");
        }
        //for (int i = 0; i < a.GetLength(0); i++)
    
        
        /* 
        Random rand = new Random ();
        int [] a = new int [8];
        for (int i = 0; i <= 7; i++)
        {
            puff[i] = rand.Next(0,2);
            Console.Write(puff[i] + " ");
            
        }
        */

    }
}
