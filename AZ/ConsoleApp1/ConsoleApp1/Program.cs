namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before:");
            Console.WriteLine("Hello^ World/");
            Console.WriteLine();
            Console.WriteLine("After:");
            Console.WriteLine(LowerString("Hello^ World/"));
        }

        static char LowerChar(char x)
        {
            if (x<'A' || x>'Z')
            {
                return x;
            }

            int num = (int)x;
            num += 32;
            return (char)num;
        }

        static string LowerString(string y)
        {
            string newy = "";
            for (int i=0; i<y.Length; i++)
            {
                newy+=LowerChar(y[i]);
            }
            return newy;
        }
    }
}
