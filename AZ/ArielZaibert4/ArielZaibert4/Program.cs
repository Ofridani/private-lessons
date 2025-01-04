namespace ArielZaibert4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printCheckerBoard();
        }

        static void printStars()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++) // prints *, i times
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // goes down a line
            }
        }

        static void printCheckerBoard()
        {
            for (int row = 1; row < 5; row++)
            {
                if (row %2==0)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
