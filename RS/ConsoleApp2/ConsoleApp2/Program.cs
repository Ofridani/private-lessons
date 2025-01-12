namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcTicketPrice(30, true));  
        }

        static double CalcTicketPrice(double km, bool hasPass)
        {
            double price = 0;
            if (km <= 5)
            {
                price += 5;
            }
            else if (km > 5 && km <= 20)
            {
                price += 5;
                price += (km - 5) * 2;
                
            }
            else
            {
                price += 5;
                price += 20 * 2;
                price += (km - 5 - 20) * 3;
            }
            if (hasPass)
            {
                price *= 0.8;
            }
            return price;
        }

        static bool IsDigitsAscending(int n)
        {
            while (n > 0)
            {
                if ((n / 10) % 10 >= n % 10)
                {
                    return false;
                }
                n /= 10;
            }
            return true;
        }

        static bool HasEvenDigit(int num)
        {
            while (num > 0)
            {
                if ((num % 10) % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
