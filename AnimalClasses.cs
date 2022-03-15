using System;
using System.Collections.Generic;
namespace csPrac
{
    public class Animal
    {
        public string Name { get; set; }

        public virtual void speak()
        {
            Console.WriteLine($"Growl!");
        }
    }

    public class Tiger : Animal
    {
        public override void speak()
        {
            Console.WriteLine("GRRR!");
        }
    }

    public class Dog : Animal
    {

    }

    public class Cat : Animal
    {

    }

    public class Snake : Animal
    {

    }
}