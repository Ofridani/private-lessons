Console.WriteLine("Please enter a 5-digit number:");
int x = int.Parse(Console.ReadLine());
int newNum = 0;

for (int i = 0; i < 5; i++)
{
    if (x % 10 == 9)
    {
        newNum += 0;
    }
    else
    {
        newNum += ((x % 10) + 1) * (int)Math.Pow(10, i);
    }
    x /= 10;
}
Console.WriteLine();