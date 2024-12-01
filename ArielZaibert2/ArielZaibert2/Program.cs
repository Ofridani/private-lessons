using System.Data;

int num = int.Parse(Console.ReadLine());
string str = "";
int sum = 0;
for (int i = 1; i <= num; i++)
{
    if (i == num)
    {
        str += i + "=";
    }
    else
    {
        str += i + "+";
    }
    sum += i;
}

Console.WriteLine(str + sum);

