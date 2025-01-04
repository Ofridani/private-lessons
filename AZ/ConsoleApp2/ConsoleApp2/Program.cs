using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            primeRange(x);
        }
        
        static void primeRange(int n)
        {
            bool isPrime; // is i prime or not
            for (int i = 1; i <= n; i++) // all the numbers between 1 and n (including)
            {
                // is i prime or not?
                isPrime = true;
                for (int j = 2; j < i; j++) // all the numbers between 2 and i-1 (including)
                {
                    if (i % j == 0) // if i is divisible by j without a remainder
                    {
                        isPrime = false; // then i is not prime anymore
                    }
                }
                // isPrime now correctly represents if the number is prime or not.

                if (isPrime == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
