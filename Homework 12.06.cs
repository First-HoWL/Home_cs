int a = 0, b = 0, c;

Console.Write("First numb:");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Second numb:");
b = Convert.ToInt32(Console.ReadLine());


for (int i = 0, j = 1; i < b;)
{
    c = i;
    i = i + j;
    j = c;
    if (i >= a && i <= b)
    {
        Console.Write($"{i}, ");
    }
}
