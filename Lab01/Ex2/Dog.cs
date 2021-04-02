using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{

    class Dog : Animal
    {

        public enum Breed
        {
            Spaniel,
            Chihuahua,
            Collie,
            Unknown
        }
        Breed kinds;


        public Dog(Breed kinds) : base(true, false)
        {
            this.kinds = kinds;
        }

        public override string getGreeting()
        {
            return "Bark Bark";
        }
        private string getBreed()
        {
            switch (kinds)
            {
                case Breed.Chihuahua:
                    return "Chihuahua";
                case Breed.Collie:
                    return "Collie";
                case Breed.Spaniel:
                    return "Spaniel";
            }
            return "Unknown";
        }
        public override void printAnimal(String name)
        {
            Console.WriteLine("A " + name + " says '" + this.getGreeting() + "', is " + (this.getIsBird() ? "" : "not ") + "bird,  is " + (this.getIsMammal() ? "" : "not ") + "a mammal, and belongs to breed " + getBreed());
        }

    }
}
