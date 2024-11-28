int x = int.Parse(Console.ReadLine()); // 16
bool hasSeven = false;
while (x > 0 && !hasSeven)
{
    if (x % 10 == 7)
    {
        hasSeven = true;
    }
    x /= 10;
}

if (hasSeven)
{
    Console.WriteLine("This number contains the digit 7!");
}
else
{
    Console.WriteLine("This number does not contain the digit 7!");
}