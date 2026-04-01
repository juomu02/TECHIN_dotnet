Console.WriteLine("1. uždavinys");
for (var i = 1; i <= 10; i++) { Console.WriteLine(i); }

Console.WriteLine("2. uždavinys");
for (var i = 10; i >= 1; i--) { Console.WriteLine(i); }

Console.WriteLine("3. uždavinys");
int rezultatas = 1;
for (var i = 0; i < 10; i++) { Console.WriteLine(rezultatas); rezultatas++; }

Console.WriteLine("4. uždavinys");
string userInput;
Console.WriteLine("Įveskite skaičių.");
userInput = Console.ReadLine();
if (Int32.TryParse(userInput, out int n))
{
    for (var i = 1; i <= n; i++)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("5. uždavinys");
string userInput5;
Console.WriteLine("Įveskite skaičių.");
userInput5 = Console.ReadLine();
if (Int32.TryParse(userInput5, out int n5))
{
    for (var i = 1; i <= n5; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

Console.WriteLine("6. uždavinys");
string userInput6;
Console.WriteLine("Įveskite skaičių.");
userInput6 = Console.ReadLine();
int result6 = 0;
if (Int32.TryParse(userInput6, out int n6))
{
    for (var i = 1; i <= n6; i++)
    {
        result6 += i;
    }
}
Console.WriteLine(result6);


Console.WriteLine("7. uždavinys");
string userInput7;
Console.Write("Įveskite skaičių: ");
userInput7 = Console.ReadLine();
int result7 = 0;
do
{
    if (Int32.TryParse(userInput7, out int n7))
    {
        result7 += n7;
    }
    else userInput7 = "exit";
    Console.WriteLine("Suma: " + result7);
    Console.Write("Įveskite kitą skaičių: ");
    userInput7 = Console.ReadLine();

}
while (userInput7 != "exit");


Console.WriteLine("8. uždavinys");
string userInput8;
Console.Write("Įveskite skaičių: ");
userInput8 = Console.ReadLine();
int resultEven8 = 0;
int resultOdd8 = 0;
do
{
    if (Int32.TryParse(userInput8, out int n8))
    {
        if (n8 % 2 == 0) { resultEven8 += n8; }
        else resultOdd8 += n8
        ;
    }
    else userInput8 = "exit";
    Console.WriteLine($"Lyginių skaičių suma: {resultEven8}; Nelyginių skaičių suma: {resultOdd8}");
    Console.Write("Įveskite kitą skaičių: ");
    userInput8 = Console.ReadLine();

}
while (userInput8 != "exit");


Console.WriteLine("9. uždavinys");
string userInputFirst9;
string userInputSecond9;
Console.Write("Įveskite pirmą skaičių: ");
userInputFirst9 = Console.ReadLine();
Console.Write("Įveskite antrą skaičių: ");
userInputSecond9 = Console.ReadLine();
int remainder;
int dividend;
int divisor;

if (Int32.TryParse(userInputFirst9, out int f9) && Int32.TryParse(userInputSecond9, out int s9))
{
    if (f9 > s9) { dividend = f9; divisor = s9; } else { dividend = s9; divisor = f9; }

    while (divisor != 0)
    {
        remainder = dividend % divisor;
        dividend = divisor;
        divisor = remainder;
    }
    Console.WriteLine(dividend);
}

Console.WriteLine("10. uždavinys");
string userInput10;
Console.Write("Įveskite skaičių: ");
userInput10 = Console.ReadLine();
int previous = 0;
int next = 1;
int sum = 0;
if (Int32.TryParse(userInput10, out int n10))
{
    for (int i = 0; i < n10; i++)
    {
        sum = previous + next;
        previous = next;
        next = sum;
    }
    Console.WriteLine(sum);
}
