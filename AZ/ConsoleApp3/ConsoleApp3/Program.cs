namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=100; i++)
            {
                Console.WriteLine($"{i} {CountEvenDigits(i)}");
            }
        }
        static int CountEvenDigits(int num)
        {
            int count = 0;
            while (num>0)
            {
                if ((num%10)%2==0)
                {
                    count += 1;
                }    
                num /= 10;
            }
            return count;
        }
    }
}
