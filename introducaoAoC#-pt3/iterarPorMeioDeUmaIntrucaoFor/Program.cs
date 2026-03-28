/*
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}
*/

/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7)
        break;
}
*/

/*
string[] names = {"Alex", "Eddie", "David", "Michael"};
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach(var name in names) Console.WriteLine(name);
*/

for (int i = 1; i <= 100; i++)
{
    int divisilvePor3 = i % 3;
    int divisilvePor5 = i % 5;

    if (divisilvePor3 == 0 && divisilvePor5 == 0)
        Console.WriteLine($"{i} - FizzBuzz");
    else if (divisilvePor5 == 0)
        Console.WriteLine($"{i} - Buzz");    
    else if (divisilvePor3 == 0)
        Console.WriteLine($"{i} - Fizz");    
    else
        Console.WriteLine($"{i}");
    
}