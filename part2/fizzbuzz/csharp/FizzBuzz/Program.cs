// number divisible by three with the word "fizz", and any number divisible by five with the word "buzz", and any number divisible by both three and five with the word "fizzbuzz".

for(int n = 1; n <= 100; n++)
{
    if(n % 15 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (n % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if (n % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(n);
    }
}