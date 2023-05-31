Console.WriteLine ("Напишите 3 цифры ");
int r = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);
int h = int.Parse(Console.ReadLine()!);
int max = r;

if (r > max) max = r;

if (y > max) max = y;

if (h > max) max = h;

Console.Write("max = ");
Console.WriteLine(max);