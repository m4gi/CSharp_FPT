using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class Cat : Animal
    {
        Random r = new Random();
        protected string Climb;
        public Cat() : base(true, false)
        {
        }
        public override string getGreeting()
        {
            return "Meow Meow";
        }

        public override void printAnimal(String name)
        {
            Console.WriteLine("A " + name + " says '" + this.getGreeting() + "', is " + (this.getIsBird() ? "" : "not ") + "bird,  is " + (this.getIsMammal() ? "" : "not ") + "a mammal, and is climbing on " + getClimb());
        }
        public string getClimb()
        {
            switch (r.Next(0, 3))
            {
                case 0:
                    Climb = "Tree";
                    break;
                case 1:
                    Climb = "Wall";
                    break;
                case 2:
                    Climb = "Roof";
                    break;
                default:
                    Climb = "Unknown";
                    break;
            }
            return Climb;
        }
    }
}
