using System;
using System.Collections.Generic;
namespace csPrac
{
    public interface transformers
    {
        public string Name { get; set; }

        public void Transform();
    }
}