Console.Clear();
Console.WriteLine("Введите 2 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.Write("max = " + a);
}
else
{
    if (a<b)
    {
      Console.Write("max = " + b);  
    }
    else
    {
        Console.Write("max = a = b");
    }
}