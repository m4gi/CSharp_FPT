using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class Duck : Animal
    {
        Random r = new Random();
        protected string Swim;
        public Duck() : base(false, true)
        {

        }

        public override string getGreeting()
        {
            return "Quack Quack";
        }

        public string getSwim()
        {
            switch (r.Next(0, 3))
            {
                case 0:
                    Swim = "Pond";
                    break;
                case 1:
                    Swim = "Pool";
                    break;
                case 2:
                    Swim = "River";
                    break;
                default:
                    Swim = "Unknown";
                    break;
            }
            return Swim;
        }
        public override void printAnimal(String name)
        {
            Console.WriteLine("A " + name + " says '" + this.getGreeting() + "', is " + (this.getIsBird() ? "" : "not ") + "bird,  is " + (this.getIsMammal() ? "" : "not ") + "a mammal, and is swimming on " + getSwim());
        }
    }
}
