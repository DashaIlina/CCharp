Console.WriteLine(" Напишите пятизначенное число ");

int n = int.Parse(Console.ReadLine());
if (n >= 10000 && n < 100000)
{
    int digit5 = n % 10;
    n /= 10;
    int digit4 = n % 10;
    n /= 10;
    n /= 10;
    int digit2 = n % 10;
    n /= 10;
    int digit1 = n % 10;
    if (digit1 == digit5 && digit2 == digit4)
        System.Console.WriteLine(" Число палиндром ");
    else
        System.Console.WriteLine(" Число не палиндром");
}
else
    Console.WriteLine(" Напишите пятизначенное число ");

//System.Console.WriteLine(digit1 + digit2 + digit4 + digit5);
