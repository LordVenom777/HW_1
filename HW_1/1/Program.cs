Console.WriteLine ("Напишите 2 цифры ");
int r = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);

if (r > y) 
{
    Console.WriteLine ( r + " цифрa больше ");
}
else
{
    Console.WriteLine ( r + " цифрa меньше ");
};

if (y > r) 
{
    Console.WriteLine ( y + " цифрa больше ");   
}
else
{
    Console.WriteLine ( y + " цифрa меньше ");
}