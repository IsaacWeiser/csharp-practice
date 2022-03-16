using System;
using System.Collections.Generic;
namespace csPrac
{
    public class Iphone : IPod, IProduct
    {
        public double Screen { get; set; }

        public Iphone(double inch)
        {
            Screen = inch;
        }

        public override void playSong()
        {
            Console.WriteLine("oppa gangnam style");
        }

    }
}