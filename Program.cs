int s = 0;
int m = 0;

for (int i = 1; i <= 100; i++)
{
    s = i % 3;
    m = i % 5;
    if (s == 0 && m != 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (s != 0 && m == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else if (s == 0 && m == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
