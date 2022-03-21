using System;
using System.Collections.Generic;
namespace csPrac
{
    public class Jazz : Music
    {
        public int AlbumLength { get; set; }

        public string Genre { get; set; }

        public virtual void bass()
        {
            Console.WriteLine("the bas goes dsjhjksch!");
        }

        public static void jimmyJazz()
        {
            Console.WriteLine("jazz hands!");
        }

    }

    public class Crooner : Jazz
    {
        public override void bass()
        {
            Console.WriteLine("U make me feel so yung");
        }
    }


}