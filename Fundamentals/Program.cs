// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// values between 1-255
for (int i = 1; i< 256; i++)
{
    Console.WriteLine(i);
}

int j = 1;
while(j < 256)
{
    Console.WriteLine(j);
    j++;
}


// 5 random numbers between 10 and 20 and get the sum of total
Random rand = new Random();
int sum = 0;
for ( int i = 0; i<5; i++)
{
    int num = rand.Next(10,21);
    Console.WriteLine($"Random Number: {num}");
    sum += num;
    Console.WriteLine($"Current Sum: {sum}");
}
Console.WriteLine("Final Sum:{0}", sum);

sum = 0;
j = 0;
while ( j < 5)
{
    int num = rand.Next(10,21);
    Console.WriteLine($"Random Number: {num}");
    sum += num;
    Console.WriteLine($"Current Sum: {sum}");
    j++;
}
Console.WriteLine("Final Sum:{0}", sum);


// 1-100 numbers divisible by 3 or 5 but not both

for (int i=1; i<101; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        continue;
    }
    if(i % 3 == 0 || i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}

j=1;
while(j<101)
{
    if (j % 3 == 0 && j % 5 == 0)
    {
        continue;
    }
    if(j % 3 == 0 || j % 5 == 0)
    {
        Console.WriteLine(j);
    }
    j++;
}

// if multiple of 3 print Fizz and Buzz for multiple of 5
for (int i=1; i<101; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        continue;
    }
    if(i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
}


j = 1;
while (j < 101)
{
    if(j % 3 == 0 && j % 5 == 0)
    {
        continue;
    }
    if(j % 3 == 0)
    {
        Console.WriteLine($"{j} - Fizz");
    }
    if (j % 5 == 0)
    {
        Console.WriteLine($"{j} - Buzz");
    }
    j++;
}

// Add FizzBuzz to mutiples of 3 & 5
for (int i=1; i<101; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - Fizz Buzz");
    }
    if(i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
}

j = 1;
while(j < 101)
{
    if(j % 3 == 0 && j % 5 == 0)
    {
        Console.WriteLine($"{j} - Fizz Buzz");
    }
    if(j % 3 == 0)
    {
        Console.WriteLine($"{j} - Fizz");
    }
    if (j % 5 == 0)
    {
        Console.WriteLine($"{j} - Buzz");
    }
    j++;
}


