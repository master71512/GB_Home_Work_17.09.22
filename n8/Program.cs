Console.Clear();
Console.WriteLine("Введите положительное число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 0)
{
    Console.Write("число неположительное!");
}
else
{
    int count = 2;
    while (count <= a)
    {
        Console.Write(count);
        count += 2;
        if (count <= a)
        {
            Console.Write(", ");
        }
    }
}