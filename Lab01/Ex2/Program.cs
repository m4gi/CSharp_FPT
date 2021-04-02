    using System;
using static Ex2.Dog;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal am1 = new Dog(Breed.Chihuahua);
            am1.printAnimal("Dog");
            Animal am2 = new Cat();
            am2.printAnimal("Meow");
            Animal am3 = new Duck();
            am3.printAnimal("Duck");
        }
    }
}
