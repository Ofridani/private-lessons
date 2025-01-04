using System.Security.Cryptography;
using System.Transactions;

//Console.WriteLine("Enter 10 numbers");
//int max = int.Parse(Console.ReadLine());
//for (int i=1; i<10; i++)
//{
//    int num = int.Parse(Console.ReadLine());
//    if (num>max)
//    {
//        max = num;
//    }
//}
//Console.WriteLine($"The maximum number is {max}");

string lorem = "Lorem ipsu m dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
int count = 0;
char c = Console.ReadLine()[0];
for (int i=0; i < lorem.Length; i++)
{
    if (lorem[i]==c)
    {
        count++;
    }
}
Console.WriteLine(count);