using System;
using System.Collections.Generic;
namespace csPrac
{
    public class AutoBot : transformers
    {
        public string Name { get; set; }

        public string Shape { get; set; }

        public AutoBot(string nayme)
        {
            Name = nayme;
        }

        public void Transform()
        {
            Console.WriteLine($"{Name} is now a {Shape}");
        }
    }

    public class Decepticon : transformers
    {
        public string Name { get; set; }
        public string Shape { get; set; }

        public virtual void Transform()
        {
            Console.WriteLine($"{Name} is now a {Shape}");
        }
    }
}