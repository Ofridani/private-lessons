int num = int.Parse(Console.ReadLine());
bool is_Rising = true;
int before = num%10;
while (num > 0)
{
    num /= 10;
    if (before <= num % 10)
    {
        is_Rising = false;
    }
    before = num % 10;
}

Console.WriteLine(is_Rising);
