using System;

namespace inheritance_123
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal();
            Cat c = new Cat();
            Dog d = new Dog();
            ani.AnimalSound();
            c.AnimalSound();
            d.AnimalSound();

        }
    }
}
