using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog : Animal
    {
        private string color;
        public Dog(int w, string c) : base(w) // Normal Dog Constructor
        {
            this.color = c;
        }

        public Dog(Animal d, string c) : base(d) // Copying Dog Constructor
        {
            this.color = c;
        }

        public override string GetColor()
        {
            return this.color;
        }

        public void SetColor(string c)
        {
            this.color = c;
        }

        public override void Speak()
        {
            Console.WriteLine("The dog is speaking");
        }

        public void SpeakAsAnimal()
        {
            base.Speak();
        }
    }
}
