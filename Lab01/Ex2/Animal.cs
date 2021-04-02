using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    abstract class Animal
    {
        protected bool isMammal;
        protected bool isBird;

        public Animal(bool isMammal, bool isBird)
        {
            this.isMammal = isMammal;
            this.isBird = isBird;
        }

        public bool getIsMammal()
        {
            return this.isMammal;
        }
        public bool getIsBird()
        {
            return this.isBird;
        }


        abstract public String getGreeting();

        public virtual void printAnimal(String name)
        {
            Console.WriteLine("A " + name + " says '" + this.getGreeting() + "', is " + (this.getIsBird() ? "" : "not ") + "bird, and is " + (this.getIsMammal() ? "" : "not ") + "a mammal.");
        }
    }
}

