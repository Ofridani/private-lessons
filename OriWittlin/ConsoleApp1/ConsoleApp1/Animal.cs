using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        protected int weight;

        public Animal(int w) // Normal Constructor
        {
            this.weight = w;
        }

        public Animal(Animal other) // Copy constructor
        {
            this.weight = other.weight;
        }

        public virtual void Speak()
        {
            Console.WriteLine("The animal is speaking");
        }

        public void PrintWeight()
        {
            Console.WriteLine("The animal's weight is " + this.weight);
        }

        public int GetWeight()
        {
            return this.weight;
        }

        public void SetWeight(int w)
        {
            if (w > 500)
            {
                this.weight = 500;
            }
            else if (w < 0)
            {
                this.weight = 0;
            }
            else
            {
                this.weight = w;
            }
        }

        public virtual string GetColor()
        {
            return "N/A";
        }
    }
}
