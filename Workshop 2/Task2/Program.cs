
Console.WriteLine(" Введите x и y");
Console.Write(" Введите x ");
int x = int.Parse(Console.ReadLine());
Console.Write(" Введите y ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0) Console.Write(" Координата (" + x + "," + y +") находится в 1 четверти ");
if (x < 0 && y < 0) Console.Write(" Координата (" + x + "," + y +") находится в 3 четверти ");
if (x < 0 && y > 0) Console.Write(" Координата (" + x + "," + y +") находится в 2 четверти ");
if (x > 0 && y < 0) Console.Write(" Координата (" + x + "," + y +") находится в 4 четверти ");

