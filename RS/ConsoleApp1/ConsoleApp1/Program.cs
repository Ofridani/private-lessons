namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = LowerChar('z');
            Console.WriteLine(c);
        }
        static char LowerChar(char myChar)
        {
            if (myChar >= 'A' && myChar <= 'Z') // is myChar uppercase?
            {
                return (char)(myChar - ('A' - 'a')); // return myChar as lowercase.
            }
            return myChar; // if not return myChar as usual.
        }

        static string LowerString(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                newStr += LowerChar(str[i]);
            }
            return newStr;

        }

    }
}
