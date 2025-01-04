string str = Console.ReadLine();
bool ThereIsA = false; // is there an 'a' or not --> true if there is an 'a', false if there isn't an 'a'
for (int i=0; i<str.Length; i++)
{
    if (str[i] == 'a')
    {
        ThereIsA = true;
    }
}
if (ThereIsA)
{
    Console.WriteLine("there is an a");
}
else
{
    Console.WriteLine("there is not an a");
}
