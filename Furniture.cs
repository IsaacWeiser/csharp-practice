using System;
using System.Collections.Generic;
namespace csPrac
{
    public class Furniture
    {
        public string Name { get; set; }
        public string Room { get; set; }
    }

    public class Couch : Furniture, ISeating
    {
        public bool hasArmRest { get; set; }
    }
    public class Loveseat : Furniture, ISeating
    {
        public bool hasArmRest { get; set; }
    }
    public class Nightstand : Furniture, ITable
    {
        public int width { get; set; }
        public int length { get; set; }
        public int height { get; set; }
    }
    public class DiningTable : Furniture, ITable
    {
        public int width { get; set; }
        public int length { get; set; }
        public int height { get; set; }
    }
    public class DiningChair : Furniture, ISeating
    {
        public bool hasArmRest { get; set; }
    }
}