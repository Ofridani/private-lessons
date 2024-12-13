namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal(20);

            Animal d1 = new Dog(20, "Black");
            Dog d2 = a1 as Dog;
            d2.SetColor("White");
        }
    }

    


}
