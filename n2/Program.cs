Console.Clear();
Console.WriteLine("Введите 2 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.Write("max = " + a + " min = " + b);
}
else
{
    if (a<b)
    {
      Console.Write("max = " + b + " min = "+ a);  
    }
    else
    {
        Console.Write("max = min = " + a);
    }
}