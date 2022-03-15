using System;
using System.Collections.Generic;
namespace csPrac
{
    public interface transformers
    {
        public string Name { get; set; }

        public void Transform();
    }

    public interface ISeating
    {
        public bool hasArmRest { get; set; }
    }

    public interface ITable
    {
        public int width { get; set; }
        public int length { get; set; }
        public int height { get; set; }
    }
}